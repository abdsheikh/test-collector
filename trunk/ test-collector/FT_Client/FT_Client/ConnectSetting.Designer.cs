namespace FT_Client
{
    partial class ConnectSetting
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbSendPort = new System.Windows.Forms.Label();
            this.btSetting = new System.Windows.Forms.Button();
            this.txtIp4 = new System.Windows.Forms.TextBox();
            this.lbIpAdress = new System.Windows.Forms.Label();
            this.txtSendPort = new System.Windows.Forms.TextBox();
            this.txtIp1 = new System.Windows.Forms.TextBox();
            this.txtIp2 = new System.Windows.Forms.TextBox();
            this.txtIp3 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clStt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTenMay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clIpAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btFindIpLan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSettingInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbSendPort);
            this.groupBox2.Controls.Add(this.btSetting);
            this.groupBox2.Controls.Add(this.txtIp4);
            this.groupBox2.Controls.Add(this.lbIpAdress);
            this.groupBox2.Controls.Add(this.txtSendPort);
            this.groupBox2.Controls.Add(this.txtIp1);
            this.groupBox2.Controls.Add(this.txtIp2);
            this.groupBox2.Controls.Add(this.txtIp3);
            this.groupBox2.Location = new System.Drawing.Point(132, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 186);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CÀI ĐẶT THÔNG SỐ";
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
            // btSetting
            // 
            this.btSetting.Location = new System.Drawing.Point(320, 128);
            this.btSetting.Name = "btSetting";
            this.btSetting.Size = new System.Drawing.Size(89, 32);
            this.btSetting.TabIndex = 11;
            this.btSetting.Text = "Thiết Lập>>";
            this.btSetting.UseVisualStyleBackColor = true;
            this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
            // 
            // txtIp4
            // 
            this.txtIp4.Location = new System.Drawing.Point(251, 80);
            this.txtIp4.MaxLength = 3;
            this.txtIp4.Name = "txtIp4";
            this.txtIp4.Size = new System.Drawing.Size(39, 20);
            this.txtIp4.TabIndex = 9;
            this.txtIp4.Text = "1";
            this.txtIp4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIp4_KeyPress);
            // 
            // lbIpAdress
            // 
            this.lbIpAdress.AutoSize = true;
            this.lbIpAdress.Location = new System.Drawing.Point(10, 83);
            this.lbIpAdress.Name = "lbIpAdress";
            this.lbIpAdress.Size = new System.Drawing.Size(89, 13);
            this.lbIpAdress.TabIndex = 2;
            this.lbIpAdress.Text = "Server IP Adress:";
            // 
            // txtSendPort
            // 
            this.txtSendPort.Location = new System.Drawing.Point(105, 33);
            this.txtSendPort.MaxLength = 6;
            this.txtSendPort.Name = "txtSendPort";
            this.txtSendPort.Size = new System.Drawing.Size(153, 20);
            this.txtSendPort.TabIndex = 5;
            this.txtSendPort.Text = "8081";
            this.txtSendPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSendPort_KeyPress);
            // 
            // txtIp1
            // 
            this.txtIp1.Location = new System.Drawing.Point(105, 80);
            this.txtIp1.MaxLength = 3;
            this.txtIp1.Name = "txtIp1";
            this.txtIp1.Size = new System.Drawing.Size(45, 20);
            this.txtIp1.TabIndex = 6;
            this.txtIp1.Text = "127";
            this.txtIp1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIp1_KeyPress);
            // 
            // txtIp2
            // 
            this.txtIp2.Location = new System.Drawing.Point(157, 80);
            this.txtIp2.MaxLength = 3;
            this.txtIp2.Name = "txtIp2";
            this.txtIp2.Size = new System.Drawing.Size(43, 20);
            this.txtIp2.TabIndex = 7;
            this.txtIp2.Text = "0";
            this.txtIp2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIp2_KeyPress);
            // 
            // txtIp3
            // 
            this.txtIp3.Location = new System.Drawing.Point(206, 80);
            this.txtIp3.MaxLength = 3;
            this.txtIp3.Name = "txtIp3";
            this.txtIp3.Size = new System.Drawing.Size(39, 20);
            this.txtIp3.TabIndex = 8;
            this.txtIp3.Text = "0";
            this.txtIp3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIp3_KeyPress);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clStt,
            this.clTenMay,
            this.clIpAdress});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(132, 217);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(463, 126);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // clStt
            // 
            this.clStt.Text = "STT";
            this.clStt.Width = 50;
            // 
            // clTenMay
            // 
            this.clTenMay.Text = "Tên Máy";
            this.clTenMay.Width = 180;
            // 
            // clIpAdress
            // 
            this.clIpAdress.Text = "Địa Chỉ IP";
            this.clIpAdress.Width = 236;
            // 
            // btFindIpLan
            // 
            this.btFindIpLan.Location = new System.Drawing.Point(452, 365);
            this.btFindIpLan.Name = "btFindIpLan";
            this.btFindIpLan.Size = new System.Drawing.Size(92, 34);
            this.btFindIpLan.TabIndex = 2;
            this.btFindIpLan.Text = "Tìm Server...";
            this.btFindIpLan.UseVisualStyleBackColor = true;
            this.btFindIpLan.Click += new System.EventHandler(this.btFindIpLan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status:";
            // 
            // lbSettingInfo
            // 
            this.lbSettingInfo.AutoSize = true;
            this.lbSettingInfo.Location = new System.Drawing.Point(179, 386);
            this.lbSettingInfo.Name = "lbSettingInfo";
            this.lbSettingInfo.Size = new System.Drawing.Size(199, 13);
            this.lbSettingInfo.TabIndex = 5;
            this.lbSettingInfo.Text = "Chọn các thông số để tiến hành cài đặt!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FT_Client.Properties.Resources.Settings;
            this.pictureBox1.Location = new System.Drawing.Point(5, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ConnectSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 411);
            this.Controls.Add(this.lbSettingInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btFindIpLan);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConnectSetting";
            this.Text = "Thiết lập các cài đặt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConnectSetting_FormClosed);
            this.Load += new System.EventHandler(this.ConnectSetting_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbSendPort;
        private System.Windows.Forms.Button btSetting;
        private System.Windows.Forms.TextBox txtIp4;
        private System.Windows.Forms.Label lbIpAdress;
        private System.Windows.Forms.TextBox txtSendPort;
        private System.Windows.Forms.TextBox txtIp1;
        private System.Windows.Forms.TextBox txtIp2;
        private System.Windows.Forms.TextBox txtIp3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clStt;
        private System.Windows.Forms.ColumnHeader clTenMay;
        private System.Windows.Forms.ColumnHeader clIpAdress;
        private System.Windows.Forms.Button btFindIpLan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSettingInfo;
    }
}