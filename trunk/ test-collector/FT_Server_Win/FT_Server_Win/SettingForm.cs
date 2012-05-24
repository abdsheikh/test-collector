using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FT_Server_Win
{
    public partial class SettingForm : Form
    {


        public ServerSocketControl socketControl;
        public SettingForm()
        {
            InitializeComponent();
        }

        public SettingForm(ServerSocketControl socket)
        {
            InitializeComponent();
            socketControl = socket;
            try
            {
                string filePath = ServerUI.CurrentDirectory + "\\" + ServerUI.SETTINGFILE;
                if (File.Exists(filePath))
                {
                    StreamReader sr = new StreamReader(filePath);
                    socketControl.ReceivedPort = Int32.Parse(sr.ReadLine().ToString());
                    sr.Close();
                }
            }
            catch (Exception Exception)
            {
            }
            RefreshStatus();
        }

        private void grpSetting_Enter(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            socketControl.ReceivedPort = (int)(receivePort.Value);
            socketControl.SaveConfiguration();

            StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "\\" + ServerUI.SETTINGFILE,false);
            sw.WriteLine(socketControl.ReceivedPort);
            sw.Close();
            this.Close();
        }

        private void RefreshStatus()
        {
            serverIPAddress.Text = socketControl.getIPAdress();
            serverName.Text = socketControl.m_ServerSocketObject.getHostName();
            listenningPort.Text = socketControl.ReceivedPort.ToString();
            receivePort.Value = socketControl.ReceivedPort;
        }

        private void receivePort_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
