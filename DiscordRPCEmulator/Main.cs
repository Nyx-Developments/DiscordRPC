using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;
using System.Diagnostics;

namespace CustomDiscordRPC
{
    public partial class Main : Form
    {
        public DiscordRpcClient client;
        public Main()
        {
            InitializeComponent();
        }

        private void OpenRPC_Click(object sender, EventArgs e)
        {
			InitzalizeRPC();
		}
		private void InitzalizeRPC()
		{
			if (dAppToken.Text.Length < 1)
			{
				MessageBox.Show("Discord Client ID must not be empty!", "Discord RPC Emulator");
				return;
			}
			try
			{
				client = new DiscordRpcClient(dAppToken.Text);
				client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
				client.OnReady += (sender, e) =>
				{
					Console.WriteLine("Received Ready from user {0}", e.User.Username);
				};

				client.OnPresenceUpdate += (sender, e) =>
				{
					Console.WriteLine("Received Update! {0}", e.Presence);
				};
				client.Initialize();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error occured!\n{ex.ToString()}", "Discord RPC Emulator");
				return;
			}
			if (SetRPC())
			{
				dAppToken.Enabled = false;
				OpenRPC.Enabled = false;
				DeRPC.Enabled = true;
				button1.Enabled = true;
			}
		}
		private bool SetRPC() // I know, this code sucks but i'm trying to find a way to fix this so wait please :)
		{
			/* // Old method (stupid code)
			if (RPCTitle.Text.Length < 2)
			{
				MessageBox.Show("Details at least contain 2 or more character","Discord RPC Emulator");
				return;
			}
			if (isPartyEnable.Checked)
			{
				if (PIDStr.Text.Length < 2)
				{
					MessageBox.Show("Party ID at least contain 2 or more character", "Discord RPC Emulator");
					return;
				}
				if (imageEmulate.Checked)
				{
					if (timestampEmu.Checked)
					{
						client.SetPresence(new RichPresence()
						{
							Details = RPCTitle.Text,
							State = RPCDesc1.Text,
							Assets = new Assets()
							{
								LargeImageKey = largeImgKey.Text,
								LargeImageText = largeImgTxt.Text,
								SmallImageKey = smallImageDir.Text,
								SmallImageText = smolImgTxt.Text
							},
							Party = new Party()
							{
								ID = PIDStr.Text,
								Size = int.Parse(partySizeInt.Text),
								Max = int.Parse(pMaxSize.Text)
							},
							Timestamps = Timestamps.Now
						});
					}
					else
					{
						client.SetPresence(new RichPresence()
						{
							Details = RPCTitle.Text,
							State = RPCDesc1.Text,
							Assets = new Assets()
							{
								LargeImageKey = largeImgKey.Text,
								LargeImageText = largeImgTxt.Text,
								SmallImageKey = smallImageDir.Text,
								SmallImageText = smolImgTxt.Text
							},
							Party = new Party()
							{
								ID = PIDStr.Text,
								Size = int.Parse(partySizeInt.Text),
								Max = int.Parse(pMaxSize.Text)
							}
						});
					}
				}
				else
				{
					if (timestampEmu.Checked)
					{
						client.SetPresence(new RichPresence()
						{
							Details = RPCTitle.Text,
							State = RPCDesc1.Text,
							Party = new Party()
							{
								ID = PIDStr.Text,
								Size = int.Parse(partySizeInt.Text),
								Max = int.Parse(pMaxSize.Text)
							},
							Timestamps = Timestamps.Now
						}) ;
					}
					else
					{
						client.SetPresence(new RichPresence()
						{
							Details = RPCTitle.Text,
							State = RPCDesc1.Text,
							Party = new Party()
							{
								ID = PIDStr.Text,
								Size = int.Parse(partySizeInt.Text),
								Max = int.Parse(pMaxSize.Text)
							}
						});
					}
				}
			}
			else if (imageEmulate.Checked)
			{
				if (timestampEmu.Checked)
				{
					client.SetPresence(new RichPresence()
					{
						Details = RPCTitle.Text,
						State = RPCDesc1.Text,
						Assets = new Assets()
						{
							LargeImageKey = largeImgKey.Text,
							LargeImageText = largeImgTxt.Text,
							SmallImageKey = smallImageDir.Text,
							SmallImageText = smolImgTxt.Text
						},
						Timestamps = Timestamps.Now
					});
				}
				else
				{
					client.SetPresence(new RichPresence()
					{
						Details = RPCTitle.Text,
						State = RPCDesc1.Text,
						Assets = new Assets()
						{
							LargeImageKey = largeImgKey.Text,
							LargeImageText = largeImgTxt.Text,
							SmallImageKey = smallImageDir.Text,
							SmallImageText = smolImgTxt.Text
						}
					});
				}
			}
			else
			{
				if (timestampEmu.Checked)
				{
					client.SetPresence(new RichPresence()
					{
						Details = RPCTitle.Text,
						State = RPCDesc1.Text,
						Timestamps = Timestamps.Now
					});
				}
				else
				{
					client.SetPresence(new RichPresence()
					{
						Details = RPCTitle.Text,
						State = RPCDesc1.Text
					});
				}
			}
			*/ // V1 Code
			   // V2 Code Rewrite
			string lIK = null, lIT = null, sIK = null, sIT = null, pID = null;
			int pSize = 0, pMax = 0;
			Timestamps tS = null;
			if (RPCTitle.Text.Length < 2 && RPCTitle.Text.Length != 0)
			{
				MessageBox.Show("Details must be contains 2 or more character", "Discord RPC Emulator");
				return false;
			}
			if (RPCDesc1.Text.Length < 2 && RPCDesc1.Text.Length != 0)
			{
				MessageBox.Show("Details must be contains 2 or more character", "Discord RPC Emulator");
				return false;
			}
			if (imageEmulate.Checked)
			{
				lIK = largeImgKey.Text;
				lIT = largeImgTxt.Text;
				sIK = smallImageDir.Text;
				sIT = smolImgTxt.Text;
			}
			if (isPartyEnable.Checked)
			{
				if (PIDStr.Text.Length < 2)
				{
					MessageBox.Show("Party ID at least contain 2 or more character", "Discord RPC Emulator");
					return false;
				}
				try
				{
					pID = PIDStr.Text;
					int.TryParse(partySizeInt.Text, out pSize);
					int.TryParse(pMaxSize.Text, out pMax);
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Error occured!\n{ex.ToString()}", "Discord RPC Emulator");
				}
			}
			else
			{
				try
				{
					pID = "";
					pSize = 0;
					pMax = 0;
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Error occured!\n{ex.ToString()}", "Discord RPC Emulator");
					return false;
				}
			}
			if (timestampEmu.Checked)
			{
				tS = Timestamps.Now;
			}
			client.SetPresence(new RichPresence()
			{
				Details = RPCTitle.Text,
				State = RPCDesc1.Text,
				Assets = new Assets()
				{
					LargeImageKey = lIK,
					LargeImageText = lIT,
					SmallImageKey = sIK,
					SmallImageText = sIT
				},
				Party = new Party()
				{
					ID = pID,
					Size = pSize,
					Max = pMax
				},
				Timestamps = tS
			});
			return true;
		}

