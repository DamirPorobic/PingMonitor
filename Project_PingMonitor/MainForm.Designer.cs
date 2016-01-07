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
            this.primaryTarget_grpbox = new System.Windows.Forms.GroupBox();
            this.primaryStatus_txt = new System.Windows.Forms.Label();
            this.primaryStatus_lbl = new System.Windows.Forms.Label();
            this.primaryTargetToggle_btn = new System.Windows.Forms.Button();
            this.primaryReply_txt = new System.Windows.Forms.Label();
            this.primaryReply_lbl = new System.Windows.Forms.Label();
            this.primaryTarget_txt = new System.Windows.Forms.TextBox();
            this.primaryTarget_lbl = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.primaryTarget_grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // primaryTarget_grpbox
            // 
            this.primaryTarget_grpbox.Controls.Add(this.primaryStatus_txt);
            this.primaryTarget_grpbox.Controls.Add(this.primaryStatus_lbl);
            this.primaryTarget_grpbox.Controls.Add(this.primaryTargetToggle_btn);
            this.primaryTarget_grpbox.Controls.Add(this.primaryReply_txt);
            this.primaryTarget_grpbox.Controls.Add(this.primaryReply_lbl);
            this.primaryTarget_grpbox.Controls.Add(this.primaryTarget_txt);
            this.primaryTarget_grpbox.Controls.Add(this.primaryTarget_lbl);
            this.primaryTarget_grpbox.Location = new System.Drawing.Point(13, 13);
            this.primaryTarget_grpbox.Name = "primaryTarget_grpbox";
            this.primaryTarget_grpbox.Size = new System.Drawing.Size(362, 152);
            this.primaryTarget_grpbox.TabIndex = 0;
            this.primaryTarget_grpbox.TabStop = false;
            this.primaryTarget_grpbox.Text = "Primary Target ";
            // 
            // primaryStatus_txt
            // 
            this.primaryStatus_txt.AutoSize = true;
            this.primaryStatus_txt.Location = new System.Drawing.Point(65, 51);
            this.primaryStatus_txt.Name = "primaryStatus_txt";
            this.primaryStatus_txt.Size = new System.Drawing.Size(47, 13);
            this.primaryStatus_txt.TabIndex = 8;
            this.primaryStatus_txt.Text = "Stopped";
            // 
            // primaryStatus_lbl
            // 
            this.primaryStatus_lbl.AutoSize = true;
            this.primaryStatus_lbl.Location = new System.Drawing.Point(15, 51);
            this.primaryStatus_lbl.Name = "primaryStatus_lbl";
            this.primaryStatus_lbl.Size = new System.Drawing.Size(40, 13);
            this.primaryStatus_lbl.TabIndex = 7;
            this.primaryStatus_lbl.Text = "Status:";
            // 
            // primaryTargetToggle_btn
            // 
            this.primaryTargetToggle_btn.Location = new System.Drawing.Point(277, 21);
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
            this.primaryReply_txt.Location = new System.Drawing.Point(65, 76);
            this.primaryReply_txt.Name = "primaryReply_txt";
            this.primaryReply_txt.Size = new System.Drawing.Size(0, 13);
            this.primaryReply_txt.TabIndex = 5;
            // 
            // primaryReply_lbl
            // 
            this.primaryReply_lbl.AutoSize = true;
            this.primaryReply_lbl.Location = new System.Drawing.Point(15, 76);
            this.primaryReply_lbl.Name = "primaryReply_lbl";
            this.primaryReply_lbl.Size = new System.Drawing.Size(37, 13);
            this.primaryReply_lbl.TabIndex = 4;
            this.primaryReply_lbl.Text = "Reply:\r\n";
            // 
            // primaryTarget_txt
            // 
            this.primaryTarget_txt.Location = new System.Drawing.Point(65, 23);
            this.primaryTarget_txt.Name = "primaryTarget_txt";
            this.primaryTarget_txt.Size = new System.Drawing.Size(203, 20);
            this.primaryTarget_txt.TabIndex = 3;
            // 
            // primaryTarget_lbl
            // 
            this.primaryTarget_lbl.AutoSize = true;
            this.primaryTarget_lbl.Location = new System.Drawing.Point(15, 26);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 174);
            this.Controls.Add(this.primaryTarget_grpbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Ping Monitor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.primaryTarget_grpbox.ResumeLayout(false);
            this.primaryTarget_grpbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox primaryTarget_grpbox;
        private System.Windows.Forms.TextBox primaryTarget_txt;
        private System.Windows.Forms.Label primaryTarget_lbl;
        private System.Windows.Forms.Label primaryReply_txt;
        private System.Windows.Forms.Label primaryReply_lbl;
        private System.Windows.Forms.Button primaryTargetToggle_btn;
        private System.Windows.Forms.Label primaryStatus_txt;
        private System.Windows.Forms.Label primaryStatus_lbl;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

