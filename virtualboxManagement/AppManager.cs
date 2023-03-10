using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using Microsoft.WindowsAPICodePack.Net;
using System.Net;
using System.Linq;
using HtmlAgilityPack;

namespace virtualboxManagement
{
    internal class AppManager
    {
        public string hostName = Dns.GetHostName();
        public string userName = Environment.UserName;
        public string macAddress = "";
        public string gateway = "";
        public string ipHost = "";
        public string version = "";

        public void GetLocalAddress(NetworkInterfaceType _type)
        {
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.Name.Equals("Wi-Fi") || item.Name.Equals("Ethernet"))
                {
                    if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                    {
                        macAddress = item.GetPhysicalAddress().ToString();
                        foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                        {
                            if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                            {
                                ipHost = ip.Address.ToString();
                            }
                        }
                        var properties = item.GetIPProperties();
                        foreach (var gatewayAddress in properties.GatewayAddresses)
                        {
                            if (gatewayAddress.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            {
                                gateway = gatewayAddress.Address.ToString();
                            }
                        }
                    }
                }
            }
        }

        public void getSSID(Label label, Label label1)
        {
            var redes = NetworkListManager.GetNetworks(NetworkConnectivityLevels.Connected);
            foreach (var red in redes)
            {
                if (red.IsConnected)
                {
                    label.Text = "Connected";
                    label.ForeColor = Color.Green;

                }
                else if (!red.IsConnected)
                {
                    label.Text = "Disconnected";
                    label.ForeColor = Color.Red;
                }
                label1.Text = red.Name;
            }
        }

        public int GetConnection()
        {
            Ping ping = new Ping();
            PingReply res = ping.Send("1.1.1.1", 1000);
            int conter = 0;
            for (int i = 0; i < 4; i++)
            {
                if (res.Status == IPStatus.Success) { conter++; }
            }
            return conter == 4 ? 0 : conter > 0 ? 1 : 2;
        }

        public bool IsVirtualBoxInstalled(string url)
        {
            if (File.Exists(url))
            {
                var versionInfo = FileVersionInfo.GetVersionInfo(url);

                if (string.IsNullOrEmpty(versionInfo.CompanyName) || string.IsNullOrEmpty(versionInfo.ProductName) || string.IsNullOrEmpty(versionInfo.FileVersion))
                {
                    return false;
                }
                version = versionInfo.FileVersion;
                int pointCuente = 0;
                foreach (char aract in version.ToCharArray())
                {
                    if (aract == '.') { pointCuente++; }
                }
                if (pointCuente > 2)
                {
                    pointCuente = 0;
                    for (int i = 0; i < version.Length; i++)
                    {
                        if (version[i] == '.')
                        {
                            pointCuente++;
                            if (pointCuente == 3)
                            {
                                version = version.Substring(0, i);
                                return true;
                            }
                        }
                    }
                }
                return true;
            }
            return false;
        }

        public void Version(Label lavel)
        {
            string url = "https://download.virtualbox.org/virtualbox/";
            string htmlCode;
            using (WebClient client = new WebClient())
            {
                htmlCode = client.DownloadString(url);
            }
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(htmlCode);

            HtmlNode vbVersionNode = doc.DocumentNode.SelectSingleNode("");
            string vbVersion = vbVersionNode.InnerText.Trim();

            lavel.Text = vbVersion;

        }
    }
}
