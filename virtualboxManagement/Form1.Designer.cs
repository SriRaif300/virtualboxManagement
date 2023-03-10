namespace virtualboxManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            label20 = new Label();
            Hostname = new Label();
            label18 = new Label();
            IPGateway = new Label();
            label16 = new Label();
            SSIDStatus = new Label();
            label14 = new Label();
            Version = new Label();
            label6 = new Label();
            Internet = new Label();
            IPHost = new Label();
            label1 = new Label();
            label12 = new Label();
            Username = new Label();
            label10 = new Label();
            SSID = new Label();
            label7 = new Label();
            MAC = new Label();
            label9 = new Label();
            IsInstalled = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.886256F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.952606F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.412322F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.808103F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.955224F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.381663F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.3411512F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.6204691F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.579957F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.0213223F));
            tableLayoutPanel1.Controls.Add(label20, 0, 1);
            tableLayoutPanel1.Controls.Add(Hostname, 0, 1);
            tableLayoutPanel1.Controls.Add(label18, 0, 1);
            tableLayoutPanel1.Controls.Add(IPGateway, 0, 1);
            tableLayoutPanel1.Controls.Add(label16, 0, 1);
            tableLayoutPanel1.Controls.Add(SSIDStatus, 0, 1);
            tableLayoutPanel1.Controls.Add(label14, 0, 1);
            tableLayoutPanel1.Controls.Add(Version, 0, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 1);
            tableLayoutPanel1.Controls.Add(Internet, 0, 1);
            tableLayoutPanel1.Controls.Add(IPHost, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label12, 2, 0);
            tableLayoutPanel1.Controls.Add(Username, 3, 0);
            tableLayoutPanel1.Controls.Add(label10, 4, 0);
            tableLayoutPanel1.Controls.Add(SSID, 5, 0);
            tableLayoutPanel1.Controls.Add(label7, 6, 0);
            tableLayoutPanel1.Controls.Add(MAC, 7, 0);
            tableLayoutPanel1.Controls.Add(label9, 8, 0);
            tableLayoutPanel1.Controls.Add(IsInstalled, 9, 0);
            tableLayoutPanel1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(12, 103);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.7804871F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.2195129F));
            tableLayoutPanel1.Size = new Size(938, 61);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(3, 29);
            label20.Name = "label20";
            label20.Size = new Size(68, 13);
            label20.TabIndex = 19;
            label20.Text = "IP Gateway:";
            // 
            // Hostname
            // 
            Hostname.AutoSize = true;
            Hostname.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Hostname.Location = new Point(257, 29);
            Hostname.Name = "Hostname";
            Hostname.Size = new Size(31, 13);
            Hostname.TabIndex = 18;
            Hostname.Text = "PC-V";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(349, 29);
            label18.Name = "label18";
            label18.Size = new Size(68, 13);
            label18.TabIndex = 17;
            label18.Text = "SSID Status:";
            // 
            // IPGateway
            // 
            IPGateway.AutoSize = true;
            IPGateway.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            IPGateway.Location = new Point(86, 29);
            IPGateway.Name = "IPGateway";
            IPGateway.Size = new Size(21, 13);
            IPGateway.TabIndex = 16;
            IPGateway.Text = "hh";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(179, 29);
            label16.Name = "label16";
            label16.Size = new Size(63, 13);
            label16.TabIndex = 15;
            label16.Text = "Hostname:";
            // 
            // SSIDStatus
            // 
            SSIDStatus.AutoSize = true;
            SSIDStatus.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            SSIDStatus.Location = new Point(433, 29);
            SSIDStatus.Name = "SSIDStatus";
            SSIDStatus.Size = new Size(56, 13);
            SSIDStatus.TabIndex = 14;
            SSIDStatus.Text = "Conected";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(727, 29);
            label14.Name = "label14";
            label14.Size = new Size(105, 13);
            label14.TabIndex = 13;
            label14.Text = "VirtualBox Version:";
            // 
            // Version
            // 
            Version.AutoSize = true;
            Version.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Version.Location = new Point(845, 29);
            Version.Name = "Version";
            Version.Size = new Size(31, 13);
            Version.TabIndex = 12;
            Version.Text = "7.0.6";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(521, 29);
            label6.Name = "label6";
            label6.Size = new Size(70, 26);
            label6.TabIndex = 5;
            label6.Text = "Internet Connection:";
            // 
            // Internet
            // 
            Internet.AutoSize = true;
            Internet.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Internet.Location = new Point(618, 29);
            Internet.Name = "Internet";
            Internet.Size = new Size(66, 13);
            Internet.TabIndex = 2;
            Internet.Text = "Established";
            // 
            // IPHost
            // 
            IPHost.AutoSize = true;
            IPHost.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            IPHost.Location = new Point(86, 0);
            IPHost.Name = "IPHost";
            IPHost.Size = new Size(64, 13);
            IPHost.TabIndex = 1;
            IPHost.Text = "192.168.0.2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 13);
            label1.TabIndex = 0;
            label1.Text = "IP Host:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(179, 0);
            label12.Name = "label12";
            label12.Size = new Size(62, 13);
            label12.TabIndex = 11;
            label12.Text = "Username:";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Username.Location = new Point(257, 0);
            Username.Name = "Username";
            Username.Size = new Size(42, 13);
            Username.TabIndex = 7;
            Username.Text = "Camilo";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(349, 0);
            label10.Name = "label10";
            label10.Size = new Size(33, 13);
            label10.TabIndex = 9;
            label10.Text = "SSID:";
            // 
            // SSID
            // 
            SSID.AutoSize = true;
            SSID.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            SSID.Location = new Point(433, 0);
            SSID.Name = "SSID";
            SSID.Size = new Size(58, 13);
            SSID.TabIndex = 4;
            SSID.Text = "SuperWifi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(521, 0);
            label7.Name = "label7";
            label7.Size = new Size(81, 13);
            label7.TabIndex = 6;
            label7.Text = "MAC Address:";
            // 
            // MAC
            // 
            MAC.AutoSize = true;
            MAC.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            MAC.Location = new Point(618, 0);
            MAC.Name = "MAC";
            MAC.Size = new Size(101, 13);
            MAC.TabIndex = 3;
            MAC.Text = "30-65-EC-6F-C4-58";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(727, 0);
            label9.Name = "label9";
            label9.Size = new Size(75, 26);
            label9.TabIndex = 8;
            label9.Text = "Is VirtualBox Installed?:";
            // 
            // IsInstalled
            // 
            IsInstalled.AutoSize = true;
            IsInstalled.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            IsInstalled.Location = new Point(845, 0);
            IsInstalled.Name = "IsInstalled";
            IsInstalled.Size = new Size(22, 13);
            IsInstalled.TabIndex = 10;
            IsInstalled.Text = "Yes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(191, 8);
            label2.Name = "label2";
            label2.Size = new Size(674, 54);
            label2.TabIndex = 1;
            label2.Text = "Welcome To VirtualBox Management";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 175);
            Controls.Add(label2);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label20;
        private Label Hostname;
        private Label label18;
        private Label IPGateway;
        private Label label16;
        private Label SSIDStatus;
        private Label label14;
        private Label Version;
        private Label label6;
        private Label Internet;
        private Label IPHost;
        private Label label1;
        private Label label12;
        private Label Username;
        private Label label10;
        private Label SSID;
        private Label label7;
        private Label MAC;
        private Label label9;
        private Label IsInstalled;
        private Label label2;
    }
}