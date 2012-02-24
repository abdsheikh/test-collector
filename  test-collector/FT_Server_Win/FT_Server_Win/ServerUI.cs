using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace FT_Server_Win
{
    public partial class ServerUI : Form
    {
        private DataRow[] m_ClientList;
        DataTable clientData;
        ServerSocketControl socketControl;

        public ServerUI()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            clientData = Extension.CreateDataTableWithHeader();
            gridViewClientList.DataSource = clientData;
            socketControl = new ServerSocketControl();
            socketControl.OutputPath = @"D:\save";
            socketControl.SaveConfiguration();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bậtKếtNốiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!socketControl.m_ServerSocketObject.isRunning())
            {
                socketControl.m_ServerSocketObject.StartServer();
                Thread thread = new Thread(new ThreadStart(CheckMessage));
                thread.Start();
            }
        }

        private void CheckMessage()
        {
            while (socketControl.m_ServerSocketObject.isRunning())
            {
                Thread.Sleep(2000);
                List<ClientItem> list = socketControl.m_ServerSocketObject.clientItemList;
                foreach (ClientItem item in list)
                {
                    if (clientData.Rows.Find(item.StudentID) == null)
                        clientData.Rows.Add(clientData.Rows.Count + 1, item.ComputerName, item.IPAdress, item.StudentID, item.StudentName, item.Status);
                }
                gridViewClientList.DataSource = clientData;
            }
        }

        private void ngắtKếtNốiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            socketControl.m_ServerSocketObject.StopServer();
        }

        private void ServerUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (socketControl.m_ServerSocketObject.isRunning())
                socketControl.m_ServerSocketObject.StopServer();
        }

        public void ShowMessage()
        {
            MessageBox.Show("Hello!");
        }

        private void càiĐặtKếtNốiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm form = new SettingForm(socketControl);
            form.ShowDialog();
            MessageBox.Show(socketControl.SendPort.ToString());
        }

        
    }
}
