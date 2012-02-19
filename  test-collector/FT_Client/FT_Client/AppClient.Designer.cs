namespace FT_Client
{
    partial class AppClient
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
            this.components = new System.ComponentModel.Container();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbClientSetting = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btFileToSend = new System.Windows.Forms.Button();
            this.btZipFiles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.txtIp4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtIp3 = new System.Windows.Forms.TextBox();
            this.txtIp2 = new System.Windows.Forms.TextBox();
            this.txtIp1 = new System.Windows.Forms.TextBox();
            this.txtSendPort = new System.Windows.Forms.TextBox();
            this.lbIpAdress = new System.Windows.Forms.Label();
            this.lbSendPort = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabInfoSv = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zipFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbClientSetting.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabInfoSv.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(524, 34);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(97, 37);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send File";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(201, 294);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(261, 20);
            this.txtFileName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // gbClientSetting
            // 
            this.gbClientSetting.Controls.Add(this.label9);
            this.gbClientSetting.Controls.Add(this.btFileToSend);
            this.gbClientSetting.Controls.Add(this.btZipFiles);
            this.gbClientSetting.Controls.Add(this.label2);
            this.gbClientSetting.Controls.Add(this.lbFiles);
            this.gbClientSetting.Controls.Add(this.txtFileName);
            this.gbClientSetting.Location = new System.Drawing.Point(351, 65);
            this.gbClientSetting.Name = "gbClientSetting";
            this.gbClientSetting.Size = new System.Drawing.Size(651, 356);
            this.gbClientSetting.TabIndex = 4;
            this.gbClientSetting.TabStop = false;
            this.gbClientSetting.Text = "Client Setting";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Hoặc>>";
            // 
            // btFileToSend
            // 
            this.btFileToSend.Location = new System.Drawing.Point(70, 285);
            this.btFileToSend.Name = "btFileToSend";
            this.btFileToSend.Size = new System.Drawing.Size(95, 36);
            this.btFileToSend.TabIndex = 5;
            this.btFileToSend.Text = "Click vào đây để chọn";
            this.btFileToSend.UseVisualStyleBackColor = true;
            this.btFileToSend.Click += new System.EventHandler(this.btFileToSend_Click);
            // 
            // btZipFiles
            // 
            this.btZipFiles.Location = new System.Drawing.Point(556, 294);
            this.btZipFiles.Name = "btZipFiles";
            this.btZipFiles.Size = new System.Drawing.Size(84, 32);
            this.btZipFiles.TabIndex = 15;
            this.btZipFiles.Text = "ZipFiles";
            this.btZipFiles.UseVisualStyleBackColor = true;
            this.btZipFiles.Click += new System.EventHandler(this.btZipFiles_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kéo thả các file vào khu vực này!";
            // 
            // lbFiles
            // 
            this.lbFiles.ContextMenuStrip = this.contextMenuStrip1;
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.Location = new System.Drawing.Point(17, 42);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(623, 225);
            this.lbFiles.TabIndex = 13;
            // 
            // txtIp4
            // 
            this.txtIp4.Location = new System.Drawing.Point(247, 105);
            this.txtIp4.Name = "txtIp4";
            this.txtIp4.Size = new System.Drawing.Size(39, 20);
            this.txtIp4.TabIndex = 12;
            this.txtIp4.Text = "1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Thiết Lập>>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtIp3
            // 
            this.txtIp3.Location = new System.Drawing.Point(202, 105);
            this.txtIp3.Name = "txtIp3";
            this.txtIp3.Size = new System.Drawing.Size(39, 20);
            this.txtIp3.TabIndex = 8;
            this.txtIp3.Text = "0";
            // 
            // txtIp2
            // 
            this.txtIp2.Location = new System.Drawing.Point(153, 105);
            this.txtIp2.Name = "txtIp2";
            this.txtIp2.Size = new System.Drawing.Size(43, 20);
            this.txtIp2.TabIndex = 7;
            this.txtIp2.Text = "0";
            // 
            // txtIp1
            // 
            this.txtIp1.Location = new System.Drawing.Point(101, 105);
            this.txtIp1.Name = "txtIp1";
            this.txtIp1.Size = new System.Drawing.Size(45, 20);
            this.txtIp1.TabIndex = 6;
            this.txtIp1.Text = "127";
            // 
            // txtSendPort
            // 
            this.txtSendPort.Location = new System.Drawing.Point(118, 33);
            this.txtSendPort.Name = "txtSendPort";
            this.txtSendPort.Size = new System.Drawing.Size(153, 20);
            this.txtSendPort.TabIndex = 4;
            this.txtSendPort.Text = "8080";
            // 
            // lbIpAdress
            // 
            this.lbIpAdress.AutoSize = true;
            this.lbIpAdress.Location = new System.Drawing.Point(6, 108);
            this.lbIpAdress.Name = "lbIpAdress";
            this.lbIpAdress.Size = new System.Drawing.Size(89, 13);
            this.lbIpAdress.TabIndex = 2;
            this.lbIpAdress.Text = "Server IP Adress:";
            // 
            // lbSendPort
            // 
            this.lbSendPort.AutoSize = true;
            this.lbSendPort.Location = new System.Drawing.Point(25, 36);
            this.lbSendPort.Name = "lbSendPort";
            this.lbSendPort.Size = new System.Drawing.Size(57, 13);
            this.lbSendPort.TabIndex = 0;
            this.lbSendPort.Text = "Send Port:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(128, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 39);
            this.button3.TabIndex = 6;
            this.button3.Text = "Connect To Server";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(351, 427);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 163);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gửi File";
            // 
            // tabInfoSv
            // 
            this.tabInfoSv.Controls.Add(this.tabPage1);
            this.tabInfoSv.Controls.Add(this.tabPage2);
            this.tabInfoSv.Location = new System.Drawing.Point(12, 43);
            this.tabInfoSv.Name = "tabInfoSv";
            this.tabInfoSv.SelectedIndex = 0;
            this.tabInfoSv.Size = new System.Drawing.Size(333, 531);
            this.tabInfoSv.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(325, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin Sinh Viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtNgaySinh);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtHoTen);
            this.groupBox3.Controls.Add(this.txtMaSV);
            this.groupBox3.Location = new System.Drawing.Point(6, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 284);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày Sinh:";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(83, 103);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(178, 20);
            this.txtNgaySinh.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Họ Tên: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "MSSV:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(83, 57);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(178, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(83, 19);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(178, 20);
            this.txtMaSV.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(325, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cài đặt kết nối";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Vui  lòng kiểm tra các thông số kết nối và thử lại!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nếu không thể kết nối đến Server! ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbSendPort);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtIp4);
            this.groupBox2.Controls.Add(this.lbIpAdress);
            this.groupBox2.Controls.Add(this.txtSendPort);
            this.groupBox2.Controls.Add(this.txtIp1);
            this.groupBox2.Controls.Add(this.txtIp2);
            this.groupBox2.Controls.Add(this.txtIp3);
            this.groupBox2.Location = new System.Drawing.Point(14, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 301);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tHoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // tHoátToolStripMenuItem
            // 
            this.tHoátToolStripMenuItem.Name = "tHoátToolStripMenuItem";
            this.tHoátToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.tHoátToolStripMenuItem.Text = "THoát";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zipFilesToolStripMenuItem,
            this.deleteAllFilesToolStripMenuItem,
            this.deleteFileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 70);
            // 
            // deleteFileToolStripMenuItem
            // 
            this.deleteFileToolStripMenuItem.Name = "deleteFileToolStripMenuItem";
            this.deleteFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteFileToolStripMenuItem.Text = "Delete file";
            this.deleteFileToolStripMenuItem.Click += new System.EventHandler(this.deleteFileToolStripMenuItem_Click);
            // 
            // deleteAllFilesToolStripMenuItem
            // 
            this.deleteAllFilesToolStripMenuItem.Name = "deleteAllFilesToolStripMenuItem";
            this.deleteAllFilesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteAllFilesToolStripMenuItem.Text = "Clear Box";
            this.deleteAllFilesToolStripMenuItem.Click += new System.EventHandler(this.deleteAllFilesToolStripMenuItem_Click);
            // 
            // zipFilesToolStripMenuItem
            // 
            this.zipFilesToolStripMenuItem.Name = "zipFilesToolStripMenuItem";
            this.zipFilesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zipFilesToolStripMenuItem.Text = "Zip Files";
            this.zipFilesToolStripMenuItem.Click += new System.EventHandler(this.zipFilesToolStripMenuItem_Click);
            // 
            // AppClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 589);
            this.Controls.Add(this.tabInfoSv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbClientSetting);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AppClient";
            this.Text = "Client Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbClientSetting.ResumeLayout(false);
            this.gbClientSetting.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabInfoSv.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbClientSetting;
        private System.Windows.Forms.Label lbSendPort;
        private System.Windows.Forms.Label lbIpAdress;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtIp3;
        private System.Windows.Forms.TextBox txtIp2;
        private System.Windows.Forms.TextBox txtIp1;
        private System.Windows.Forms.TextBox txtSendPort;
        private System.Windows.Forms.TextBox txtIp4;
        private System.Windows.Forms.Button btFileToSend;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.Button btZipFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabInfoSv;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tHoátToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zipFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFileToolStripMenuItem;
    }
}

