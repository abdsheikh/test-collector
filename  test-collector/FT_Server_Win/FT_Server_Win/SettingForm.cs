using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            RefreshStatus();
        }

        private void grpSetting_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            socketControl.ReceivedPort = (int)(receivePort.Value);
            socketControl.SaveConfiguration();
            this.Close();
        }

        private void RefreshStatus()
        {
            serverIPAddress.Text = socketControl.getIPAdress();
            serverName.Text = socketControl.m_ServerSocketObject.getHostName();
            listenningPort.Text = socketControl.SendPort.ToString();
        }
    }
}
