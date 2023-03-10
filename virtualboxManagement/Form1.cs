using System.Diagnostics;
using System.Net.NetworkInformation;

namespace virtualboxManagement
{
    public partial class Form1 : Form
    {
        string url = "C:\\Program Files\\Oracle\\virtualbox\\VBoxManage.exe";
        AppManager app = new AppManager();
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            app.GetLocalAddress(NetworkInterfaceType.Wireless80211);
            IPHost.Text = app.ipHost;
            IPGateway.Text = app.gateway;
            Username.Text = app.userName;
            Hostname.Text = app.hostName;
            MAC.Text = app.macAddress;

            switch (app.GetConnection())
            {
                case 0:
                    Internet.Text = "Established";
                    Internet.ForeColor = Color.Green;
                    break;
                case 1:
                    Internet.Text = "Unstable";
                    Internet.ForeColor = Color.Goldenrod;
                    break;
                case 2:
                    Internet.Text = "Disconnected";
                    Internet.ForeColor = Color.Red;
                    break;
            }

            app.getSSID(SSIDStatus, SSID);
           
            if (app.IsVirtualBoxInstalled(url))
            {
                IsInstalled.Text = "Yes";
                IsInstalled.ForeColor = Color.Green;
            }
            else
            {
                IsInstalled.Text = "No";
                IsInstalled.ForeColor = Color.Red;
            }
            Version.Text = app.version;
            //app.Version(Version);
        }

    }
}