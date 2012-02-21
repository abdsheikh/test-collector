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
                txtMessage.Text += socketControl.m_ServerSocketObject.MessagePool;
                foreach (ClientItem item in list)
                {
                    clientData.Rows.Add(1, item.ComputerName, item.IPAdress, item.StudentID, item.StudentName, item.Status);
                }
                gridViewClientList.DataSource = clientData;
            }
        }

        private void ngắtKếtNốiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            socketControl.m_ServerSocketObject.StopServer();
        }

        
    }
}
