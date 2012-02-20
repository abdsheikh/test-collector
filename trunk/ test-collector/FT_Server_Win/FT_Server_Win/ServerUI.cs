using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FT_Server_Win
{
    public partial class ServerUI : Form
    {
        public ServerUI()
        {
            InitializeComponent();
            DataTable dataTable = Extension.CreateDataTableWithHeader();
            gridViewClientList.DataSource = dataTable;

        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