		private void DeRPC_Click(object sender, EventArgs e)
		{
			try
			{
				DeinitzalizeRPC();
			}
			catch
			{
				Console.WriteLine("Not opening...");
				return;
			}
			DeRPC.Enabled = false;
			button1.Enabled = false;
			OpenRPC.Enabled = true;
			dAppToken.Enabled = true;
		}
		private void DeinitzalizeRPC()
		{
			client.Dispose();
		}

		private async void gotoRPCweb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Async so the app wont lag
		{
			FormCollection fc = Application.OpenForms;
			foreach (Form frm in fc)
			{
				//iterate through
				if (frm.Name == "WebBrowser")
				{
					return;
				}
			}
			new WebBrowser().Show();
		}

		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				DeinitzalizeRPC();
			}
			catch
			{
				Console.WriteLine("Not opening...");
			}
		}
		private void isPartyEnable_CheckedChanged(object sender, EventArgs e)
		{
			partyPanel.Enabled = isPartyEnable.Checked;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SetRPC();
		}

		private void imageEmulate_CheckedChanged(object sender, EventArgs e)
		{
			imgPanel.Enabled = imageEmulate.Checked;
		}

		private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			WindowState = FormWindowState.Normal;
			ShowInTaskbar = true;
			notifyIcon.Visible = false;
		}

		private void Main_Resize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
			{
				ShowInTaskbar = false;
				notifyIcon.Visible = true;
				notifyIcon.ShowBalloonTip(3000);
			}
		}
	}
}
