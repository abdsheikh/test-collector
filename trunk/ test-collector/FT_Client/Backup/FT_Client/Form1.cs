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
    public partial class Form1 : Form
    {
        SynchronusClient_ByteArr objClient = new SynchronusClient_ByteArr("1","127.0.0.1",@"C:\Users\THIENSUHACK\Desktop\rc2");
        public static string idClient="08242454";
        public static string outputFolderZipFiles = @"C:\zipfiles\";
        public static string ouputZipFiles = outputFolderZipFiles + idClient + ".zip";

        public static int portSend, portReceive;
        public static string ipAddress, outPathDefault = @"C:\";

        string[] files;
        Ziplb ziptool = new Ziplb();
        bool isZipSuccess = false;
        public Form1()
        {
                       InitializeComponent();
            objClient.FileSendCompleted += new SynchronusClient_ByteArr.FileSendCompletedDelegate(objClient_FileSendCompleted);
            objClient.FileReceiveCompleted += new SynchronusClient_ByteArr.FileSendCompletedDelegate(objClient_FileReceiveCompleted);
        }

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
            txtRecievedPort.Text = "8081";
            txtSendPort.Text = "8080";
            lbOutPutPathFolder.Text = @"C:\";

            this.AllowDrop = true;
            this.DragEnter += Form1_DragEnter;
            this.DragDrop += Form1_DragDrop;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (isZipSuccess)
            {
                txtFileName.Text = ouputZipFiles;
            }            
            if (txtFileName.Text == "") return;
            if(!File.Exists(txtFileName.Text))
            {
                MessageBox.Show("File ko tồn tại!");
                return;
            }
            if (objClient.checkConnectToServer() == false)
            {
                MessageBox.Show("Please! Connect To Server before sending file!!!");
                return;
            }
            objClient.SetFileName(txtFileName.Text);
            objClient.SendFileToServer("", "");
            label1.Text=objClient.Status;           
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            
            objClient.ReceiveFileFromServer(txtFileName.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog()!=DialogResult.OK)
            {
                MessageBox.Show("Your Cancel Setting Oup put file! System'll use default!");
            }
            else
            {
                lbOutPutPathFolder.Text = fbd.SelectedPath;
            }
        }

        private void btFileToSend_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = true;
            if(op.ShowDialog()==DialogResult.OK)
            {
                //txtFileName.Text = op.FileName;
                foreach (string file in op.FileNames)
                {
                    lbFiles.Items.Add(file);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = objClient.ConnectToServer();
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
                portReceive = Convert.ToInt32(txtRecievedPort.Text);
                string ipad = txtIp1.Text+"."+txtIp2.Text+"."+ txtIp3.Text +"."+ txtIp4.Text;               
                //MessageBox.Show(ipad);
                outPathDefault = lbOutPutPathFolder.Text;
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
            if(lbFiles.Items.Count<=0)
            {
                MessageBox.Show("Please! Select Files before ZipFiles!");
                return;
            }
            else
            {
                files = new string[lbFiles.Items.Count];
                for (int index=0; index < lbFiles.Items.Count; index++)
                {
                    files[index] = lbFiles.Items[index].ToString();
                }
                isZipSuccess=ziptool.Zip(ouputZipFiles, files);
                if (isZipSuccess)
                {
                    label1.Text = "Zip Files is Successfull! File: " + ouputZipFiles + " is Ready to send!";
                    txtFileName.Text = ouputZipFiles;
                }
                else
                {
                    label1.Text = "Zip Files is Fail !";
                }
            }            
        }
        
    }
}