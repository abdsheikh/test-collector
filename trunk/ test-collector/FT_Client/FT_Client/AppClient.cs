using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClientSockets.Synchronous.UsingByteArray;
using System.IO;

namespace FT_Client
{
    public partial class AppClient : Form
    {
        //
        public static string pathFolderToSaveSetting = Directory.GetCurrentDirectory();
        public static string fileNameToSaveSetting = "config.ini";
        public static string FullPathFileToSaveSetting = pathFolderToSaveSetting + @"\" + fileNameToSaveSetting;
        private static ReadWriteToFile rwSetting = new ReadWriteToFile();
        //
        //public static Student sinhvien;
        SynchronusClient_ByteArr objClient = new SynchronusClient_ByteArr("1","127.0.0.1",@"C:\");
        
        public static string idClient="";
        public static string nameStudent = "Khong Ten";
        public static string outputFolderZipFiles;
        public static string outputZipFiles = "";

        public static int portSend, portReceive;
        public static string ipAddress, outPathDefault = @"C:\";

        string[] files;
        Ziplb ziptool = new Ziplb();
        bool isZipSuccess = false;
        public AppClient()
        {
                       InitializeComponent();
                       objClient.FileSendCompleted += new SynchronusClient_ByteArr.FileSendCompletedDelegate(objClient_FileSendCompleted);
                       objClient.FileReceiveCompleted += new SynchronusClient_ByteArr.FileSendCompletedDelegate(objClient_FileReceiveCompleted);
        }
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
            int lannop = checkNumBox(numBox.Value.ToString());

            ConvertTVKoDau();

            outputFolderZipFiles = Directory.GetCurrentDirectory() + "\\zipfiles";
            outputZipFiles = outputFolderZipFiles + "\\" + idClient+"_"+nameStudent +"_"+"So"+lannop+ ".zip";
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
        //check info of student
        
        void objClient_FileReceiveCompleted()
        {
            MessageBox.Show("File receive done");
        }

        void objClient_FileSendCompleted()
        {
            MessageBox.Show("File send done!!!Socket'll be Closed! Please, Connect to server again to send file");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadConfig();
            portSend = Convert.ToInt32(txtSendPort.Text);
            portReceive = 8081;
            //txtSendPort.Text = "8080";
            string ipserver = txtIp1.Text + "." + txtIp2.Text + "." + txtIp3.Text + "." + txtIp4.Text;
            objClient.SetIpAddress(ipserver);
            objClient.SetSendPort(portSend);

            this.AllowDrop = true;
            this.DragEnter += Form1_DragEnter;
            this.DragDrop += Form1_DragDrop;
        }
        public bool LoadConfig()
        {
            try
            {
                string[] config = rwSetting.ReadFromFile(FullPathFileToSaveSetting);
                string[] ipserver = config[0].Split('.');
                txtIp1.Text = ipserver[0];
                txtIp2.Text = ipserver[1];
                txtIp3.Text = ipserver[2];
                txtIp4.Text = ipserver[3];
                txtSendPort.Text = config[1];
                return true;
            }
            catch (System.Exception ex)
            {
                txtIp1.Text = "127";
                txtIp2.Text = "0";
                txtIp3.Text = "0";
                txtIp4.Text = "0";
                txtSendPort.Text = "8080";
                return false;
            }
            

        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if(CheckInfoStudent()>0)
            {
                return;
            }

            if (isZipSuccess)
            {
                lbFileName.Text = outputZipFiles;
            }
            if (outputZipFiles == "")
            {
                MessageBox.Show("Vui lòng Zip Files trước khi gửi!");
                return;
            }
            if(!File.Exists(lbFileName.Text))
            {
                MessageBox.Show("File ko tồn tại!");
                return;
            }
            if (objClient.checkConnectToServer() == false)
            {
                MessageBox.Show("Please! Connect To Server before sending file!!!");
                return;
            }
            objClient.SetFileName(lbFileName.Text);
            objClient.SendFileToServer("", "");
            label1.Text=objClient.Status;           
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            
           // objClient.ReceiveFileFromServer(lbFileName.Text);

        }        
        private void btFileToSend_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = true;
            if(op.ShowDialog()==DialogResult.OK)
            {
                //lbFileName.Text = op.FileName;
                foreach (string file in op.FileNames)
                {
                    lbFiles.Items.Add(file);
                }
            }
        }
        public string getNameClient()
        {
            string ClientName="";
            ClientName = System.Environment.MachineName;
            return ClientName;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (CheckInfoStudent() >0)
            {
                return;
            }
            string clientInfo = "";
            ConvertTVKoDau();
            clientInfo = idClient + "_" + nameStudent + "_" + getNameClient();
            try
            {
                label1.Text = objClient.ConnectToServer(clientInfo);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Your Setting NOT OK!");                
            }
            
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
        private void button2_Click(object sender, EventArgs e)
        {
            if(!checkPortNumber(txtSendPort.Text))
            {
                MessageBox.Show("Vui Lòng điền đầy đủ thông tin Port!");
                txtSendPort.Focus();
                return;
            }
            if(!checkIpServer(txtIp1.Text,txtIp2.Text,txtIp3.Text,txtIp4.Text))
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
            lbFiles.Items.Clear();
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = (string[])(e.Data.GetData(DataFormats.FileDrop));
                foreach (string fileLoc in filePaths)
                {
                    // Code to read the contents of the text file
                    if (File.Exists(fileLoc))
                    {
                        lbFiles.Items.Add(fileLoc);
                    }
                }
            }
        }

        private void btZipFiles_Click(object sender, EventArgs e)
        {
            ZipFilesToSend(); 
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
        private void ZipFilesToSend()
        {
            if (lbFiles.Items.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn files trước khi sử dụng chức năng ZipFiles!");
                return;
            }
            else
            {
                CheckInfoStudent();

                files = new string[lbFiles.Items.Count];
                for (int index = 0; index < lbFiles.Items.Count; index++)
                {
                    files[index] = lbFiles.Items[index].ToString();
                }               
                CheckOuputZipFolder();
                isZipSuccess = ziptool.Zip(outputZipFiles, files);
                if (isZipSuccess)
                {
                    label1.Text = "Zip Files is Successfull! File: " + outputZipFiles + " is Ready to send!";
                    lbFileName.Text = outputZipFiles;
                }
                else
                {
                    label1.Text = "Zip Files is Fail !";
                }
            }
        }

        private void deleteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int indexitem = lbFiles.SelectedIndex;
            if(indexitem>0&&indexitem<=lbFiles.Items.Count)
            lbFiles.Items.RemoveAt(lbFiles.SelectedIndex);
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
        
    }
}