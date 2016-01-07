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
        enum PingStatus { none, good, poor, bad};
        Timer primaryTimer = new Timer();
        Timer secondaryTimer = new Timer();
        IPAddress primaryTargetIP = null;
        IPAddress secondaryTargetIP = null;
        bool primaryPingRunning = false;
        bool secondaryPringRunning = false;

        public MainForm()
        {
            InitializeComponent();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            primaryTimer.Tick += new EventHandler(primaryTick);
            primaryTimer.Interval = 1000;
                     
        }

        private void primaryTick(Object myObject, EventArgs myEventArgs)
        {       
            if (primaryTargetIP != null)
            {
                Ping pingPrimaryTarget = new Ping();
                PingReply replyPrimaryTarget;
                primaryReply_txt.Text = "";

                try
                {
                    replyPrimaryTarget = pingPrimaryTarget.Send(primaryTargetIP);             
                    if (replyPrimaryTarget.Status == IPStatus.Success)
                    {
                        setReplyOutput(ref primaryReply_txt, replyPrimaryTarget);

                        if(replyPrimaryTarget.RoundtripTime < 100)
                            setNotification(PingStatus.good);
                        else if(replyPrimaryTarget.RoundtripTime < 300)
                            setNotification(PingStatus.poor);
                        else
                            setNotification(PingStatus.bad);

                    }
                    else
                    {
                        primaryReply_txt.Text = replyPrimaryTarget.Status.ToString();
                        setNotification(PingStatus.bad);
                    }
                        
                }
                catch
                {
                    primaryStatus_txt.Text = "Error";
                    setNotification(PingStatus.bad);
                }
            }


        }


        private void primaryTargetToggle_btn_Click(object sender, EventArgs e)
        {
            if(primaryPingRunning == true)
            {
                primaryTimer.Stop();
                primaryStatus_txt.Text = "Stopped";
                primaryTargetToggle_btn.Text = "Start";
                primaryPingRunning = false;
                primaryReply_txt.Text = "";
                setNotification(PingStatus.none);
            }
            else
            {
                resolveHostname(ref primaryTargetIP, primaryTarget_txt.Text);
                if (primaryTargetIP != null)
                {
                    primaryTimer.Start();
                    primaryStatus_txt.Text = "Running";
                    primaryTargetToggle_btn.Text = "Stop";
                    primaryPingRunning = true;
                }
            }
        }


        private void resolveHostname(ref IPAddress ip, string hostname)
        {       
            IPHostEntry host;
            try
            {
                host = Dns.GetHostEntry(hostname);
                ip = host.AddressList[0];
            }
            catch
            {
                ip = null;
                primaryReply_txt.Text = "Unable to resolve hostname.";
            }
        }


        private void primaryTarget_txt_TextChanged(object sender, EventArgs e)
        {
            if (primaryPingRunning == true)
            {
                primaryTimer.Stop();
                primaryStatus_txt.Text = "Stopped";
                primaryTargetToggle_btn.Text = "Start";
                primaryPingRunning = false;
                primaryReply_txt.Text = "";
            }
        }


        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(3000);
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
            label.Text += "Address: " + reply.Address.ToString() + "\r\n";
            label.Text += "RoundTrip time: " + reply.RoundtripTime.ToString() + "\r\n";
            label.Text += "Time to live: " + reply.Options.Ttl.ToString() + "\r\n";
            label.Text += "Don't fragment: " + reply.Options.DontFragment.ToString() + "\r\n";
            label.Text += "Buffer size: " + reply.Buffer.Length.ToString() + "\r\n";
        }
    }
}
