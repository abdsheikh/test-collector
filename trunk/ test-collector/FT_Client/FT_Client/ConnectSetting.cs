using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace FT_Client
{
    public partial class ConnectSetting : Form
    {
        public ConnectSetting()
        {
            InitializeComponent();
        }
        //private static ComputerInfo comInfo = new ComputerInfo();
        private static ProcessingIpLan processingIp = new ProcessingIpLan();
        public delegate void SettingServer(IPAddress ipad, int port);
        public SettingServer MySettingServer;

        public delegate void SetFlagForm(int temp);
        public SetFlagForm MySetFlagForm;

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtIp4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSendPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtIp1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtIp2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtIp3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        public static string pathFolderToSaveSetting = Directory.GetCurrentDirectory();
        public static string fileNameToSaveSetting = "config.ini";
        public static string FullPathFileToSaveSetting = pathFolderToSaveSetting + @"\" + fileNameToSaveSetting;

        private bool LoadConfig(TextBox txt1,TextBox txt2,TextBox txt3, TextBox txt4, TextBox txtsendport)
        {
            ReadWriteToFile rwSetting = new ReadWriteToFile();
            try
            {
                string[] config = rwSetting.ReadFromFile(FullPathFileToSaveSetting);
                string[] ipserver = config[0].Split('.');
                txt1.Text = ipserver[0];
                txt2.Text = ipserver[1];
                txt3.Text = ipserver[2];
                txt4.Text = ipserver[3];
                txtsendport.Text = config[1];
                return true;
            }
            catch (System.Exception ex)
            {
                txt1.Text = "127";
                txt2.Text = "0";
                txt3.Text = "0";
                txt4.Text = "0";
                txtSendPort.Text = "8080";
                return false;
            }
        }
        private void ConnectSetting_Load(object sender, EventArgs e)
        {
            LoadConfig(txtIp1,txtIp2,txtIp3,txtIp4,txtSendPort);
        }
        private void btFindIpLan_Click(object sender, EventArgs e)
        {
            lbSettingInfo.Text = "Vui lòng đợi giây lát! Hệ thống đang tìm kiếm.....";
            lbSettingInfo.Refresh();
            FindIpInLan(listView1);
            lbSettingInfo.Text = "Đã xong!";
        }

        private void FindIpInLan(ListView lview1)
        {
           // IPAddress[] Adresses2 = processingIp.GetAllUnicastAddresses_New();
            int i = 1;
            lview1.Items.Clear();
            lview1.Refresh();
            /*
            foreach (IPAddress Adres in Adresses2)
            {
                string hostname = processingIp.GetHostNameFromIpAdress(Adres);
                ListViewItem item1 = new ListViewItem((i++).ToString(), 0);
                // Place a check mark next to the item.
                item1.SubItems.Add(hostname);
                item1.SubItems.Add(Adres.ToString());
                lview1.Items.Add(item1);
            }
            */
            Process netUtility = new Process();
            netUtility.StartInfo.FileName = "net.exe";
            netUtility.StartInfo.CreateNoWindow = true;
            netUtility.StartInfo.Arguments = "view";
            netUtility.StartInfo.RedirectStandardOutput = true;
            netUtility.StartInfo.UseShellExecute = false;
            netUtility.StartInfo.RedirectStandardError = true;
            netUtility.Start();
            StreamReader streamReader = new StreamReader(netUtility.StandardOutput.BaseStream, netUtility.StandardOutput.CurrentEncoding);
            string line = "";
            while ((line = streamReader.ReadLine()) != null)
            {
                if (line.StartsWith("\\"))
                {
                    //listBox1.Items.Add(line.Substring(2).Substring(0, line.Substring(2).IndexOf(" ")).ToUpper());
                    string hostname = line.Substring(2).Substring(0, line.Substring(2).IndexOf(" ")).ToUpper();
                    string ip = processingIp.GetIpFromHostName(hostname); 
                    ListViewItem item1 = new ListViewItem((i++).ToString(), 0);
                    item1.SubItems.Add(hostname);
                    item1.SubItems.Add(ip);
                    lview1.Items.Add(item1);                 
                }
            }
            streamReader.Close();
            netUtility.WaitForExit(1000); 

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            if (item != null)
            {               
                if (item.SubItems[2].Text != null || item.SubItems[2].Text != "")
                {
                    
                    string[] subIp = item.SubItems[2].Text.Split('.');
                    if (subIp.Length >= 4)
                    {
                        txtIp1.Text = subIp[0];
                        txtIp2.Text = subIp[1];
                        txtIp3.Text = subIp[2];
                        txtIp4.Text = subIp[3];
                    }
                }
            }  
        }
        public IPAddress ipAd = IPAddress.Parse("127.0.0.1");
        public bool CheckIpAdress(string ipad)
        {
            try
            {
               ipAd=IPAddress.Parse(ipad);
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }
        private void btSetting_Click(object sender, EventArgs e)
        {
            string tempIp = txtIp1.Text + "." + txtIp2.Text + "." + txtIp3.Text + "." + txtIp4.Text;
            if (!CheckIpAdress(tempIp))
            {
                MessageBox.Show("Ip không hợp lệ!!!");
                return;
            }
            int port = ConvertSendPortToInt(txtSendPort.Text);
            if (port <= 0)
            {
                MessageBox.Show("Port Không Hợp Lệ");
                txtSendPort.Focus();
                return;
            }
            MySettingServer(ipAd, port);
        }
        public int ConvertSendPortToInt(string port)
        {
            try
            {
                return Convert.ToInt32(port);
            }
            catch (System.Exception ex)
            {
                return -11;
            }
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ConnectSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            MySetFlagForm(0);
        }      
    }
}
