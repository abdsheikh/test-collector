using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using COMExcel = Microsoft.Office.Interop.Excel;

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

            //RefreshStatus();
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
                statusText.Text = Extension.SERVER_STARTED;
                //RefreshStatus();
            }
        }

        private void CheckMessage()
        {
            while (socketControl.m_ServerSocketObject.isRunning())
            {
                Thread.Sleep(2000);
                List<ClientItem> list = socketControl.m_ServerSocketObject.clientItemList;
                DataRow row;
                int count = 0;
                foreach (ClientItem item in list)
                {
                    row = clientData.Rows.Find(item.StudentID);
                    if (row == null)
                    {
                        clientData.Rows.Add(clientData.Rows.Count + 1, item.ComputerName, item.IPAdress, item.StudentID, item.StudentName, Extension.GetMessage(item.Status));
                    }
                    else
                        row[5] = Extension.GetMessage(item.Status);
                    if (item.Status == Extension.DISCONNECTED)
                        count++;
                }
                gridViewClientList.DataSource = clientData;
                int statusCode;
                foreach (DataGridViewRow gridViewRow in gridViewClientList.Rows)
                {
                    statusCode = Extension.GetStatusCode(gridViewRow.Cells[5].Value.ToString());
                    switch (statusCode)
                    {
                        case Extension.CONNECTED:
                            gridViewRow.DefaultCellStyle.BackColor = Color.Orange;
                            break;
                        case Extension.SENDING:
                            gridViewRow.DefaultCellStyle.BackColor = Color.YellowGreen;
                            break;
                        case Extension.DISCONNECTED:
                            gridViewRow.DefaultCellStyle.BackColor = Color.Green;
                            break;
                        default:
                            gridViewRow.DefaultCellStyle.BackColor = Color.Azure;
                            break;
                    }
                }
                sentCount.Text = count.ToString();
                connectCount.Text = list.Count.ToString();
            }
        }

        private void ngắtKếtNốiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            socketControl.m_ServerSocketObject.StopServer();
            statusText.Text = Extension.SERVER_STOPPED;
        }

        private void ServerUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (socketControl.m_ServerSocketObject.isRunning())
                socketControl.m_ServerSocketObject.StopServer();
        }

        private void càiĐặtKếtNốiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm form = new SettingForm(socketControl);
            form.ShowDialog();
            //RefreshStatus();

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                lblSaveFolder.Text = folderBrowser.SelectedPath;
                btnViewFolder.Enabled = true;

                socketControl.OutputPath = folderBrowser.SelectedPath;
                socketControl.SaveConfiguration();
            }
        }

        private void btnViewFolder_Click(object sender, EventArgs e)
        {
            string myPath = lblSaveFolder.Text;
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = myPath;
            prc.Start();
        }

        private void gridViewClientList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (gridViewClientList.ColumnCount > 3)
            {
                gridViewClientList.Columns[0].Width = 40;
                gridViewClientList.Columns[1].Width = 150;
                gridViewClientList.Columns[2].Width = 150;
                gridViewClientList.Columns[3].Width = 150;
                gridViewClientList.Columns[4].Width = 150;
                gridViewClientList.Columns[5].Width = 150;
            }
        }

        //private void RefreshStatus()
        //{
        //    serverIPAddress.Text = socketControl.getIPAdress();
        //    serverName.Text = socketControl.m_ServerSocketObject.getHostName();
        //    listenningPort.Text = socketControl.SendPort.ToString();
        //}

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void nghiệpVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xuấtDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.ApplicationClass();
            object misvalue = System.Reflection.Missing.Value;
            COMExcel.Workbook exBook = exApp.Workbooks.Add(misvalue);
            exApp.Visible = false;

            COMExcel.Worksheet exSheet = (COMExcel.Worksheet)exBook.Worksheets.get_Item(1);

            //Trình Bày Tiêu Đề
            int row = 1;
            string[] tieude = { "STT", "MSSV", "Họ và tên"};
            exSheet.Cells[row, 1] = "Danh sách Thi";
            //if (t == 0)
            {
                row++;
                exSheet.Cells[row, 1] = "Môn: ";
                exSheet.Cells[row, 2] = "TÊN MÔN HỌC";
            }
            row++;
            //exSheet.Cells[row, 1] = "Học Kỳ: ";
            //exSheet.Cells[row, 2] = BCTKMDSHK.Text;

            row++;
            for (int i = 0; i < tieude.Length; i++)
                exSheet.Cells[row, i + 1] = tieude[i];


            for (int i = 1; i <= gridViewClientList.RowCount; i++)
                for (int j = 1; j <= gridViewClientList.ColumnCount; j++)
                    exSheet.Cells[i + row, j] = gridViewClientList.Rows[i - 1].Cells[j - 1].Value;

            if ((saveFileDialog1.ShowDialog() == DialogResult.OK) && (saveFileDialog1.FileName.Length != 0))
            {
                try
                {
                    exBook.SaveAs(saveFileDialog1.FileName, COMExcel.XlFileFormat.xlWorkbookNormal, misvalue, misvalue, misvalue, misvalue, COMExcel.XlSaveAsAccessMode.xlExclusive, misvalue, misvalue, misvalue, misvalue, misvalue);
                    MessageBox.Show("Ghi file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    exBook.Close(true, misvalue, misvalue);
                    exApp.Quit();

                    releaseObject(exSheet);
                    releaseObject(exBook);
                    releaseObject(exApp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Lỗi xảy ra khi giải phóng " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
