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
        //public static Student sinhvien;

        SynchronusClient_ByteArr objClient = new SynchronusClient_ByteArr("1","127.0.0.1",@"C:\Users\THIENSUHACK\Desktop\rc2");
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
            //ConvertTiengVietKoDau tv = new ConvertTiengVietKoDau();
            //nameStudent = tv.Convert(nameStudent);
            //idClient = tv.Convert(idClient);
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
            portSend = 8080;
            portReceive = 8081;
           // txtRecievedPort.Text = "8081";
            txtSendPort.Text = "8080";
           // lbOutPutPathFolder.Text = @"C:\";

            this.AllowDrop = true;
            this.DragEnter += Form1_DragEnter;
            this.DragDrop += Form1_DragDrop;
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                portSend = Convert.ToInt32(txtSendPort.Text);
                //portReceive = Convert.ToInt32("");
                string ipad = txtIp1.Text+"."+txtIp2.Text+"."+ txtIp3.Text +"."+ txtIp4.Text;               
                //MessageBox.Show(ipad);
              //  outPathDefault = lbOutPutPathFolder.Text;
                objClient.SettingClient("2", ipad, portSend, portReceive, outPathDefault);
                label1.Text = "Setting Successfully!";
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
        
    }
}