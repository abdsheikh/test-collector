namespace FT_Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSend = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbClientSetting = new System.Windows.Forms.GroupBox();
            this.txtIp4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbOutPutPathFolder = new System.Windows.Forms.Label();
            this.txtIp3 = new System.Windows.Forms.TextBox();
            this.txtIp2 = new System.Windows.Forms.TextBox();
            this.txtIp1 = new System.Windows.Forms.TextBox();
            this.txtRecievedPort = new System.Windows.Forms.TextBox();
            this.txtSendPort = new System.Windows.Forms.TextBox();
            this.lbOutPutPath = new System.Windows.Forms.Label();
            this.lbIpAdress = new System.Windows.Forms.Label();
            this.lbRecievedPort = new System.Windows.Forms.Label();
            this.lbSendPort = new System.Windows.Forms.Label();
            this.btFileToSend = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btZipFiles = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gbClientSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(204, 391);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(97, 37);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send File";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(328, 391);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(99, 39);
            this.btnReceive.TabIndex = 1;
            this.btnReceive.Text = "Receive File";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(217, 349);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(251, 20);
            this.txtFileName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // gbClientSetting
            // 
            this.gbClientSetting.Controls.Add(this.btZipFiles);
            this.gbClientSetting.Controls.Add(this.label2);
            this.gbClientSetting.Controls.Add(this.lbFiles);
            this.gbClientSetting.Controls.Add(this.txtIp4);
            this.gbClientSetting.Controls.Add(this.button2);
            this.gbClientSetting.Controls.Add(this.button1);
            this.gbClientSetting.Controls.Add(this.lbOutPutPathFolder);
            this.gbClientSetting.Controls.Add(this.txtIp3);
            this.gbClientSetting.Controls.Add(this.txtIp2);
            this.gbClientSetting.Controls.Add(this.txtIp1);
            this.gbClientSetting.Controls.Add(this.txtRecievedPort);
            this.gbClientSetting.Controls.Add(this.txtSendPort);
            this.gbClientSetting.Controls.Add(this.lbOutPutPath);
            this.gbClientSetting.Controls.Add(this.lbIpAdress);
            this.gbClientSetting.Controls.Add(this.lbRecievedPort);
            this.gbClientSetting.Controls.Add(this.lbSendPort);
            this.gbClientSetting.Location = new System.Drawing.Point(12, 12);
            this.gbClientSetting.Name = "gbClientSetting";
            this.gbClientSetting.Size = new System.Drawing.Size(741, 327);
            this.gbClientSetting.TabIndex = 4;
            this.gbClientSetting.TabStop = false;
            this.gbClientSetting.Text = "Client Setting";
            // 
            // txtIp4
            // 
            this.txtIp4.Location = new System.Drawing.Point(294, 99);
            this.txtIp4.Name = "txtIp4";
            this.txtIp4.Size = new System.Drawing.Size(48, 20);
            this.txtIp4.TabIndex = 12;
            this.txtIp4.Text = "1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 43);
            this.button2.TabIndex = 11;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Select Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbOutPutPathFolder
            // 
            this.lbOutPutPathFolder.AutoSize = true;
            this.lbOutPutPathFolder.Location = new System.Drawing.Point(361, 26);
            this.lbOutPutPathFolder.Name = "lbOutPutPathFolder";
            this.lbOutPutPathFolder.Size = new System.Drawing.Size(22, 13);
            this.lbOutPutPathFolder.TabIndex = 9;
            this.lbOutPutPathFolder.Text = "C:\\";
            // 
            // txtIp3
            // 
            this.txtIp3.Location = new System.Drawing.Point(240, 99);
            this.txtIp3.Name = "txtIp3";
            this.txtIp3.Size = new System.Drawing.Size(48, 20);
            this.txtIp3.TabIndex = 8;
            this.txtIp3.Text = "0";
            // 
            // txtIp2
            // 
            this.txtIp2.Location = new System.Drawing.Point(172, 100);
            this.txtIp2.Name = "txtIp2";
            this.txtIp2.Size = new System.Drawing.Size(58, 20);
            this.txtIp2.TabIndex = 7;
            this.txtIp2.Text = "0";
            // 
            // txtIp1
            // 
            this.txtIp1.Location = new System.Drawing.Point(110, 101);
            this.txtIp1.Name = "txtIp1";
            this.txtIp1.Size = new System.Drawing.Size(55, 20);
            this.txtIp1.TabIndex = 6;
            this.txtIp1.Text = "127";
            // 
            // txtRecievedPort
            // 
            this.txtRecievedPort.Location = new System.Drawing.Point(116, 57);
            this.txtRecievedPort.Name = "txtRecievedPort";
            this.txtRecievedPort.Size = new System.Drawing.Size(100, 20);
            this.txtRecievedPort.TabIndex = 5;
            this.txtRecievedPort.Text = "8081";
            // 
            // txtSendPort
            // 
            this.txtSendPort.Location = new System.Drawing.Point(116, 25);
            this.txtSendPort.Name = "txtSendPort";
            this.txtSendPort.Size = new System.Drawing.Size(100, 20);
            this.txtSendPort.TabIndex = 4;
            this.txtSendPort.Text = "8080";
            // 
            // lbOutPutPath
            // 
            this.lbOutPutPath.AutoSize = true;
            this.lbOutPutPath.Location = new System.Drawing.Point(271, 25);
            this.lbOutPutPath.Name = "lbOutPutPath";
            this.lbOutPutPath.Size = new System.Drawing.Size(71, 13);
            this.lbOutPutPath.TabIndex = 3;
            this.lbOutPutPath.Text = "Out Put Path:";
            // 
            // lbIpAdress
            // 
            this.lbIpAdress.AutoSize = true;
            this.lbIpAdress.Location = new System.Drawing.Point(15, 103);
            this.lbIpAdress.Name = "lbIpAdress";
            this.lbIpAdress.Size = new System.Drawing.Size(89, 13);
            this.lbIpAdress.TabIndex = 2;
            this.lbIpAdress.Text = "Server IP Adress:";
            // 
            // lbRecievedPort
            // 
            this.lbRecievedPort.AutoSize = true;
            this.lbRecievedPort.Location = new System.Drawing.Point(19, 60);
            this.lbRecievedPort.Name = "lbRecievedPort";
            this.lbRecievedPort.Size = new System.Drawing.Size(78, 13);
            this.lbRecievedPort.TabIndex = 1;
            this.lbRecievedPort.Text = "Recieved Port:";
            // 
            // lbSendPort
            // 
            this.lbSendPort.AutoSize = true;
            this.lbSendPort.Location = new System.Drawing.Point(19, 25);
            this.lbSendPort.Name = "lbSendPort";
            this.lbSendPort.Size = new System.Drawing.Size(57, 13);
            this.lbSendPort.TabIndex = 0;
            this.lbSendPort.Text = "Send Port:";
            // 
            // btFileToSend
            // 
            this.btFileToSend.Location = new System.Drawing.Point(50, 345);
            this.btFileToSend.Name = "btFileToSend";
            this.btFileToSend.Size = new System.Drawing.Size(121, 26);
            this.btFileToSend.TabIndex = 5;
            this.btFileToSend.Text = "Select File To Send";
            this.btFileToSend.UseVisualStyleBackColor = true;
            this.btFileToSend.Click += new System.EventHandler(this.btFileToSend_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(50, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 39);
            this.button3.TabIndex = 6;
            this.button3.Text = "Connect To Server";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbFiles
            // 
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.Location = new System.Drawing.Point(326, 148);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(398, 121);
            this.lbFiles.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Drag and Drop file to here!";
            // 
            // btZipFiles
            // 
            this.btZipFiles.Location = new System.Drawing.Point(588, 284);
            this.btZipFiles.Name = "btZipFiles";
            this.btZipFiles.Size = new System.Drawing.Size(84, 32);
            this.btZipFiles.TabIndex = 15;
            this.btZipFiles.Text = "ZipFiles";
            this.btZipFiles.UseVisualStyleBackColor = true;
            this.btZipFiles.Click += new System.EventHandler(this.btZipFiles_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 484);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btFileToSend);
            this.Controls.Add(this.gbClientSetting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.btnSend);
            this.Name = "Form1";
            this.Text = "UiTClient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbClientSetting.ResumeLayout(false);
            this.gbClientSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbClientSetting;
        private System.Windows.Forms.Label lbRecievedPort;
        private System.Windows.Forms.Label lbSendPort;
        private System.Windows.Forms.Label lbIpAdress;
        private System.Windows.Forms.Label lbOutPutPath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbOutPutPathFolder;
        private System.Windows.Forms.TextBox txtIp3;
        private System.Windows.Forms.TextBox txtIp2;
        private System.Windows.Forms.TextBox txtIp1;
        private System.Windows.Forms.TextBox txtRecievedPort;
        private System.Windows.Forms.TextBox txtSendPort;
        private System.Windows.Forms.TextBox txtIp4;
        private System.Windows.Forms.Button btFileToSend;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.Button btZipFiles;
        private System.Windows.Forms.Label label3;
    }
}

