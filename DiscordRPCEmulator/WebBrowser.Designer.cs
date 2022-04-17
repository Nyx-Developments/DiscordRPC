namespace CustomDiscordRPC
{
    partial class WebBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebBrowser));
            this.geckoWebBrowser = new Gecko.GeckoWebBrowser();
            this.SuspendLayout();
            // 
            // geckoWebBrowser
            // 
            this.geckoWebBrowser.ConsoleMessageEventReceivesConsoleLogCalls = true;
            this.geckoWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.geckoWebBrowser.FrameEventsPropagateToMainWindow = false;
            this.geckoWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.geckoWebBrowser.Name = "geckoWebBrowser";
            this.geckoWebBrowser.NoDefaultContextMenu = true;
            this.geckoWebBrowser.Size = new System.Drawing.Size(800, 450);
            this.geckoWebBrowser.TabIndex = 0;
            this.geckoWebBrowser.UseHttpActivityObserver = false;
            // 
            // WebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.geckoWebBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WebBrowser";
            this.Text = "Manage Discord Application (RPC)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WebBrowser_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Gecko.GeckoWebBrowser geckoWebBrowser;
    }
}