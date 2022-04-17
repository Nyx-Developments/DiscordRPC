using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko;

namespace CustomDiscordRPC
{
    public partial class WebBrowser : Form
    {
        public WebBrowser()
        {
            InitializeComponent();
            Xpcom.Initialize("Firefox");
            geckoWebBrowser.Navigate("https://discordapp.com/developers/applications");
        }

        private void WebBrowser_FormClosing(object sender, FormClosingEventArgs e)
        {
            geckoWebBrowser.Dispose();
        }
    }
}
