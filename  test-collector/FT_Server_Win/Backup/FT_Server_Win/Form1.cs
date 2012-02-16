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
    public partial class Form1 : Form
    {
        SyncSocketServerMulClient servObj = new SyncSocketServerMulClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStartSvr_Click(object sender, EventArgs e)
        {
            servObj.StartServer();
            lblMsg.Text = servObj.currentStatus;
        }

        private void btnStopSvr_Click(object sender, EventArgs e)
        {
            servObj.StopServer();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            servObj.StopServer();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            servObj.StopServer();            
            Application.Exit();
        }
    }
}