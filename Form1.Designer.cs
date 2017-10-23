using System;

namespace SteemitCOREINFO
{
    partial class SteemitCOREMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SteemitCOREMainForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblVoting = new System.Windows.Forms.Label();
            this.lblBandwith = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pbBandwith = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.pbVoting = new System.Windows.Forms.ProgressBar();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtUser = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCheck = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblUpvote = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCurrUpvote = new System.Windows.Forms.Label();
            this.lblCurrentUpvote = new System.Windows.Forms.Label();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblVests = new System.Windows.Forms.Label();
            this.lblPosts = new System.Windows.Forms.Label();
            this.lblSteem = new System.Windows.Forms.Label();
            this.lblReputation = new System.Windows.Forms.Label();
            this.lblSBD = new System.Windows.Forms.Label();
            this.lblSPDeleg = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalSP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVoting
            // 
            this.lblVoting.AutoSize = true;
            this.lblVoting.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblVoting.Location = new System.Drawing.Point(151, 112);
            this.lblVoting.Name = "lblVoting";
            this.lblVoting.Size = new System.Drawing.Size(13, 13);
            this.lblVoting.TabIndex = 5;
            this.lblVoting.Text = "0";
            // 
            // lblBandwith
            // 
            this.lblBandwith.AutoSize = true;
            this.lblBandwith.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblBandwith.Location = new System.Drawing.Point(151, 161);
            this.lblBandwith.Name = "lblBandwith";
            this.lblBandwith.Size = new System.Drawing.Size(13, 13);
            this.lblBandwith.TabIndex = 4;
            this.lblBandwith.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(33, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Bandwith (%):";
            // 
            // pbBandwith
            // 
            this.pbBandwith.Location = new System.Drawing.Point(16, 135);
            this.pbBandwith.Name = "pbBandwith";
            this.pbBandwith.Size = new System.Drawing.Size(304, 23);
            this.pbBandwith.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(33, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Voting power (%):";
            // 
            // pbVoting
            // 
            this.pbVoting.Location = new System.Drawing.Point(16, 86);
            this.pbVoting.Name = "pbVoting";
            this.pbVoting.Size = new System.Drawing.Size(304, 23);
            this.pbVoting.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SteemitCore v1.05";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtUser,
            this.toolStripSeparator1,
            this.btnCheck,
            this.toolStripSeparator5,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripButton4,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripSeparator4,
            this.btnAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(615, 25);
            this.toolStrip1.TabIndex = 37;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.SteelBlue;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel1.Text = "user:  @";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUser.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 25);
            this.txtUser.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCheck
            // 
            this.btnCheck.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCheck.Image = global::SteemitCOREINFO.Properties.Resources.face_icon_png_42781;
            this.btnCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(68, 22);
            this.btnCheck.Text = "get info";
            this.btnCheck.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.ForeColor = System.Drawing.Color.SteelBlue;
            this.toolStripButton3.Image = global::SteemitCOREINFO.Properties.Resources.favicon;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(152, 22);
            this.toolStripButton3.Text = "get free STEEM account";
            this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.ForeColor = System.Drawing.Color.SteelBlue;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(65, 22);
            this.toolStripButton4.Text = "utopian.io";
            this.toolStripButton4.ToolTipText = "Visit utopian.io and support this Project";
            this.toolStripButton4.Click += new System.EventHandler(this.ToolStripButton4_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.ForeColor = System.Drawing.Color.SteelBlue;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton5.Text = "busy.org";
            this.toolStripButton5.ToolTipText = "Visit busy.org and support this Project";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAbout
            // 
            this.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbout.Image = global::SteemitCOREINFO.Properties.Resources.Custom_Icon_Design_Pretty_Office_2_FAQ;
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(23, 22);
            this.btnAbout.Text = "He&lp / About";
            this.btnAbout.ToolTipText = "How to use / About";
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressStatus,
            this.lblStatusBar,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 302);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(615, 23);
            this.statusStrip1.TabIndex = 38;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressStatus
            // 
            this.progressStatus.MarqueeAnimationSpeed = 30;
            this.progressStatus.Name = "progressStatus";
            this.progressStatus.Size = new System.Drawing.Size(150, 17);
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.AutoSize = false;
            this.lblStatusBar.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(350, 18);
            this.lblStatusBar.Text = "Ready";
            this.lblStatusBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.SteelBlue;
            this.toolStripStatusLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(98, 18);
            this.toolStripStatusLabel1.Text = "visit @steemitcore";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.ToolStripStatusLabel1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblVoting);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lblBandwith);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lblDays);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblSeconds);
            this.groupBox2.Controls.Add(this.pbBandwith);
            this.groupBox2.Controls.Add(this.lblMinutes);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblHours);
            this.groupBox2.Controls.Add(this.pbVoting);
            this.groupBox2.Controls.Add(this.lblUpvote);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblCurrUpvote);
            this.groupBox2.Controls.Add(this.lblCurrentUpvote);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Location = new System.Drawing.Point(260, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 263);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Voting power / bandwith";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 57;
            this.label13.Text = "seconds";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(13, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(319, 13);
            this.label12.TabIndex = 56;
            this.label12.Text = "In order to reach 100% upvote power you need to wait:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(113, 218);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 58;
            this.label14.Text = "minutes";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(191, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 59;
            this.label15.Text = "hours";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(256, 218);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 60;
            this.label16.Text = "days";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDays.Location = new System.Drawing.Point(256, 235);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(13, 13);
            this.lblDays.TabIndex = 64;
            this.lblDays.Text = "0";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSeconds.Location = new System.Drawing.Point(45, 235);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(13, 13);
            this.lblSeconds.TabIndex = 61;
            this.lblSeconds.Text = "0";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMinutes.Location = new System.Drawing.Point(113, 235);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(13, 13);
            this.lblMinutes.TabIndex = 62;
            this.lblMinutes.Text = "0";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblHours.Location = new System.Drawing.Point(191, 235);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(13, 13);
            this.lblHours.TabIndex = 63;
            this.lblHours.Text = "0";
            // 
            // lblUpvote
            // 
            this.lblUpvote.AutoSize = true;
            this.lblUpvote.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblUpvote.Location = new System.Drawing.Point(151, 57);
            this.lblUpvote.Name = "lblUpvote";
            this.lblUpvote.Size = new System.Drawing.Size(34, 13);
            this.lblUpvote.TabIndex = 55;
            this.lblUpvote.Text = "$0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(13, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Worth at 100% power:";
            // 
            // lblCurrUpvote
            // 
            this.lblCurrUpvote.AutoSize = true;
            this.lblCurrUpvote.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCurrUpvote.Location = new System.Drawing.Point(151, 29);
            this.lblCurrUpvote.Name = "lblCurrUpvote";
            this.lblCurrUpvote.Size = new System.Drawing.Size(34, 13);
            this.lblCurrUpvote.TabIndex = 53;
            this.lblCurrUpvote.Text = "$0.00";
            // 
            // lblCurrentUpvote
            // 
            this.lblCurrentUpvote.AutoSize = true;
            this.lblCurrentUpvote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCurrentUpvote.Location = new System.Drawing.Point(13, 29);
            this.lblCurrentUpvote.Name = "lblCurrentUpvote";
            this.lblCurrentUpvote.Size = new System.Drawing.Size(130, 13);
            this.lblCurrentUpvote.TabIndex = 52;
            this.lblCurrentUpvote.Text = "Current upvote worth:";
            // 
            // grpGeneral
            // 
            this.grpGeneral.BackColor = System.Drawing.Color.Transparent;
            this.grpGeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpGeneral.Controls.Add(this.label3);
            this.grpGeneral.Controls.Add(this.label1);
            this.grpGeneral.Controls.Add(this.label2);
            this.grpGeneral.Controls.Add(this.lblAge);
            this.grpGeneral.Controls.Add(this.lblVests);
            this.grpGeneral.Controls.Add(this.lblPosts);
            this.grpGeneral.Controls.Add(this.lblSteem);
            this.grpGeneral.Controls.Add(this.lblReputation);
            this.grpGeneral.Controls.Add(this.lblSBD);
            this.grpGeneral.Controls.Add(this.lblSPDeleg);
            this.grpGeneral.Controls.Add(this.label8);
            this.grpGeneral.Controls.Add(this.label5);
            this.grpGeneral.Controls.Add(this.label7);
            this.grpGeneral.Controls.Add(this.lblTotalSP);
            this.grpGeneral.Controls.Add(this.label6);
            this.grpGeneral.Controls.Add(this.label4);
            this.grpGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpGeneral.ForeColor = System.Drawing.Color.SteelBlue;
            this.grpGeneral.Location = new System.Drawing.Point(12, 28);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(245, 263);
            this.grpGeneral.TabIndex = 36;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "Account information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(41, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "SBD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "VESTS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "STEEM:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(75, 232);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(13, 13);
            this.lblAge.TabIndex = 33;
            this.lblAge.Text = "0";
            // 
            // lblVests
            // 
            this.lblVests.AutoSize = true;
            this.lblVests.Location = new System.Drawing.Point(75, 31);
            this.lblVests.Name = "lblVests";
            this.lblVests.Size = new System.Drawing.Size(13, 13);
            this.lblVests.TabIndex = 26;
            this.lblVests.Text = "0";
            // 
            // lblPosts
            // 
            this.lblPosts.AutoSize = true;
            this.lblPosts.Location = new System.Drawing.Point(75, 205);
            this.lblPosts.Name = "lblPosts";
            this.lblPosts.Size = new System.Drawing.Size(13, 13);
            this.lblPosts.TabIndex = 32;
            this.lblPosts.Text = "0";
            // 
            // lblSteem
            // 
            this.lblSteem.AutoSize = true;
            this.lblSteem.Location = new System.Drawing.Point(75, 58);
            this.lblSteem.Name = "lblSteem";
            this.lblSteem.Size = new System.Drawing.Size(13, 13);
            this.lblSteem.TabIndex = 27;
            this.lblSteem.Text = "0";
            // 
            // lblReputation
            // 
            this.lblReputation.AutoSize = true;
            this.lblReputation.Location = new System.Drawing.Point(75, 178);
            this.lblReputation.Name = "lblReputation";
            this.lblReputation.Size = new System.Drawing.Size(13, 13);
            this.lblReputation.TabIndex = 31;
            this.lblReputation.Text = "0";
            // 
            // lblSBD
            // 
            this.lblSBD.AutoSize = true;
            this.lblSBD.Location = new System.Drawing.Point(75, 86);
            this.lblSBD.Name = "lblSBD";
            this.lblSBD.Size = new System.Drawing.Size(13, 13);
            this.lblSBD.TabIndex = 28;
            this.lblSBD.Text = "0";
            // 
            // lblSPDeleg
            // 
            this.lblSPDeleg.AutoSize = true;
            this.lblSPDeleg.Location = new System.Drawing.Point(75, 119);
            this.lblSPDeleg.Name = "lblSPDeleg";
            this.lblSPDeleg.Size = new System.Drawing.Size(13, 13);
            this.lblSPDeleg.TabIndex = 30;
            this.lblSPDeleg.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(7, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Age (days):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(6, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Delegation:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(35, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Posts:";
            // 
            // lblTotalSP
            // 
            this.lblTotalSP.AutoSize = true;
            this.lblTotalSP.Location = new System.Drawing.Point(75, 145);
            this.lblTotalSP.Name = "lblTotalSP";
            this.lblTotalSP.Size = new System.Drawing.Size(13, 13);
            this.lblTotalSP.TabIndex = 29;
            this.lblTotalSP.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(5, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Reputation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(22, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "SP total:";
            // 
            // SteemitCOREMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(615, 325);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grpGeneral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SteemitCOREMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SteemitCORE INFO v1.05 by @steemitcore";
            this.Resize += new System.EventHandler(this.SteemitCOREMainForm_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar pbBandwith;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar pbVoting;
        private System.Windows.Forms.Label lblVoting;
        private System.Windows.Forms.Label lblBandwith;
        private System.Windows.Forms.Label lblVests;
        private System.Windows.Forms.Label lblSteem;
        private System.Windows.Forms.Label lblSBD;
        private System.Windows.Forms.Label lblTotalSP;
        private System.Windows.Forms.Label lblReputation;
        private System.Windows.Forms.Label lblPosts;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblUpvote;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCurrUpvote;
        private System.Windows.Forms.Label lblCurrentUpvote;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label lblSPDeleg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripProgressBar progressStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusBar;
        private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.ToolStripButton btnCheck;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

