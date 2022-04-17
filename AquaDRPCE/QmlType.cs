//QmlType.cs
using Qml.Net;
using System.Threading.Tasks;
using System;
using DiscordRPC;
using DiscordRPC.Logging;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AquaDRPCE
{
    [Signal("customSignal", NetVariantType.String)] // You can define signals that Qml can listen to.
    public class QmlType
    {
        /// <summary>
        /// Properties are exposed to Qml.
        /// </summary>
        [NotifySignal("stringPropertyChanged")] // For Qml binding/MVVM.
        public string StringProperty { get; set; }

        /// <summary>
        /// Methods can return .NET types.
        /// The returned type can be invoked from Qml (properties/methods/events/etc).
        /// </summary>
        /// <returns></returns>
        public QmlType CreateNetObject()
        {
            return new QmlType();
        }

        /// <summary>
        /// Qml can pass .NET types to .NET methods.
        /// </summary>
        /// <param name="parameter"></param>
        public DiscordRpcClient client;
        private bool isInited = false;
        public bool setRPC(object dT, object sT, object imgE, object LIKK, object SIKK, object lITT, object sITT, object pEmu, object pids, object pS, object pMaxS, object isTSEmu) // I know, this code sucks but i'm trying to find a way to fix this so wait please :)
        {
            // V2 Code Rewrite
            if (isInited)
            {
                string tDT = null, tST = null, lIK = null, lIT = null, sIK = null, sIT = null, pID = null;
                int pSize = 0, pMax = 0;
                Timestamps tS = null;
                tDT = dT.ToString();
                tST = sT.ToString();
                if (tDT.Length < 2 && tDT.Length != 0)
                {
                    Console.WriteLine("Details must be contains 2 or more character");
                    return false;
                }
                if (tST.Length < 2 && tST.Length != 0)
                {
                    Console.WriteLine("State must be contains 2 or more character");
                    return false;
                }
                if (Convert.ToBoolean(imgE))
                {
                    lIK = LIKK.ToString();
                    sIK = SIKK.ToString();
                    lIT = lITT.ToString();
                    sIT = sITT.ToString();
                }
                if (Convert.ToBoolean(pEmu))
                {
                    pID = pids.ToString();
                    if (pID.Length < 2)
                    {
                        Console.WriteLine("Party ID at least contain 2 or more character");
                        return false;
                    }
                    try
                    {

                        int.TryParse(pS.ToString(), out pSize);
                        int.TryParse(pMaxS.ToString(), out pMax);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error occured!\n{ex.ToString()}");
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
                        Console.WriteLine($"Error occured!\n{ex.ToString()}");
                        return false;
                    }
                }
                if (Convert.ToBoolean(isTSEmu))
                {
                    tS = Timestamps.Now;
                }
                client.SetPresence(new RichPresence()
                {
                    Details = tDT,
                    State = tST,
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
            else
            {
                return false;
            }
        }
        public void init(object token, object details, object state, object isImgEn, object lImgKey, object sImgKey, object lImgTxt, object sImgTxt, object pEmu, object pids, object pS, object pMaxS, object isTSEmu)
        {
            if (!isInited)
            {
                string tempToken = token.ToString();
                if (tempToken.Length < 1)
                {
                    Console.WriteLine("Discord Client ID must not be empty!");
                    return;
                }
                try
                {
                    client = new DiscordRpcClient(tempToken);
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
                    Console.WriteLine($"Error occured!\n{ex.ToString()}");
                    return;
                }
                isInited = true;
                if (setRPC(details, state, isImgEn, lImgKey, sImgKey, lImgTxt, sImgTxt, pEmu, pids, pS, pMaxS, isTSEmu))
                {
                    Console.WriteLine("OK");
                }
            }
        }
        public void manageRPC()
        {
            openUrl("https://discordapp.com/developers/applications");
            //Process.Start("https://discordapp.com/developers/applications");
        }
        private void openUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }
        public void deinit()
        {
            if (isInited)
            {
                try
                {
                    client.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed to dispose (this is not important error!)\n" + ex);
                    return;
                }
                isInited = false;
            }
        }

		/// <summary>
		/// Async methods can be invoked with continuations happening on Qt's main thread.
		/// </summary>
		public async Task<string> TestAsync()
        {
            // On the UI thread
            await Task.Run(() =>
            {
                // On the background thread
            });
            // On the UI thread
            return "async result!";
        }

        /// <summary>
        /// Qml can also pass Qml/C++ objects that can be invoked from .NET
        /// </summary>
        /// <param name="qObject"></param>
        public void TestMethodWithQObject(dynamic o)
        {
            string result = o.propertyDefinedInCpp;
            o.methodDefinedInCpp(result);

            // You can also listen to signals on QObjects.
            var qObject = o as INetQObject;
            var handler = qObject.AttachSignal("signalName", parameters => {
                // parameters is a list of arguements passed to the signal.
            });
            handler.Dispose(); // When you are done listening to signal.

            // You can also listen to when a property changes (notify signal).
            handler = qObject.AttachNotifySignal("property", parameters => {
                // parameters is a list of arguements passed to the signal.
            });
            handler.Dispose(); // When you are done listening to signal.
        }

        /// <summary>
        /// .NET can activate signals to send notifications to Qml.
        /// </summary>
        public void ActivateCustomSignal(string message)
        {
            this.ActivateSignal("customSignal", message);
        }
    }
}