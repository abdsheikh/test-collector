using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ServerSockets.Synchronous.UsingByteArray;

namespace FT_Server_Win
{
    public partial class AppServer : Form
    {
        SyncSocketServerMulClient servObj = new SyncSocketServerMulClient();
        public static int receivePort, sendPort, maxClientReceived;
        //public static int  progress=0 ;
        public string outPath=@"C:\";

        public AppServer()
        {
            InitializeComponent();
        }

        private void UiTServer_Load(object sender, EventArgs e)
        {
            lbOutputPath.Text=@"C:\";
            txtSendPort.Text = "8081";
            txtRecievedPort.Text= "8080";
            txtMaxClient.Text = "111";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartSever();
        }

        private void StartSever()
        {
            if (servObj.isRunning())
                MessageBox.Show("server Running");
            else
                servObj.StartServer();
            label6.Text = servObj.currentStatus;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StopServer();
        }

        private void StopServer()
        {
            if (servObj.isRunning() == false)
                MessageBox.Show("Server Stoped!!!");
            else
                servObj.StopServer();
            label6.Text = servObj.currentStatus;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() != DialogResult.OK)
            {               
                MessageBox.Show("Cancel! Using Default Output Path!");
            }
            else
            {
                lbOutputPath.Text = fbd.SelectedPath;                
            }
            outPath = lbOutputPath.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            receivePort =Convert.ToInt32(txtRecievedPort.Text);
            sendPort = Convert.ToInt32(txtSendPort.Text);
            maxClientReceived = Convert.ToInt32(txtMaxClient.Text);
            servObj.SettingServer(receivePort, sendPort, maxClientReceived,outPath);
            label6.Text = "Setting successfully!";
        }
    }
}
