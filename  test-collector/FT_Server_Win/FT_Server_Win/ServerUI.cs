using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using CarlosAg.ExcelXmlWriter;
using System.IO;

namespace FT_Server_Win
{
    public partial class ServerUI : Form
    {
        private const string NOT_IDENTIFIED = "<Chưa xác định>";

        private DataRow[] m_ClientList;
        DataTable clientData;
        ServerSocketControl socketControl;
        bool isSelectedFolder = false;
        bool firstRun = true;
        Clocker m_clock;

        #region Class Information
        private string m_Subject = String.Empty;
        private DateTime m_Date = DateTime.Now;
        private int m_StudentSum = 0;
        private Clocker m_FromTime;
        private Clocker m_ToTime;
        private int m_TestPeriod = 1;
        #endregion

        public ServerUI()
        {
            InitializeComponent();

            InitFormSize();

            CheckForIllegalCrossThreadCalls = false;
            clientData = Extension.CreateDataTableWithHeader();
            gridViewClientList.DataSource = clientData;
            socketControl = new ServerSocketControl();
            socketControl.OutputPath = @"D:\save";
            socketControl.SaveConfiguration();

            m_FromTime = new Clocker();
            m_ToTime = new Clocker();

            if (socketControl.m_ServerSocketObject.isRunning())
            {
                imgServer.Image = Properties.Resources.running;
            }
            else
            {
                imgServer.Image = Properties.Resources.stopped;
            }

            ResetInformation();
        }

        private void InitFormSize()
        {
            //form
            Size desktopSize = SystemInformation.WorkingArea.Size;
            this.Width = desktopSize.Width;
            this.Height = desktopSize.Height;
            this.StartPosition = FormStartPosition.CenterScreen;
            FixControlsSize(this.Width, this.Height);
        }

        private void FixControlsSize(int formWidth, int formHeight)
        {
            //dataGridView
            gridViewClientList.Width = (int)(formWidth * 0.75f);
            gridViewClientList.Height = (int)(formHeight * 0.70f);

            //right bar
            rightPanel.Left = gridViewClientList.Left + gridViewClientList.Width + 5;
            rightPanel.Width = formWidth - gridViewClientList.Width;
            rightPanel.Height = gridViewClientList.Height;

            //bottom bar
            bottomPanel.Height = (int)(formHeight * 0.15f);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bậtKếtNốiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSelectedFolder == false)
            {
                MessageBox.Show("Chưa chọn thư mục lưu bài làm. Nhấn \"Chọn thư mục\" ở bên dưới!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (!socketControl.m_ServerSocketObject.isRunning()) 
            {
                socketControl.m_ServerSocketObject.StartServer();
                Thread thread = new Thread(new ThreadStart(CheckMessage));
                thread.Start();
                statusText.Text = Extension.SERVER_STARTED;
                startedTimer.Enabled = true;
                //RefreshStatus();
            }

            if (socketControl.m_ServerSocketObject.isRunning())
            {
                imgServer.Image = FT_Server_Win.Properties.Resources.running;
            }

            m_clock = new Clocker();
            lblStartedTime.Visible = true;
        }

        private void CheckMessage()
        {
            while (socketControl.m_ServerSocketObject.isRunning())
            {
                Thread.Sleep(2000);
                List<ClientItem> list = socketControl.m_ServerSocketObject.clientItemList;
                DataRow row;
                int count = 0;
                int sentTimes;
                foreach (ClientItem item in list)
                {
                    row = clientData.Rows.Find(item.IPAdress.ToString());
                    if (row == null)
                    {
                        clientData.Rows.Add(clientData.Rows.Count + 1, item.ComputerName, item.IPAdress, item.StudentID, item.StudentName, item.Birthday, Extension.GetMessage(item.Status),item.SentTimes);
                    }
                    else
                    {
                        row[Extension.COLUMN_CLIENTSTATUS] = Extension.GetMessage(item.Status);
                        row[Extension.COLUMN_STUDENTID] = item.StudentID;
                        row[Extension.COLUMN_STUDENTNAME] = item.StudentName;
                        row[Extension.COLUMN_SUBMITTIMES] = item.SentTimes;
                        
                    }
                    if (item.Status == Extension.DISCONNECTED)
                        count++;
                }
                gridViewClientList.DataSource = clientData;
                int statusCode;
                foreach (DataGridViewRow gridViewRow in gridViewClientList.Rows)
                {
                    statusCode = Extension.GetStatusCode(gridViewRow.Cells[Extension.COLUMN_CLIENTSTATUS].Value.ToString());
                    switch (statusCode)
                    {
                        case Extension.CONNECTED:
                        case Extension.SENDING:
                            gridViewRow.DefaultCellStyle.BackColor = Color.Aqua;
                            break;
                        case Extension.DISCONNECTED:
                            gridViewRow.DefaultCellStyle.BackColor = Color.Azure;
                            break;
                        default:
                            gridViewRow.DefaultCellStyle.BackColor = Color.Azure;
                            break;
                    }
                }
                sentCount.Text = count.ToString();
                //connectCount.Text = clientData.Rows.Count.ToString();
                connectCount.Text = socketControl.m_ServerSocketObject.clientItemList.Count.ToString();
            }
        }

        private void ngắtKếtNốiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            socketControl.m_ServerSocketObject.StopServer();
            statusText.Text = Extension.SERVER_STOPPED;
            imgServer.Image = Properties.Resources.stopped;
            startedTimer.Enabled = false;
        }

