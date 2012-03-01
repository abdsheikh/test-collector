namespace FT_Server_Win
{
    partial class SettingForm
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
            this.grpSetting = new System.Windows.Forms.GroupBox();
            this.sendPort = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listenningPort = new System.Windows.Forms.Label();
            this.serverIPAddress = new System.Windows.Forms.Label();
            this.serverName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendPort)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSetting
            // 
            this.grpSetting.Controls.Add(this.sendPort);
            this.grpSetting.Controls.Add(this.label2);
            this.grpSetting.Location = new System.Drawing.Point(12, 129);
            this.grpSetting.Name = "grpSetting";
            this.grpSetting.Size = new System.Drawing.Size(260, 76);
            this.grpSetting.TabIndex = 0;
            this.grpSetting.TabStop = false;
            this.grpSetting.Text = "Cấu hình máy chủ";
            this.grpSetting.Enter += new System.EventHandler(this.grpSetting_Enter);
            // 
            // sendPort
            // 
            this.sendPort.Location = new System.Drawing.Point(122, 31);
            this.sendPort.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.sendPort.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sendPort.Name = "sendPort";
            this.sendPort.Size = new System.Drawing.Size(79, 20);
            this.sendPort.TabIndex = 7;
            this.sendPort.Value = new decimal(new int[] {
            8081,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cổng nhận dữ liệu:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Lưu thông tin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listenningPort);
            this.groupBox1.Controls.Add(this.serverIPAddress);
            this.groupBox1.Controls.Add(this.serverName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 111);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cấu hình máy chủ";
            // 
            // listenningPort
            // 
            this.listenningPort.AutoSize = true;
            this.listenningPort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listenningPort.Location = new System.Drawing.Point(120, 84);
            this.listenningPort.Name = "listenningPort";
            this.listenningPort.Size = new System.Drawing.Size(0, 13);
            this.listenningPort.TabIndex = 17;
            // 
            // serverIPAddress
            // 
            this.serverIPAddress.AutoSize = true;
            this.serverIPAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.serverIPAddress.Location = new System.Drawing.Point(120, 54);
            this.serverIPAddress.Name = "serverIPAddress";
            this.serverIPAddress.Size = new System.Drawing.Size(13, 13);
            this.serverIPAddress.TabIndex = 16;
            this.serverIPAddress.Text = "1";
            // 
            // serverName
            // 
            this.serverName.AutoSize = true;
            this.serverName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.serverName.Location = new System.Drawing.Point(120, 23);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(0, 13);
            this.serverName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(18, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cổng nhận dữ liệu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(18, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Địa chỉ IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(18, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tên máy chủ:";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 244);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpSetting);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.grpSetting.ResumeLayout(false);
            this.grpSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendPort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSetting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown sendPort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label listenningPort;
        private System.Windows.Forms.Label serverIPAddress;
        private System.Windows.Forms.Label serverName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}