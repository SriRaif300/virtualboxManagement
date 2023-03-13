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
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.XPath;
using System.Net.Http;
using System.Xml.XPath;
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
        public string versionInstaled = "";

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
                versionInstaled = versionInfo.FileVersion;
                int pointCuente = 0;
                foreach (char aract in versionInstaled.ToCharArray())
                {
                    if (aract == '.') { pointCuente++; }
                }
                if (pointCuente > 2)
                {
                    pointCuente = 0;
                    for (int i = 0; i < versionInstaled.Length; i++)
                    {
                        if (versionInstaled[i] == '.')
                        {
                            pointCuente++;
                            if (pointCuente == 3)
                            {
                                versionInstaled = versionInstaled.Substring(0, i);
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
            var web = new HtmlWeb();
            var doc = web.Load(url);
            var nodes = doc.DocumentNode.SelectNodes("//a[@href]");
            string version = "";
            foreach (var node in nodes)
            {
                string str = node.GetAttributeValue("href", "");
                if (Regex.IsMatch(str, @"[0-9]\.[0-9]\.[0-9]/")) { version = Regex.Match(str, @"[0-9]\.[0-9]\.[0-9]").Value; }
            }
            if(versionInstaled.Equals(version))
            {
                lavel.Text = versionInstaled +""+ "(Last Version)";
                lavel.ForeColor = Color.Green;
            }
            else
            {
                lavel.Text = versionInstaled + "" + "(Outdated)";
                lavel.ForeColor = Color.Goldenrod;
            }
        }
    }
}