        private void ServerUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (socketControl.m_ServerSocketObject.isRunning())
            try
            {
                socketControl.m_ServerSocketObject.StopServer();
            }
            catch (Exception exception)
            {
            }
            finally
            {
                this.Dispose();
            }

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
                isSelectedFolder = true;
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
            int width = gridViewClientList.Width;
            if (gridViewClientList.ColumnCount > 3)
            {
                gridViewClientList.Columns[Extension.COLUMN_ITEMINDEX].Width = (int)(0.046f*width);
                gridViewClientList.Columns[Extension.COLUMN_COMPUTERNAME].Width = (int)(0.15f*width);
                gridViewClientList.Columns[Extension.COLUMN_IPADDRESS].Width = (int)(0.14f*width);
                gridViewClientList.Columns[Extension.COLUMN_STUDENTID].Width = (int)(0.14f*width);
                gridViewClientList.Columns[Extension.COLUMN_STUDENTNAME].Width = (int)(0.15f*width);
                gridViewClientList.Columns[Extension.COLUMN_BIRTHDAY].Width = (int)(0.11f * width);
                gridViewClientList.Columns[Extension.COLUMN_CLIENTSTATUS].Width = (int)(0.18f * width);
                gridViewClientList.Columns[Extension.COLUMN_SUBMITTIMES].Width = (int)(0.08f * width);
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
            if (saveFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel && saveFileDialog1.CheckPathExists)
            {
                try
                {
                    // Create the workbook
                    Workbook book = new Workbook();

                    // Set the author
                    book.Properties.Author = "Phần mềm thu bài thi qua mạng LAN";

                    // Add some style
                    WorksheetStyle style = book.Styles.Add("style1");
                    style.Font.Bold = true;
                 

                    Worksheet sheet = book.Worksheets.Add("SampleSheet");

                    WorksheetRow dataRow;

                    dataRow = sheet.Table.Rows.Add();
                    // Add a cell
                    dataRow.Cells.Add("Thống kê nộp bài thi", DataType.String, "style1");

                    dataRow = sheet.Table.Rows.Add();
                    dataRow.Cells.Add("Môn thi:", DataType.String, "style1");
                    dataRow.Cells.Add(m_Subject, DataType.String, "style1");

                    dataRow = sheet.Table.Rows.Add();
                    dataRow.Cells.Add("Ngày thi:", DataType.String, "style1");
                    dataRow.Cells.Add(m_Date.ToString(), DataType.String, "style1");

                    dataRow = sheet.Table.Rows.Add();
                    dataRow.Cells.Add("Ca thi:", DataType.String, "style1");
                    string strPeriodRange = " ( Từ " + m_FromTime.GetTimeText() + " đến " + m_ToTime.GetTimeText() + ")";
                    dataRow.Cells.Add(m_TestPeriod.ToString() +  strPeriodRange, DataType.String, "style1");

                    dataRow = sheet.Table.Rows.Add();
                    dataRow.Cells.Add("Tổng số thí sinh:", DataType.String, "style1");
                    dataRow.Cells.Add(m_StudentSum.ToString(), DataType.String, "style1");

                    dataRow = sheet.Table.Rows.Add();
                    dataRow.Cells.Add("Số thí sinh dự thi:", DataType.String, "style1");
                    dataRow.Cells.Add(connectCount.Text, DataType.String, "style1");

                    dataRow = sheet.Table.Rows.Add();
                    dataRow.Cells.Add("Số thí sinh nộp bài:", DataType.String, "style1");
                    dataRow.Cells.Add(sentCount.Text, DataType.String, "style1");

                    sheet.Table.Rows.Add();

                    dataRow = sheet.Table.Rows.Add();
                    dataRow.Cells.Add("STT", DataType.String, "style1");
                    dataRow.Cells.Add("MSSV", DataType.String, "style1");
                    dataRow.Cells.Add("Họ Và Tên", DataType.String, "style1");
                    dataRow.Cells.Add("Ngày Sinh", DataType.String, "style1");
                    dataRow.Cells.Add("Tình trạng nộp bài", DataType.String, "style1");

                    foreach (DataGridViewRow row in gridViewClientList.Rows)
                    {
                        dataRow = sheet.Table.Rows.Add();
                        dataRow.Cells.Add(row.Cells[Extension.COLUMN_ITEMINDEX].Value.ToString(), DataType.String, "style1");
                        dataRow.Cells.Add(row.Cells[Extension.COLUMN_STUDENTID].Value.ToString(), DataType.String, "style1");
                        dataRow.Cells.Add(row.Cells[Extension.COLUMN_STUDENTNAME].Value.ToString(), DataType.String, "style1");
                        dataRow.Cells.Add(row.Cells[Extension.COLUMN_BIRTHDAY].Value.ToString(), DataType.String, "style1");
                        string submitStatus = "Chưa gửi";
                        int submitTimes = (int)row.Cells[Extension.COLUMN_SUBMITTIMES].Value;
                        if (submitTimes > 0)
                            submitStatus = "Đã gửi";
                        dataRow.Cells.Add(submitStatus, DataType.String, "style1");
                        //exSheet.Cells[i + row, j] = gridViewClientList.Rows[i - 1].Cells[j - 1].Value;
                    }
                    // Save it             
                    book.Save(saveFileDialog1.FileName);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Không thể ghi file!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Ghi dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //COMExcel.Application exApp = new COMExcel.ApplicationClass();
            //object misvalue = System.Reflection.Missing.Value;
            //COMExcel.Workbook exBook = exApp.Workbooks.Add(misvalue);
            //exApp.Visible = false;

            //COMExcel.Worksheet exSheet = (COMExcel.Worksheet)exBook.Worksheets.get_Item(1);

            ////Trình Bày Tiêu Đề
            //int row = 1;
            //string[] tieude = { "STT", "MSSV", "Họ và tên","Ngày sinh","Tình trạng nộp bài"};
            //exSheet.Cells[row, 1] = "Danh sách Thi";
            //row++;
            //exSheet.Cells[row, 1] = "Môn thi: ";
            //exSheet.Cells[row, 2] = m_Subject;

            //row++;
            //exSheet.Cells[row, 1] = "Ngày thi: ";
            //exSheet.Cells[row, 2] = m_Date;

            //row++;
            //exSheet.Cells[row, 1] = "Tổng số thí sinh: ";
            //exSheet.Cells[row, 2] = m_StudentSum;

            //row++;
            //exSheet.Cells[row, 1] = "Số thí sinh sự thi: ";
            //exSheet.Cells[row, 2] = connectCount.Text;

            //row++;
            //exSheet.Cells[row, 1] = "Số thí sinh nộp bài: ";
            //exSheet.Cells[row, 2] = sentCount.Text;

            //row += 2;
            //for (int i = 0; i < tieude.Length; i++)
            //    exSheet.Cells[row, i + 1] = tieude[i];


            //for (int i = 1; i <= gridViewClientList.RowCount; i++)
            ////for (int j = 1; j <= gridViewClientList.ColumnCount; j++)
            //{
            //    exSheet.Cells[i + row, 1] = gridViewClientList.Rows[i - 1].Cells[Extension.COLUMN_ITEMINDEX].Value;
            //    exSheet.Cells[i + row, 2] = gridViewClientList.Rows[i - 1].Cells[Extension.COLUMN_STUDENTID].Value;
            //    exSheet.Cells[i + row, 3] = gridViewClientList.Rows[i - 1].Cells[Extension.COLUMN_STUDENTNAME].Value;
            //    exSheet.Cells[i + row, 4] = gridViewClientList.Rows[i - 1].Cells[Extension.COLUMN_BIRTHDAY].Value;
            //    string submitStatus = "Chưa gửi";
            //    int submitTimes =(int)gridViewClientList.Rows[i - 1].Cells[Extension.COLUMN_SUBMITTIMES].Value;
            //    if (submitTimes > 0)
            //        submitStatus = "Đã gửi";
            //    exSheet.Cells[i + row, 5] = submitStatus ;
            //    //exSheet.Cells[i + row, j] = gridViewClientList.Rows[i - 1].Cells[j - 1].Value;
            //}

            //if ((saveFileDialog1.ShowDialog() == DialogResult.OK) && (saveFileDialog1.FileName.Length != 0))
            //{
            //    try
            //    {
            //        exBook.SaveAs(saveFileDialog1.FileName, COMExcel.XlFileFormat.xlWorkbookNormal, misvalue, misvalue, misvalue, misvalue, COMExcel.XlSaveAsAccessMode.xlExclusive, misvalue, misvalue, misvalue, misvalue, misvalue);
            //        MessageBox.Show("Ghi file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        exBook.Close(true, misvalue, misvalue);
            //        exApp.Quit();

            //        releaseObject(exSheet);
            //        releaseObject(exBook);
            //        releaseObject(exApp);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
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

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void gridViewClientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        public void setClassInformation(string subject, DateTime date, int testPeriod, int sumOfStudent, Clocker fromTime, Clocker toTime)
        {
            lblSubject.Text = m_Subject = subject;
            m_Date = date;
            m_StudentSum = sumOfStudent;
            lblDate.Text = String.Format("{0}/{1}/{2}", m_Date.Day, m_Date.Month, m_Date.Year);
            lblStudentSum.Text = m_StudentSum.ToString();
            m_FromTime = fromTime;
            m_ToTime = toTime;
            m_TestPeriod = testPeriod;
            lblTestPeriod.Text = m_TestPeriod.ToString();
            lblTimeToTest.Text = String.Format("Từ {0}:{1} đến {2}:{3}", m_FromTime.Hours >= 10 ? m_FromTime.Hours.ToString() : "0" + m_FromTime.Hours.ToString(), m_FromTime.Minutes >= 10 ? m_FromTime.Minutes.ToString() : "0" + m_FromTime.Minutes.ToString(), m_ToTime.Hours >= 10 ? m_ToTime.Hours.ToString() : "0" + m_ToTime.Hours.ToString(), m_ToTime.Minutes >= 10 ? m_ToTime.Minutes.ToString() : "0" + m_ToTime.Minutes.ToString());
        }

        private void thiếtLậpThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformationSetup form = new InformationSetup(setClassInformation, m_Subject, m_Date, m_TestPeriod, m_StudentSum, m_FromTime, m_ToTime);
            form.ShowDialog();
        }

        private void gridViewClientList_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void gridViewClientList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && gridViewClientList.SelectedRows.Count == 1)
            {
                gridViewClientList.ContextMenuStrip = rowContextMenu;
            }
            else
            {
                gridViewClientList.ContextMenuStrip = null;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void ServerUI_SizeChanged(object sender, EventArgs e)
        {
            FixControlsSize(this.Width, this.Height);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imgServer_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_TextChanged(object sender, EventArgs e)
        {
        }

        private void startedTimer_Tick(object sender, EventArgs e)
        {
            m_clock.AddSecond();
            lblStartedTime.Text = m_clock.GetTimeText();
        }

        private void buổiThiMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Khởi tạo buổi thi mới sẽ xóa tất cả thông tin của buổi thi trước. Tạo buổi thi mới?","Xác nhận tạo buổi thi mới", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            ResetInformation();
        }

        public void ResetInformation()
        {
            socketControl.m_ServerSocketObject.clientItemList = new List<ClientItem>();
            clientData.Clear();
            gridViewClientList.DataSource = clientData;
            lblSaveFolder.Text = "Nhấn \"Chọn thư mục\" để xác định thư mục lưu bài làm";
            btnViewFolder.Enabled = false;
            isSelectedFolder = false;

            m_Subject = String.Empty;
            m_StudentSum = 0;
            lblTimeToTest.Text = NOT_IDENTIFIED;
            lblStudentSum.Text = NOT_IDENTIFIED;
            lblTestPeriod.Text = NOT_IDENTIFIED;
            lblTimeToTest.Text = NOT_IDENTIFIED;
            imgServer.Image = Properties.Resources.stopped;
            startedTimer.Enabled = false;
            if (firstRun)
            {
                firstRun = false;
            }
            else
            {
                InformationSetup form = new InformationSetup(setClassInformation, m_Subject, m_Date, m_TestPeriod, m_StudentSum, m_FromTime, m_ToTime);
                form.ShowDialog();
            }
        }
    }
}
