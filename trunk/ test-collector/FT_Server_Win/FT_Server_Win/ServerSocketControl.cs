using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ServerSockets.Synchronous.UsingByteArray;
using System.Net;

namespace FT_Server_Win
{
    public partial class ServerSocketControl : UserControl
    {

        #region Properties
        public SyncSocketServerMulClient m_ServerSocketObject;

        private string m_OutputPath;

        public string OutputPath
        {
            get { return m_OutputPath; }
            set { m_OutputPath = value; }
        }
        private int m_SendPort;

        public int SendPort
        {
            get { return m_SendPort; }
            set { m_SendPort = value; }
        }
        private int m_ReceivedPort;

        public int ReceivedPort
        {
            get { return m_ReceivedPort; }
            set { m_ReceivedPort = value; }
        }
        private int m_MaxClient;

        public int MaxClient
        {
            get { return m_MaxClient; }
            set { m_MaxClient = value; }
        }

        private string m_CurrentStatus;

        public string CurrentStatus
        {
            get { return m_CurrentStatus; }
            set { m_CurrentStatus = value; }
        }
        #endregion

        #region Methods
        public ServerSocketControl()
        {
            InitializeComponent();
            m_ServerSocketObject = new SyncSocketServerMulClient();
            m_OutputPath=@"C:\";
            m_SendPort = 8080;
            m_ReceivedPort = 8081;
            m_MaxClient = 111;
        }

        private void ServerSocketControl_Load(object sender, EventArgs e)
        {

        }

        private void UiTServer_Load(object sender, EventArgs e)
        {
            
        }

        private void StartSever()
        {
            if (m_ServerSocketObject.isRunning())
                MessageBox.Show("Server is Running");
            else
                m_ServerSocketObject.StartServer();
            m_CurrentStatus = m_ServerSocketObject.currentStatus;
        }

        private void StopServer()
        {
            if (m_ServerSocketObject.isRunning() == false)
                MessageBox.Show("Server Stoped!!!");
            else
                m_ServerSocketObject.StopServer();
        }

        public void SaveConfiguration()
        {
            m_ServerSocketObject.SettingServer(m_ReceivedPort, m_SendPort, m_MaxClient, m_OutputPath);
        }

        public string getComputerName()
        {
            return Dns.GetHostName();
        }

        public string getIPAdress()
        {
            return m_ServerSocketObject.getLocalIPAdress(getComputerName());
        }

        #endregion
    }
}
