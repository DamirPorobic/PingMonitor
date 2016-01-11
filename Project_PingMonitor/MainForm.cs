using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;

namespace Project_PingMonitor
{
    public partial class MainForm : Form
    {
        enum PingStatus { good, poor, bad, none};
        Timer pingTimer = new Timer();
        IPAddress primaryTargetIP = null;
        IPAddress secondaryTargetIP = null;
        bool primaryPingRunning = false;
        bool secondaryPingRunning = false;
        Ping pingTarget = new Ping();
        PingReply replyPrimaryTarget;
        PingReply replySecondaryTarget;

        public MainForm()
        {
            InitializeComponent();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            pingTimer.Tick += new EventHandler(primaryTick);
            pingTimer.Interval = Decimal.ToInt32(pingInterval_nupdn.Value) * 1000;
            pingTimer.Start();

            primaryTarget_txt.Text = Properties.Settings.Default.primaryTarget;
            secondaryTarget_txt.Text = Properties.Settings.Default.secondaryTarget;
            lowThreshold_nupdn.Value = Properties.Settings.Default.thresholdLow;
            highThreshold_nupdn.Value = Properties.Settings.Default.thresholdHigh;
            pingInterval_nupdn.Value = Properties.Settings.Default.pingInterval;

            if(Properties.Settings.Default.primaryTargetEnabled)
                primaryTargetToggle();

            if (Properties.Settings.Default.secondaryTargetEnabled)
                secondaryTargetToggle();

            if (Properties.Settings.Default.ReachabilityCheckBestOfTwo)
                reachability_bestOfTwo_rbtn.Checked = true;
            else
                reachability_worstOfTwo_rbtn.Checked = true;

        }

        private void primaryTick(Object myObject, EventArgs myEventArgs)
        {       
            if (primaryPingRunning == true)
            {
                try
                {
                    replyPrimaryTarget = pingTarget.Send(primaryTargetIP);
                    setReplyOutput(ref primaryReply_txt, replyPrimaryTarget);

                    if (replyPrimaryTarget.Status != IPStatus.Success)
                        replyPrimaryTarget = null;
                }
                catch
                {
                    replyPrimaryTarget = null;
                    primaryReply_txt.Text = "Some error has occurred.";
                }
            }
            else
                replyPrimaryTarget = null;

            if (secondaryPingRunning == true)
            {
                try
                {
                    replySecondaryTarget = pingTarget.Send(secondaryTargetIP);
                    setReplyOutput(ref secondaryReply_txt, replySecondaryTarget);

                    if (replySecondaryTarget.Status != IPStatus.Success)
                        replySecondaryTarget = null;
                }
                catch
                {
                    replySecondaryTarget = null;
                    secondaryReply_txt.Text = "Some error has occurred.";
                }
            }
            else
                replySecondaryTarget = null;

            checkReply(replyPrimaryTarget, replySecondaryTarget);

        }

        private void checkReply(PingReply primaryReply, PingReply secondaryReply)
        {
            if (primaryPingRunning || secondaryPingRunning)
            {
                if (Properties.Settings.Default.ReachabilityCheckBestOfTwo)
                {
                    if (checkRoundTripTime(primaryReply) <= checkRoundTripTime(secondaryReply))
                        setNotification(checkRoundTripTime(primaryReply));
                    else
                        setNotification(checkRoundTripTime(secondaryReply));
                }
                else
                {
                    if (checkRoundTripTime(primaryReply) >= checkRoundTripTime(secondaryReply))
                        setNotification((primaryPingRunning) ? checkRoundTripTime(primaryReply) : checkRoundTripTime(secondaryReply));
                    else
                        setNotification((secondaryPingRunning) ? checkRoundTripTime(secondaryReply) : checkRoundTripTime(primaryReply));
                }
            }
            else
                setNotification(PingStatus.none);

        }

        private PingStatus checkRoundTripTime(PingReply pingReply)
        {
            if (pingReply == null)
                return PingStatus.none;

            if (pingReply.RoundtripTime < Properties.Settings.Default.thresholdLow)
                return PingStatus.good;
            else if (pingReply.RoundtripTime < Properties.Settings.Default.thresholdHigh)
                return PingStatus.poor;
            else
                return PingStatus.bad;
        }


        private void primaryTargetToggle_btn_Click(object sender, EventArgs e)
        {
            primaryTargetToggle();
        }

        private void secondaryTargetToggle_btn_Click(object sender, EventArgs e)
        {
            secondaryTargetToggle();
        }


