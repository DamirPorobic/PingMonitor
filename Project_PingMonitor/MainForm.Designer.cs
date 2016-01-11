namespace Project_PingMonitor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.primaryStatus_txt = new System.Windows.Forms.Label();
            this.primaryStatus_lbl = new System.Windows.Forms.Label();
            this.primaryTargetToggle_btn = new System.Windows.Forms.Button();
            this.primaryReply_txt = new System.Windows.Forms.Label();
            this.primaryReply_lbl = new System.Windows.Forms.Label();
            this.primaryTarget_txt = new System.Windows.Forms.TextBox();
            this.primaryTarget_lbl = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.secondaryStatus_txt = new System.Windows.Forms.Label();
            this.secondaryStatus_lbl = new System.Windows.Forms.Label();
            this.secondaryTargetToggle_btn = new System.Windows.Forms.Button();
            this.secondaryTarget_lbl = new System.Windows.Forms.Label();
            this.secondaryReply_txt = new System.Windows.Forms.Label();
            this.secondaryTarget_txt = new System.Windows.Forms.TextBox();
            this.secondaryReply_lbl = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pingInterval_nupdn = new System.Windows.Forms.NumericUpDown();
            this.ping_interval_lbl = new System.Windows.Forms.Label();
            this.highThreshold_nupdn = new System.Windows.Forms.NumericUpDown();
            this.lowThreshold_nupdn = new System.Windows.Forms.NumericUpDown();
            this.reachability_lbl = new System.Windows.Forms.Label();
            this.reachability_bestOfTwo_rbtn = new System.Windows.Forms.RadioButton();
            this.reachability_worstOfTwo_rbtn = new System.Windows.Forms.RadioButton();
            this.highThreshold_lbl = new System.Windows.Forms.Label();
            this.lowThreshold_lbl = new System.Windows.Forms.Label();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pingInterval_nupdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highThreshold_nupdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowThreshold_nupdn)).BeginInit();
            this.SuspendLayout();
            // 
            // primaryStatus_txt
            // 
            this.primaryStatus_txt.AutoSize = true;
            this.primaryStatus_txt.Location = new System.Drawing.Point(65, 38);
            this.primaryStatus_txt.Name = "primaryStatus_txt";
            this.primaryStatus_txt.Size = new System.Drawing.Size(47, 13);
            this.primaryStatus_txt.TabIndex = 8;
            this.primaryStatus_txt.Text = "Stopped";
            // 
            // primaryStatus_lbl
            // 
            this.primaryStatus_lbl.AutoSize = true;
            this.primaryStatus_lbl.Location = new System.Drawing.Point(15, 38);
            this.primaryStatus_lbl.Name = "primaryStatus_lbl";
            this.primaryStatus_lbl.Size = new System.Drawing.Size(40, 13);
            this.primaryStatus_lbl.TabIndex = 7;
            this.primaryStatus_lbl.Text = "Status:";
            // 
            // primaryTargetToggle_btn
            // 
            this.primaryTargetToggle_btn.Location = new System.Drawing.Point(277, 8);
            this.primaryTargetToggle_btn.Name = "primaryTargetToggle_btn";
            this.primaryTargetToggle_btn.Size = new System.Drawing.Size(75, 23);
            this.primaryTargetToggle_btn.TabIndex = 6;
            this.primaryTargetToggle_btn.Text = "Start";
            this.primaryTargetToggle_btn.UseVisualStyleBackColor = true;
            this.primaryTargetToggle_btn.Click += new System.EventHandler(this.primaryTargetToggle_btn_Click);
            // 
            // primaryReply_txt
            // 
            this.primaryReply_txt.AutoSize = true;
            this.primaryReply_txt.Location = new System.Drawing.Point(65, 63);
            this.primaryReply_txt.Name = "primaryReply_txt";
            this.primaryReply_txt.Size = new System.Drawing.Size(0, 13);
            this.primaryReply_txt.TabIndex = 5;
            // 
            // primaryReply_lbl
            // 
            this.primaryReply_lbl.AutoSize = true;
            this.primaryReply_lbl.Location = new System.Drawing.Point(15, 63);
            this.primaryReply_lbl.Name = "primaryReply_lbl";
            this.primaryReply_lbl.Size = new System.Drawing.Size(37, 13);
            this.primaryReply_lbl.TabIndex = 4;
            this.primaryReply_lbl.Text = "Reply:\r\n";
            // 
            // primaryTarget_txt
            // 
            this.primaryTarget_txt.Location = new System.Drawing.Point(65, 10);
            this.primaryTarget_txt.Name = "primaryTarget_txt";
            this.primaryTarget_txt.Size = new System.Drawing.Size(203, 20);
            this.primaryTarget_txt.TabIndex = 3;
            // 
            // primaryTarget_lbl
            // 
            this.primaryTarget_lbl.AutoSize = true;
            this.primaryTarget_lbl.Location = new System.Drawing.Point(15, 13);
            this.primaryTarget_lbl.Name = "primaryTarget_lbl";
            this.primaryTarget_lbl.Size = new System.Drawing.Size(41, 13);
            this.primaryTarget_lbl.TabIndex = 2;
            this.primaryTarget_lbl.Text = "Target:";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Ping Monitor";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(390, 160);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.primaryStatus_txt);
            this.tabPage1.Controls.Add(this.primaryStatus_lbl);
            this.tabPage1.Controls.Add(this.primaryTargetToggle_btn);
            this.tabPage1.Controls.Add(this.primaryTarget_lbl);
            this.tabPage1.Controls.Add(this.primaryReply_txt);
            this.tabPage1.Controls.Add(this.primaryTarget_txt);
            this.tabPage1.Controls.Add(this.primaryReply_lbl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(382, 134);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Primary Target";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.secondaryStatus_txt);
            this.tabPage2.Controls.Add(this.secondaryStatus_lbl);
            this.tabPage2.Controls.Add(this.secondaryTargetToggle_btn);
            this.tabPage2.Controls.Add(this.secondaryTarget_lbl);
            this.tabPage2.Controls.Add(this.secondaryReply_txt);
            this.tabPage2.Controls.Add(this.secondaryTarget_txt);
            this.tabPage2.Controls.Add(this.secondaryReply_lbl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(382, 134);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Secondary Target";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // secondaryStatus_txt
            // 
            this.secondaryStatus_txt.AutoSize = true;
            this.secondaryStatus_txt.Location = new System.Drawing.Point(65, 38);
            this.secondaryStatus_txt.Name = "secondaryStatus_txt";
            this.secondaryStatus_txt.Size = new System.Drawing.Size(47, 13);
            this.secondaryStatus_txt.TabIndex = 15;
            this.secondaryStatus_txt.Text = "Stopped";
            // 
            // secondaryStatus_lbl
            // 
            this.secondaryStatus_lbl.AutoSize = true;
            this.secondaryStatus_lbl.Location = new System.Drawing.Point(15, 38);
            this.secondaryStatus_lbl.Name = "secondaryStatus_lbl";
            this.secondaryStatus_lbl.Size = new System.Drawing.Size(40, 13);
            this.secondaryStatus_lbl.TabIndex = 14;
            this.secondaryStatus_lbl.Text = "Status:";
            // 
            // secondaryTargetToggle_btn
            // 
            this.secondaryTargetToggle_btn.Location = new System.Drawing.Point(277, 8);
            this.secondaryTargetToggle_btn.Name = "secondaryTargetToggle_btn";
            this.secondaryTargetToggle_btn.Size = new System.Drawing.Size(75, 23);
            this.secondaryTargetToggle_btn.TabIndex = 13;
            this.secondaryTargetToggle_btn.Text = "Start";
            this.secondaryTargetToggle_btn.UseVisualStyleBackColor = true;
            this.secondaryTargetToggle_btn.Click += new System.EventHandler(this.secondaryTargetToggle_btn_Click);
            // 
            // secondaryTarget_lbl
            // 
            this.secondaryTarget_lbl.AutoSize = true;
            this.secondaryTarget_lbl.Location = new System.Drawing.Point(15, 13);
            this.secondaryTarget_lbl.Name = "secondaryTarget_lbl";
            this.secondaryTarget_lbl.Size = new System.Drawing.Size(41, 13);
            this.secondaryTarget_lbl.TabIndex = 9;
            this.secondaryTarget_lbl.Text = "Target:";
            // 
            // secondaryReply_txt
            // 
            this.secondaryReply_txt.AutoSize = true;
            this.secondaryReply_txt.Location = new System.Drawing.Point(65, 63);
            this.secondaryReply_txt.Name = "secondaryReply_txt";
            this.secondaryReply_txt.Size = new System.Drawing.Size(0, 13);
            this.secondaryReply_txt.TabIndex = 12;
            // 
            // secondaryTarget_txt
            // 
            this.secondaryTarget_txt.Location = new System.Drawing.Point(65, 10);
            this.secondaryTarget_txt.Name = "secondaryTarget_txt";
            this.secondaryTarget_txt.Size = new System.Drawing.Size(203, 20);
            this.secondaryTarget_txt.TabIndex = 10;
            // 
            // secondaryReply_lbl
            // 
            this.secondaryReply_lbl.AutoSize = true;
            this.secondaryReply_lbl.Location = new System.Drawing.Point(15, 63);
            this.secondaryReply_lbl.Name = "secondaryReply_lbl";
            this.secondaryReply_lbl.Size = new System.Drawing.Size(37, 13);
            this.secondaryReply_lbl.TabIndex = 11;
            this.secondaryReply_lbl.Text = "Reply:\r\n";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pingInterval_nupdn);
            this.tabPage3.Controls.Add(this.ping_interval_lbl);
            this.tabPage3.Controls.Add(this.highThreshold_nupdn);
            this.tabPage3.Controls.Add(this.lowThreshold_nupdn);
            this.tabPage3.Controls.Add(this.reachability_lbl);
            this.tabPage3.Controls.Add(this.reachability_bestOfTwo_rbtn);
            this.tabPage3.Controls.Add(this.reachability_worstOfTwo_rbtn);
            this.tabPage3.Controls.Add(this.highThreshold_lbl);
            this.tabPage3.Controls.Add(this.lowThreshold_lbl);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(382, 134);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pingInterval_nupdn
            // 
            this.pingInterval_nupdn.Location = new System.Drawing.Point(93, 44);
            this.pingInterval_nupdn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pingInterval_nupdn.Name = "pingInterval_nupdn";
            this.pingInterval_nupdn.Size = new System.Drawing.Size(120, 20);
            this.pingInterval_nupdn.TabIndex = 10;
            this.Tooltip.SetToolTip(this.pingInterval_nupdn, "How often should the ping be sent. This value is entered in seconds.\r\nLowest valu" +
        "e is every second, highest is every 100 seconds. The same\r\ntimer is sending the " +
        "ping for both targets.");
            this.pingInterval_nupdn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pingInterval_nupdn.ValueChanged += new System.EventHandler(this.pingInterval_nupdn_ValueChanged);
            // 
            // ping_interval_lbl
            // 
            this.ping_interval_lbl.AutoSize = true;
            this.ping_interval_lbl.Location = new System.Drawing.Point(7, 46);
            this.ping_interval_lbl.Name = "ping_interval_lbl";
            this.ping_interval_lbl.Size = new System.Drawing.Size(69, 13);
            this.ping_interval_lbl.TabIndex = 9;
            this.ping_interval_lbl.Text = "Ping Interval:";
            this.Tooltip.SetToolTip(this.ping_interval_lbl, "How often should the ping be sent. This value is entered in seconds.\r\nLowest valu" +
        "e is every second, highest is every 100 seconds. The same\r\ntimer is sending the " +
        "ping for both targets.\r\n\r\n");
            // 
            // highThreshold_nupdn
            // 
            this.highThreshold_nupdn.Location = new System.Drawing.Point(93, 103);
            this.highThreshold_nupdn.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.highThreshold_nupdn.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.highThreshold_nupdn.Name = "highThreshold_nupdn";
            this.highThreshold_nupdn.Size = new System.Drawing.Size(120, 20);
            this.highThreshold_nupdn.TabIndex = 8;
            this.Tooltip.SetToolTip(this.highThreshold_nupdn, "High threshold, everything below this threshold is poor response, \r\neverything ab" +
        "ove it is bad response. \r\nMeasured in ms. Lowest value is \"low threshold\" +1, hi" +
        "ghest value is 1000ms.\r\n\r\n");
            this.highThreshold_nupdn.Value = new decimal(new int[] {
            101,
            0,
            0,
            0});
            this.highThreshold_nupdn.ValueChanged += new System.EventHandler(this.highThreshold_nupdn_ValueChanged);
            // 
            // lowThreshold_nupdn
            // 
            this.lowThreshold_nupdn.Location = new System.Drawing.Point(93, 77);
            this.lowThreshold_nupdn.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.lowThreshold_nupdn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lowThreshold_nupdn.Name = "lowThreshold_nupdn";
            this.lowThreshold_nupdn.Size = new System.Drawing.Size(120, 20);
            this.lowThreshold_nupdn.TabIndex = 7;
            this.Tooltip.SetToolTip(this.lowThreshold_nupdn, "Low threshold, everything below this threshold is good response, \r\neverything abo" +
        "ve it is poor response. \r\nMeasured in ms. Lowest value is 1ms, highest value is " +
        "\"high threshold\" -1.\r\n");
            this.lowThreshold_nupdn.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.lowThreshold_nupdn.ValueChanged += new System.EventHandler(this.lowThreshold_nupdn_ValueChanged);
            // 
            // reachability_lbl
            // 
            this.reachability_lbl.AutoSize = true;
            this.reachability_lbl.Location = new System.Drawing.Point(7, 23);
            this.reachability_lbl.Name = "reachability_lbl";
            this.reachability_lbl.Size = new System.Drawing.Size(68, 13);
            this.reachability_lbl.TabIndex = 6;
            this.reachability_lbl.Text = "Reachability:";
            this.Tooltip.SetToolTip(this.reachability_lbl, "Only applicable when two targets are used, how the notification \r\nwill be present" +
        "ed.\r\n");
            // 
            // reachability_bestOfTwo_rbtn
            // 
            this.reachability_bestOfTwo_rbtn.AutoSize = true;
            this.reachability_bestOfTwo_rbtn.Checked = true;
            this.reachability_bestOfTwo_rbtn.Location = new System.Drawing.Point(188, 21);
            this.reachability_bestOfTwo_rbtn.Name = "reachability_bestOfTwo_rbtn";
            this.reachability_bestOfTwo_rbtn.Size = new System.Drawing.Size(82, 17);
            this.reachability_bestOfTwo_rbtn.TabIndex = 5;
            this.reachability_bestOfTwo_rbtn.TabStop = true;
            this.reachability_bestOfTwo_rbtn.Text = "Best of Two";
            this.Tooltip.SetToolTip(this.reachability_bestOfTwo_rbtn, "Ping status will be the best of both. \r\nFor example: When primary has bad respons" +
        "e time and secondary \r\nhas good response time then the overall status will be go" +
        "od.\r\n");
            this.reachability_bestOfTwo_rbtn.UseVisualStyleBackColor = true;
            this.reachability_bestOfTwo_rbtn.CheckedChanged += new System.EventHandler(this.reachability_bestOfTwo_rbtn_CheckedChanged);
            // 
            // reachability_worstOfTwo_rbtn
            // 
            this.reachability_worstOfTwo_rbtn.AutoSize = true;
            this.reachability_worstOfTwo_rbtn.Location = new System.Drawing.Point(93, 21);
            this.reachability_worstOfTwo_rbtn.Name = "reachability_worstOfTwo_rbtn";
            this.reachability_worstOfTwo_rbtn.Size = new System.Drawing.Size(89, 17);
            this.reachability_worstOfTwo_rbtn.TabIndex = 4;
            this.reachability_worstOfTwo_rbtn.Text = "Worst of Two";
            this.Tooltip.SetToolTip(this.reachability_worstOfTwo_rbtn, "Ping status will be the worst of both. \r\nFor example: When primary has bad respon" +
        "se time and secondary \r\nhas good response time then the overall status will be b" +
        "ad.\r\n");
            this.reachability_worstOfTwo_rbtn.UseVisualStyleBackColor = true;
            this.reachability_worstOfTwo_rbtn.CheckedChanged += new System.EventHandler(this.reachability_worstOfTwo_rbtn_CheckedChanged);
            // 
            // highThreshold_lbl
            // 
            this.highThreshold_lbl.AutoSize = true;
            this.highThreshold_lbl.Location = new System.Drawing.Point(7, 105);
            this.highThreshold_lbl.Name = "highThreshold_lbl";
            this.highThreshold_lbl.Size = new System.Drawing.Size(82, 13);
            this.highThreshold_lbl.TabIndex = 1;
            this.highThreshold_lbl.Text = "High Threshold:";
            this.Tooltip.SetToolTip(this.highThreshold_lbl, "High threshold, everything below this threshold is poor response, \r\neverything ab" +
        "ove it is bad response. \r\nMeasured in ms. Lowest value is \"low threshold\" +1, hi" +
        "ghest value is 1000ms.");
            // 
            // lowThreshold_lbl
            // 
            this.lowThreshold_lbl.AutoSize = true;
            this.lowThreshold_lbl.Location = new System.Drawing.Point(7, 79);
            this.lowThreshold_lbl.Name = "lowThreshold_lbl";
            this.lowThreshold_lbl.Size = new System.Drawing.Size(80, 13);
            this.lowThreshold_lbl.TabIndex = 0;
            this.lowThreshold_lbl.Text = "Low Threshold:";
            this.Tooltip.SetToolTip(this.lowThreshold_lbl, "Low threshold, everything below this threshold is good response, \r\neverything abo" +
        "ve it is poor response. \r\nMeasured in ms. Lowest value is 1ms, highest value is " +
        "\"high threshold\" -1.");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 180);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Ping Monitor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pingInterval_nupdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highThreshold_nupdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowThreshold_nupdn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox primaryTarget_txt;
        private System.Windows.Forms.Label primaryTarget_lbl;
        private System.Windows.Forms.Label primaryReply_txt;
        private System.Windows.Forms.Label primaryReply_lbl;
        private System.Windows.Forms.Button primaryTargetToggle_btn;
        private System.Windows.Forms.Label primaryStatus_txt;
        private System.Windows.Forms.Label primaryStatus_lbl;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label secondaryStatus_txt;
        private System.Windows.Forms.Label secondaryStatus_lbl;
        private System.Windows.Forms.Button secondaryTargetToggle_btn;
        private System.Windows.Forms.Label secondaryTarget_lbl;
        private System.Windows.Forms.Label secondaryReply_txt;
        private System.Windows.Forms.TextBox secondaryTarget_txt;
        private System.Windows.Forms.Label secondaryReply_lbl;
        private System.Windows.Forms.Label highThreshold_lbl;
        private System.Windows.Forms.Label lowThreshold_lbl;
        private System.Windows.Forms.Label reachability_lbl;
        private System.Windows.Forms.RadioButton reachability_bestOfTwo_rbtn;
        private System.Windows.Forms.RadioButton reachability_worstOfTwo_rbtn;
        private System.Windows.Forms.ToolTip Tooltip;
        private System.Windows.Forms.NumericUpDown highThreshold_nupdn;
        private System.Windows.Forms.NumericUpDown lowThreshold_nupdn;
        private System.Windows.Forms.NumericUpDown pingInterval_nupdn;
        private System.Windows.Forms.Label ping_interval_lbl;
    }
}

