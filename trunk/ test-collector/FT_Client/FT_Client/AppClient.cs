using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClientSockets.Synchronous.UsingByteArray;
using System.IO;
using System.Net;
using System.Threading;

namespace FT_Client
{
    public partial class AppClient : Form
    {        
#region properties....
        public static string pathFolderToSaveSetting = Directory.GetCurrentDirectory();
        public static string fileNameToSaveSetting = "config.ini";
        public static string FullPathFileToSaveSetting = pathFolderToSaveSetting + @"\" + fileNameToSaveSetting;
        private static ReadWriteToFile rwSetting = new ReadWriteToFile();
        SynchronusClient_ByteArr objClient = new SynchronusClient_ByteArr("1","127.0.0.1",@"C:\");
        
        public static string idClient="";
        public static string nameStudent = "Khong Ten";
        public static string outputFolderZipFiles;
        public static string outputZipFiles = "";

        public static int portSend=8080, portReceive;
        public static string ipAddress, outPathDefault = @"C:\";
        string[] files;
        Ziplb ziptool = new Ziplb();
        bool isZipSuccess = false;
        int maxFileSize = 10240; //max zip file to send is 10000Kb ~10Mb
        Utilities_CLient uClient = new Utilities_CLient();
        public static string ipServer = "127.0.0.1";
        public static int formFlag = 0;
#endregion
#region Constructor....
        public AppClient()
        {
                       InitializeComponent();
                       objClient.FileSendCompleted += new SynchronusClient_ByteArr.FileSendCompletedDelegate(objClient_FileSendCompleted);
                       objClient.FileReceiveCompleted += new SynchronusClient_ByteArr.FileSendCompletedDelegate(objClient_FileReceiveCompleted);
        }
#endregion
#region Utilities function...
        public int checkNumBox(string nbox)
        {
            Int32 num = 1;
            try
            {
                num = Convert.ToInt32(nbox);
                if (num < 1 || num > 111)
                {
                    return 1;
                }
                else return num;
            }
            catch (System.Exception ex)
            {
                return num;
            }
        }
        //Check if the /zipfiles folder is existed
        public void CheckOuputZipFolder()
        {

            ConvertTVKoDau();

            outputFolderZipFiles = Directory.GetCurrentDirectory() + "\\zipfiles";
            outputZipFiles = outputFolderZipFiles + "\\" + idClient+"_"+nameStudent +".zip";
            if (!Directory.Exists(outputFolderZipFiles))
                try
                {
                    Directory.CreateDirectory(outputFolderZipFiles);
                }
                catch
                { 
                }
        }
        private static void ConvertTVKoDau()
        {
            ConvertTiengVietKoDau tv = new ConvertTiengVietKoDau();
            nameStudent = tv.Convert(nameStudent);
            idClient = tv.Convert(idClient);
        }   
        void objClient_FileReceiveCompleted()
        {
            MessageBox.Show("File receive done");
        }
        void objClient_FileSendCompleted()
        {
            MessageBox.Show("Gửi File thành công!!!", "Thông Báo");
        }
        public void FormatDateTimePicker(DateTimePicker dt)
        {
            dt.Format = DateTimePickerFormat.Custom;
            dt.CustomFormat = "dd/MM/yyyy";
        }
        public bool LoadConfig()
        {
            try
            {
                string[] config = rwSetting.ReadFromFile(FullPathFileToSaveSetting);
                string[] ipserver = config[0].Split('.');
                ipServer = ipserver[0] + "." + ipserver[1] + "." + ipserver[2] + "." + ipserver[3];
                portSend = Convert.ToInt32(config[1]);
                return true;
            }
            catch (System.Exception ex)
            {                
                return false;
            }           
        }
        public void SettingToSendServer(IPAddress ipad, int port) //delegate method between form 1 and form 2
        {
            objClient.SetIpAddress(ipad.ToString());
            objClient.SetSendPort(port);
            string[] setting = new string[2];
            setting[0] = ipad.ToString();
            setting[1] = port.ToString();
            SaveSetting(FullPathFileToSaveSetting, setting);
            MessageBox.Show("Thiết lập thành công Port gửi :" + port + " - Với Ip Server :" + ipad.ToString(), "Thông Báo!");
        }
        public void SetFlagMainForm(int temp) //delegate method to set flag (flag: 1-> ConnectSetting Form is ready, 2-> not)
        {
            formFlag = temp;
        }
        public string getNameClient()
        {
            string ClientName="";
            ClientName = System.Environment.MachineName;
            return ClientName;
        }
        public void SaveSetting(string pathfile,string[] a)
        {      
            rwSetting.WriteToFile(pathfile, a);
        }
        public bool checkIpServer(string s1,string s2, string s3,string s4)
        {
            if(s1==null || s1=="" || s2==null || s2=="" || s3==null || s3=="" || s4==null || s4=="" )
            {
                return false;
            }
            return true;
        }
        public bool checkPortNumber(string portnumber)
        {
            if(portnumber==null || portnumber=="")
            {
                return false;
            }
            return true;
        }                   
        public int CheckInfoStudent()
        {
            if (txtMaSV.Text == "") //masv is not set.
            {
                MessageBox.Show("Vui lòng điền Mã sinh viên!");
                label1.Text = "Vui lòng điền MaSV trước khi GỬI FILE!";
                txtMaSV.Focus();
                return 1;
            }

            idClient = txtMaSV.Text;
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Vui lòng điền Họ Tên Sinh Viên");
                label1.Text = "Vui lòng điền Họ Tên Sinh Viên trước khi GỬI FILE!";
                txtHoTen.Focus();
                return 2;
            }
            nameStudent = txtHoTen.Text;
            return 0;
        }
        private int ZipFilesToSend()
        {
            if (lbFiles.Items.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn files trước khi Gửi!");
                return 1;
            }
            else
            {
                if(CheckInfoStudent()!=0) return 2;
                files = new string[lbFiles.Items.Count];
                for (int index = 0; index < lbFiles.Items.Count; index++)
                {
                    files[index] = lbFiles.Items[index].ToString();
                }               
                CheckOuputZipFolder();
                label1.Text = "Đang nén file trước khi gửi! Vui lòng đợi giây lát...";
                label1.Refresh();
                isZipSuccess = ziptool.Zip(outputZipFiles, files);
                if (isZipSuccess)
                {
                    label1.Text = "Nén FILE thành công! File: " + Path.GetFileName(outputZipFiles) + " sẵn sàng để Gửi!";
                    label1.Refresh();
                    lbFileName.Text = Path.GetFileName(outputZipFiles);
                    return 0;
                }
                else
                {
                    label1.Text = "Nén FILE thất bại!";
                    label1.Refresh();
                    return 3;
                }
            }
        }
        private int CheckBirthday()
        {
            if (bdayStudent.Value.Date.Year > (DateTime.Now.Year - 1))
            {
                MessageBox.Show("Năm sinh không được lớn hơn năm :" + (DateTime.Now.Year - 1));
                bdayStudent.Focus();
                return 0;
            }
            return 1;
        }
        private void ChangeStatusBackImageConnectServer()
        {
            if (objClient.checkConnectToServer())
            {
                button3.BackgroundImage = Properties.Resources.connect2;
            }
            else
            {
                button3.BackgroundImage = Properties.Resources.connect;
                label1.Text = "Đã ngắt kết nối";
            }
           
        }
        private void DeleteItemFile()
        {
            int indexitem = lbFiles.SelectedIndex;
            if (indexitem >= 0 && indexitem <= lbFiles.Items.Count)
                lbFiles.Items.RemoveAt(indexitem);
            if (indexitem == lbFiles.Items.Count)
            {
                indexitem = 0;
            }

            if (lbFiles.Items.Count > 0) lbFiles.SelectedIndex = indexitem;
        }
        #endregion
#region  Event function...
        private void Form1_Load(object sender, EventArgs e)
        {

            FormatDateTimePicker(bdayStudent);
            LoadConfig();
            objClient.SetIpAddress(ipServer);
            objClient.SetSendPort(portSend);

            this.AllowDrop = true;
            this.DragEnter += Form1_DragEnter;
            this.DragDrop += Form1_DragDrop;            
        }      
        private void button3_Click(object sender, EventArgs e)
        {
            string birthday = bdayStudent.Value.Date.ToShortDateString();
            if (CheckInfoStudent() > 0)
            {
                return;
            }
            if (CheckBirthday() == 0)
            {
                return;
            }
            string clientInfo = "";
            ConvertTVKoDau();

            clientInfo = idClient + "_" + nameStudent + "_" + birthday + "_" + getNameClient();

            label1.Text = "Đang kết nối đến Server. Vui lòng đợi giây lát!";
            label1.Refresh();
            try
            {
                label1.Text = objClient.ConnectToServer(clientInfo);
                ChangeStatusBackImageConnectServer();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Vui lòng kiểm tra lại các thông số kết nối!", "Lỗi!!!");
                return;
            }

        }
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            Utilities_CLient uCLient = new Utilities_CLient();
            lbFiles.Items.Clear();
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = (string[])(e.Data.GetData(DataFormats.FileDrop));
                foreach (string fileLoc in filePaths)
                {
                    // Code to read the contents of the text file
                    if (File.Exists(fileLoc))
                    {
                        if (uCLient.checkFileType(fileLoc))
                            lbFiles.Items.Add(fileLoc);
                    }
                }
            }
        }        
        private void deleteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItemFile();
        }      

        private void deleteAllFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbFiles.Items.Clear();
        }

        private void zipFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZipFilesToSend();
        }

        private void txtSendPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtIp1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtIp2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtIp3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtIp4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        
        private void ConnectSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formFlag == 0)
            {
                ConnectSetting settingform = new ConnectSetting();               
                settingform.MySettingServer = new ConnectSetting.SettingServer(SettingToSendServer);
                settingform.MySetFlagForm = new ConnectSetting.SetFlagForm(SetFlagMainForm);
                settingform.Show();
                formFlag = 1;
            }
            else
            {
                return;
            }
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }     

        private void bdayStudent_Leave(object sender, EventArgs e)
        {
            CheckBirthday();
        }      
        private void button2_Click(object sender, EventArgs e)
        {
            /*if(!checkPortNumber(txtSendPort.Text))
            {
                MessageBox.Show("Vui Lòng điền đầy đủ thông tin Port!");
                txtSendPort.Focus();
                return;
            }
            if (!checkIpServer(txtIp1.Text, txtIp2.Text, txtIp3.Text, txtIp4.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin IP để kết nối đến Server!");
                txtIp1.Focus();
                return;
            }
            try
            {
                portSend = Convert.ToInt32(txtSendPort.Text);
                string ipad = txtIp1.Text+"."+txtIp2.Text+"."+ txtIp3.Text +"."+ txtIp4.Text;               
                objClient.SettingClient("2", ipad, portSend, portReceive, outPathDefault);
                string[] setting=new string[2];
                setting[0] = ipad;
                setting[1] = portSend.ToString();

                SaveSetting(FullPathFileToSaveSetting, setting);

                label1.Text = "Setting Successfully!";
                MessageBox.Show("Thiết lập thành công!");
                
            }
            catch (System.Exception ex)
            {
            	
            }
             * */
        }
        private void btnReceive_Click(object sender, EventArgs e)
        {
        }
        private void btFileToSend_Click(object sender, EventArgs e)
        {
            Utilities_CLient uClient = new Utilities_CLient();
            lbFiles.Items.Clear();
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = true;
            if (op.ShowDialog() == DialogResult.OK)
            {
                //lbFileName.Text = op.FileName;
                foreach (string file in op.FileNames)
                {
                    if (uClient.checkFileType(file))
                        lbFiles.Items.Add(file);
                }
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (objClient.checkConnectToServer() == false)
            {
                MessageBox.Show("Vui lòng Kết Nối Server trước khi Gửi FILE !!!");
                return;
            }
            if (ZipFilesToSend() != 0)
            {
                return;
            }
            //             if(CheckInfoStudent()>0)
            //             {
            //                 return;
            //             }           
            if (outputZipFiles == "")
            {
                MessageBox.Show("Vui lòng Zip Files trước khi gửi!");
                return;
            }
            if (!File.Exists(outputZipFiles))
            {
                MessageBox.Show("File không tồn tại!");
                return;
            }

            if (!uClient.CheckFileSize(outputZipFiles, maxFileSize))
            {
                MessageBox.Show("Kích thước FILE Zip không được lớn hơn : " + maxFileSize + " Kb", "Cảnh báo!");
                return;
            }           
            objClient.SetFileName(outputZipFiles);
            objClient.SendFileToServer("", "");
            label1.Text = objClient.Status;
            Thread.Sleep(1000);
            ChangeStatusBackImageConnectServer();
            this.Refresh();

        }
        public void CleanAllInfo()
        {
            if (MessageBox.Show("Bạn muốn xóa thông tin của mình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtMaSV.Text = "";
                txtHoTen.Text = "";
                lbFiles.Items.Clear();
            }
            this.Refresh();
        }
        private void addFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = true;
            if (op.ShowDialog() == DialogResult.OK)
            {
                //lbFileName.Text = op.FileName;
                foreach (string file in op.FileNames)
                {
                    if (uClient.checkFileType(file))
                        lbFiles.Items.Add(file);
                }
            }
        }
        private void lbFiles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteItemFile();
            }
        }
        #endregion                         

        private void btReset_Click(object sender, EventArgs e)
        {
            CleanAllInfo();
        }
    }
}