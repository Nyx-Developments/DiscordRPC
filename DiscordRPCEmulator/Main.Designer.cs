namespace CustomDiscordRPC
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.OpenRPC = new System.Windows.Forms.Button();
            this.DeRPC = new System.Windows.Forms.Button();
            this.imageOpen = new System.Windows.Forms.OpenFileDialog();
            this.dAppToken = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gotoRPCweb = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.isPartyEnable = new System.Windows.Forms.CheckBox();
            this.partyPanel = new System.Windows.Forms.Panel();
            this.PIDStr = new System.Windows.Forms.TextBox();
            this.pid = new System.Windows.Forms.Label();
            this.pMaxSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.partySizeInt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RPCDesc1 = new System.Windows.Forms.TextBox();
            this.desc1Label = new System.Windows.Forms.Label();
            this.RPCTitle = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.imageEmulate = new System.Windows.Forms.CheckBox();
            this.imgPanel = new System.Windows.Forms.Panel();
            this.smolImgTxt = new System.Windows.Forms.TextBox();
            this.smTxtLb = new System.Windows.Forms.Label();
            this.largeImgTxt = new System.Windows.Forms.TextBox();
            this.laImgLabel = new System.Windows.Forms.Label();
            this.smallImageDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.largeImgKey = new System.Windows.Forms.TextBox();
            this.imgTxt = new System.Windows.Forms.Label();
            this.timestampEmu = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.partyPanel.SuspendLayout();
            this.imgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenRPC
            // 
            this.OpenRPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenRPC.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.OpenRPC.ForeColor = System.Drawing.Color.White;
            this.OpenRPC.Location = new System.Drawing.Point(374, 204);
            this.OpenRPC.Name = "OpenRPC";
            this.OpenRPC.Size = new System.Drawing.Size(180, 38);
            this.OpenRPC.TabIndex = 10;
            this.OpenRPC.Text = "Emulate RPC";
            this.OpenRPC.UseVisualStyleBackColor = true;
            this.OpenRPC.Click += new System.EventHandler(this.OpenRPC_Click);
            // 
            // DeRPC
            // 
            this.DeRPC.Enabled = false;
            this.DeRPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeRPC.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.DeRPC.ForeColor = System.Drawing.Color.White;
            this.DeRPC.Location = new System.Drawing.Point(560, 204);
            this.DeRPC.Name = "DeRPC";
            this.DeRPC.Size = new System.Drawing.Size(180, 38);
            this.DeRPC.TabIndex = 11;
            this.DeRPC.Text = "De-emulate RPC";
            this.DeRPC.UseVisualStyleBackColor = true;
            this.DeRPC.Click += new System.EventHandler(this.DeRPC_Click);
            // 
            // imageOpen
            // 
            this.imageOpen.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            this.imageOpen.ReadOnlyChecked = true;
            this.imageOpen.Tag = "";
            // 
            // dAppToken
            // 
            this.dAppToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dAppToken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dAppToken.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.dAppToken.ForeColor = System.Drawing.Color.White;
            this.dAppToken.Location = new System.Drawing.Point(138, 12);
            this.dAppToken.Name = "dAppToken";
            this.dAppToken.Size = new System.Drawing.Size(226, 29);
            this.dAppToken.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Discord Client ID";
            // 
            // gotoRPCweb
            // 
            this.gotoRPCweb.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.gotoRPCweb.AutoSize = true;
            this.gotoRPCweb.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.gotoRPCweb.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.gotoRPCweb.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.gotoRPCweb.Location = new System.Drawing.Point(370, 180);
            this.gotoRPCweb.Name = "gotoRPCweb";
            this.gotoRPCweb.Size = new System.Drawing.Size(224, 21);
            this.gotoRPCweb.TabIndex = 33;
            this.gotoRPCweb.TabStop = true;
            this.gotoRPCweb.Text = "Manage your Discord RPC here!";
            this.gotoRPCweb.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(255)))));
            this.gotoRPCweb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gotoRPCweb_LinkClicked);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(374, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 38);
            this.button1.TabIndex = 34;
            this.button1.Text = "Change RPC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // isPartyEnable
            // 
            this.isPartyEnable.AutoSize = true;
            this.isPartyEnable.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.isPartyEnable.ForeColor = System.Drawing.Color.White;
            this.isPartyEnable.Location = new System.Drawing.Point(374, 11);
            this.isPartyEnable.Name = "isPartyEnable";
            this.isPartyEnable.Size = new System.Drawing.Size(170, 25);
            this.isPartyEnable.TabIndex = 51;
            this.isPartyEnable.Text = "Enable Party Emulate";
            this.isPartyEnable.UseVisualStyleBackColor = true;
            this.isPartyEnable.CheckedChanged += new System.EventHandler(this.isPartyEnable_CheckedChanged);
            // 
            // partyPanel
            // 
            this.partyPanel.Controls.Add(this.PIDStr);
            this.partyPanel.Controls.Add(this.pid);
            this.partyPanel.Controls.Add(this.pMaxSize);
            this.partyPanel.Controls.Add(this.label3);
            this.partyPanel.Controls.Add(this.partySizeInt);
            this.partyPanel.Controls.Add(this.label2);
            this.partyPanel.Enabled = false;
            this.partyPanel.Location = new System.Drawing.Point(374, 42);
            this.partyPanel.Name = "partyPanel";
            this.partyPanel.Size = new System.Drawing.Size(374, 110);
            this.partyPanel.TabIndex = 56;
            // 
            // PIDStr
            // 
            this.PIDStr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PIDStr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PIDStr.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.PIDStr.ForeColor = System.Drawing.Color.White;
            this.PIDStr.Location = new System.Drawing.Point(91, 3);
            this.PIDStr.Name = "PIDStr";
            this.PIDStr.Size = new System.Drawing.Size(272, 29);
            this.PIDStr.TabIndex = 47;
            // 
            // pid
            // 
            this.pid.AutoSize = true;
            this.pid.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.pid.ForeColor = System.Drawing.Color.White;
            this.pid.Location = new System.Drawing.Point(11, 6);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(63, 21);
            this.pid.TabIndex = 46;
            this.pid.Text = "Party ID";
            // 
            // pMaxSize
            // 
            this.pMaxSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pMaxSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pMaxSize.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.pMaxSize.ForeColor = System.Drawing.Color.White;
            this.pMaxSize.Location = new System.Drawing.Point(122, 73);
            this.pMaxSize.Name = "pMaxSize";
            this.pMaxSize.Size = new System.Drawing.Size(241, 29);
            this.pMaxSize.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 44;
            this.label3.Text = "Party Max Size";
            // 
            // partySizeInt
            // 
            this.partySizeInt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.partySizeInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partySizeInt.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.partySizeInt.ForeColor = System.Drawing.Color.White;
            this.partySizeInt.Location = new System.Drawing.Point(91, 38);
            this.partySizeInt.Name = "partySizeInt";
            this.partySizeInt.Size = new System.Drawing.Size(272, 29);
            this.partySizeInt.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 42;
            this.label2.Text = "Party Size";
            // 
            // RPCDesc1
            // 
            this.RPCDesc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RPCDesc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RPCDesc1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.RPCDesc1.ForeColor = System.Drawing.Color.White;
            this.RPCDesc1.Location = new System.Drawing.Point(72, 81);
            this.RPCDesc1.Name = "RPCDesc1";
            this.RPCDesc1.Size = new System.Drawing.Size(292, 29);
            this.RPCDesc1.TabIndex = 46;
            // 
            // desc1Label
            // 
            this.desc1Label.AutoSize = true;
            this.desc1Label.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.desc1Label.ForeColor = System.Drawing.Color.White;
            this.desc1Label.Location = new System.Drawing.Point(12, 84);
            this.desc1Label.Name = "desc1Label";
            this.desc1Label.Size = new System.Drawing.Size(44, 21);
            this.desc1Label.TabIndex = 45;
            this.desc1Label.Text = "State";
            // 
            // RPCTitle
            // 
            this.RPCTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RPCTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RPCTitle.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.RPCTitle.ForeColor = System.Drawing.Color.White;
            this.RPCTitle.Location = new System.Drawing.Point(72, 46);
            this.RPCTitle.Name = "RPCTitle";
            this.RPCTitle.Size = new System.Drawing.Size(292, 29);
            this.RPCTitle.TabIndex = 44;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(12, 49);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(54, 21);
            this.titleLabel.TabIndex = 43;
            this.titleLabel.Text = "Details";
            // 
            // imageEmulate
            // 
            this.imageEmulate.AutoSize = true;
            this.imageEmulate.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.imageEmulate.ForeColor = System.Drawing.Color.White;
            this.imageEmulate.Location = new System.Drawing.Point(14, 117);
            this.imageEmulate.Name = "imageEmulate";
            this.imageEmulate.Size = new System.Drawing.Size(178, 25);
            this.imageEmulate.TabIndex = 57;
            this.imageEmulate.Text = "Enable Image Emulate";
            this.imageEmulate.UseVisualStyleBackColor = true;
            this.imageEmulate.CheckedChanged += new System.EventHandler(this.imageEmulate_CheckedChanged);
            // 
            // imgPanel
            // 
            this.imgPanel.Controls.Add(this.smolImgTxt);
            this.imgPanel.Controls.Add(this.smTxtLb);
            this.imgPanel.Controls.Add(this.largeImgTxt);
            this.imgPanel.Controls.Add(this.laImgLabel);
            this.imgPanel.Controls.Add(this.smallImageDir);
            this.imgPanel.Controls.Add(this.label1);
            this.imgPanel.Controls.Add(this.largeImgKey);
            this.imgPanel.Controls.Add(this.imgTxt);
            this.imgPanel.Enabled = false;
            this.imgPanel.Location = new System.Drawing.Point(-2, 144);
            this.imgPanel.Name = "imgPanel";
            this.imgPanel.Size = new System.Drawing.Size(370, 145);
            this.imgPanel.TabIndex = 58;
            // 
            // smolImgTxt
            // 
            this.smolImgTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.smolImgTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smolImgTxt.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.smolImgTxt.ForeColor = System.Drawing.Color.White;
            this.smolImgTxt.Location = new System.Drawing.Point(140, 109);
            this.smolImgTxt.Name = "smolImgTxt";
            this.smolImgTxt.Size = new System.Drawing.Size(226, 29);
            this.smolImgTxt.TabIndex = 63;
            // 
            // smTxtLb
            // 
            this.smTxtLb.AutoSize = true;
            this.smTxtLb.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.smTxtLb.ForeColor = System.Drawing.Color.White;
            this.smTxtLb.Location = new System.Drawing.Point(14, 112);
            this.smTxtLb.Name = "smTxtLb";
            this.smTxtLb.Size = new System.Drawing.Size(120, 21);
            this.smTxtLb.TabIndex = 62;
            this.smTxtLb.Text = "Small Image Text";
            // 
            // largeImgTxt
            // 
            this.largeImgTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.largeImgTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.largeImgTxt.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.largeImgTxt.ForeColor = System.Drawing.Color.White;
            this.largeImgTxt.Location = new System.Drawing.Point(140, 74);
            this.largeImgTxt.Name = "largeImgTxt";
            this.largeImgTxt.Size = new System.Drawing.Size(226, 29);
            this.largeImgTxt.TabIndex = 61;
            // 
            // laImgLabel
            // 
            this.laImgLabel.AutoSize = true;
            this.laImgLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.laImgLabel.ForeColor = System.Drawing.Color.White;
            this.laImgLabel.Location = new System.Drawing.Point(14, 77);
            this.laImgLabel.Name = "laImgLabel";
            this.laImgLabel.Size = new System.Drawing.Size(122, 21);
            this.laImgLabel.TabIndex = 60;
            this.laImgLabel.Text = "Large Image Text";
            // 
            // smallImageDir
            // 
            this.smallImageDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.smallImageDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smallImageDir.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.smallImageDir.ForeColor = System.Drawing.Color.White;
            this.smallImageDir.Location = new System.Drawing.Point(140, 39);
            this.smallImageDir.Name = "smallImageDir";
            this.smallImageDir.Size = new System.Drawing.Size(226, 29);
            this.smallImageDir.TabIndex = 59;
            this.smallImageDir.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 58;
            this.label1.Text = "Small Image Key";
            // 
            // largeImgKey
            // 
            this.largeImgKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.largeImgKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.largeImgKey.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.largeImgKey.ForeColor = System.Drawing.Color.White;
            this.largeImgKey.Location = new System.Drawing.Point(140, 4);
            this.largeImgKey.Name = "largeImgKey";
            this.largeImgKey.Size = new System.Drawing.Size(226, 29);
            this.largeImgKey.TabIndex = 57;
            this.largeImgKey.Text = "None";
            // 
            // imgTxt
            // 
            this.imgTxt.AutoSize = true;
            this.imgTxt.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.imgTxt.ForeColor = System.Drawing.Color.White;
            this.imgTxt.Location = new System.Drawing.Point(14, 6);
            this.imgTxt.Name = "imgTxt";
            this.imgTxt.Size = new System.Drawing.Size(120, 21);
            this.imgTxt.TabIndex = 56;
            this.imgTxt.Text = "Large Image Key";
            // 
            // timestampEmu
            // 
            this.timestampEmu.AutoSize = true;
            this.timestampEmu.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.timestampEmu.ForeColor = System.Drawing.Color.White;
            this.timestampEmu.Location = new System.Drawing.Point(374, 158);
            this.timestampEmu.Name = "timestampEmu";
            this.timestampEmu.Size = new System.Drawing.Size(209, 25);
            this.timestampEmu.TabIndex = 59;
            this.timestampEmu.Text = "Enable Timestamp Emulate";
            this.timestampEmu.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(560, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 38);
            this.button2.TabIndex = 60;
            this.button2.Text = "Tools";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Discord RPC Emulator is now minimized to tray.\r\nTo open double click this icon an" +
    "d DIscord RPC Emulator will open.";
            this.notifyIcon.BalloonTipTitle = "Discord RPC Emulator";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Discord RPC Emulator is running.";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(748, 291);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.timestampEmu);
            this.Controls.Add(this.imgPanel);
            this.Controls.Add(this.imageEmulate);
            this.Controls.Add(this.isPartyEnable);
            this.Controls.Add(this.partyPanel);
            this.Controls.Add(this.RPCDesc1);
            this.Controls.Add(this.desc1Label);
            this.Controls.Add(this.RPCTitle);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dAppToken);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DeRPC);
            this.Controls.Add(this.OpenRPC);
            this.Controls.Add(this.gotoRPCweb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Discord RPC Emulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.partyPanel.ResumeLayout(false);
            this.partyPanel.PerformLayout();
            this.imgPanel.ResumeLayout(false);
            this.imgPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OpenRPC;
        private System.Windows.Forms.Button DeRPC;
        private System.Windows.Forms.OpenFileDialog imageOpen;
        private System.Windows.Forms.TextBox dAppToken;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel gotoRPCweb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox isPartyEnable;
        private System.Windows.Forms.Panel partyPanel;
        private System.Windows.Forms.TextBox PIDStr;
        private System.Windows.Forms.Label pid;
        private System.Windows.Forms.TextBox pMaxSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox partySizeInt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RPCDesc1;
        private System.Windows.Forms.Label desc1Label;
        private System.Windows.Forms.TextBox RPCTitle;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.CheckBox imageEmulate;
        private System.Windows.Forms.Panel imgPanel;
        private System.Windows.Forms.TextBox smolImgTxt;
        private System.Windows.Forms.Label smTxtLb;
        private System.Windows.Forms.TextBox largeImgTxt;
        private System.Windows.Forms.Label laImgLabel;
        private System.Windows.Forms.TextBox smallImageDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox largeImgKey;
        private System.Windows.Forms.Label imgTxt;
        private System.Windows.Forms.CheckBox timestampEmu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