        private void primaryTargetToggle()
        {
            if (primaryPingRunning == true)
            {
                primaryStatus_txt.Text = "Stopped";
                primaryTargetToggle_btn.Text = "Start";
                primaryPingRunning = false;
                primaryTarget_txt.Enabled = true;
                primaryReply_txt.Text = "";
      
                Properties.Settings.Default.primaryTargetEnabled = false;
                Properties.Settings.Default.Save();
            }
            else
            {
                primaryTargetIP = resolveHostname(primaryTarget_txt.Text);
                if (primaryTargetIP != null)
                {
                    primaryStatus_txt.Text = "Running";
                    primaryTargetToggle_btn.Text = "Stop";
                    primaryTarget_txt.Enabled = false;
                    primaryPingRunning = true;

                    Properties.Settings.Default.primaryTarget = primaryTarget_txt.Text;
                    Properties.Settings.Default.primaryTargetEnabled = true;
                    Properties.Settings.Default.Save();
                }
                else
                    primaryReply_txt.Text = "Unable to resolve hostname.";
            }
        }

        private void secondaryTargetToggle()
        {
            if (secondaryPingRunning == true)
            {
                secondaryStatus_txt.Text = "Stopped";
                secondaryTargetToggle_btn.Text = "Start";
                secondaryPingRunning = false;
                secondaryTarget_txt.Enabled = true;
                secondaryReply_txt.Text = "";

                Properties.Settings.Default.secondaryTargetEnabled = false;
                Properties.Settings.Default.Save();
            }
            else
            {
                secondaryTargetIP = resolveHostname(secondaryTarget_txt.Text);
                if (secondaryTargetIP != null)
                {
                    secondaryStatus_txt.Text = "Running";
                    secondaryTargetToggle_btn.Text = "Stop";
                    secondaryTarget_txt.Enabled = false;
                    secondaryPingRunning = true;

                    Properties.Settings.Default.secondaryTarget = secondaryTarget_txt.Text;
                    Properties.Settings.Default.secondaryTargetEnabled = true;
                    Properties.Settings.Default.Save();
                }
                else
                    secondaryReply_txt.Text = "Unable to resolve hostname.";
            }
        }


        private IPAddress resolveHostname(string hostname)
        {       
            try
            {
                return Dns.GetHostEntry(hostname).AddressList[0];
            }
            catch
            {
                return null;
            }
        }


        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(500);
                this.ShowInTaskbar = false;
            }

            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIcon.Visible = false;
                this.ShowInTaskbar = true;
            }
        }


        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon.Visible = false;
        }


        private void setNotification(PingStatus status)
        {
            switch (status)
            {
                case PingStatus.none:
                    this.Icon = Properties.Resources.PM_DarkGray;
                    notifyIcon.Icon = Properties.Resources.PM_DarkGray;
                    this.Text = "Ping Monitor";
                    break;

                case PingStatus.good:
                    this.Icon = Properties.Resources.PM_Green;
                    notifyIcon.Icon = Properties.Resources.PM_Green;
                    this.Text = "Ping Monitor | Status: good";
                    break;

                case PingStatus.poor:
                    this.Icon = Properties.Resources.PM_Yellow;
                    notifyIcon.Icon = Properties.Resources.PM_Yellow;
                    this.Text = "Ping Monitor | Status: poor";
                    break;

                case PingStatus.bad:
                    this.Icon = Properties.Resources.PM_Red;
                    notifyIcon.Icon = Properties.Resources.PM_Red;
                    this.Text = "Ping Monitor | Status: bad";
                    break;              
            }
        }

        private void setReplyOutput(ref Label label, PingReply reply)
        {
            if (reply.Status == IPStatus.Success)
            {
                label.Text = "Address: " + reply.Address.ToString() + "\r\n";
                label.Text += "RoundTrip time: " + reply.RoundtripTime.ToString() + "  |  " + checkRoundTripTime(reply).ToString() + "\r\n";
                label.Text += "Time to live: " + reply.Options.Ttl.ToString() + "\r\n";
                label.Text += "Don't fragment: " + reply.Options.DontFragment.ToString() + "\r\n";
                label.Text += "Buffer size: " + reply.Buffer.Length.ToString() + "\r\n";
            }
            else
                label.Text = reply.Status.ToString();   
        }


        private void lowThreshold_nupdn_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.thresholdLow = Decimal.ToInt32(lowThreshold_nupdn.Value);
            Properties.Settings.Default.Save();

            if (lowThreshold_nupdn.Value >= highThreshold_nupdn.Value)
                highThreshold_nupdn.Value = lowThreshold_nupdn.Value + 1;
        }

        private void highThreshold_nupdn_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.thresholdHigh = Decimal.ToInt32(highThreshold_nupdn.Value);
            Properties.Settings.Default.Save();

            if (highThreshold_nupdn.Value <= lowThreshold_nupdn.Value)
                lowThreshold_nupdn.Value = highThreshold_nupdn.Value - 1;
        }

        private void pingInterval_nupdn_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.pingInterval = Decimal.ToInt32(pingInterval_nupdn.Value);
            Properties.Settings.Default.Save();

            pingTimer.Interval = Decimal.ToInt32(pingInterval_nupdn.Value) * 1000;
        }

        private void reachability_bestOfTwo_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ReachabilityCheckBestOfTwo = true;
            Properties.Settings.Default.Save();
        }

        private void reachability_worstOfTwo_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ReachabilityCheckBestOfTwo = false;
            Properties.Settings.Default.Save();
        }
    }
}
