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
            this.label2 = new System.Windows.Forms.Label();
            this.sendPort = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.grpSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendPort)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSetting
            // 
            this.grpSetting.Controls.Add(this.sendPort);
            this.grpSetting.Controls.Add(this.label2);
            this.grpSetting.Location = new System.Drawing.Point(12, 12);
            this.grpSetting.Name = "grpSetting";
            this.grpSetting.Size = new System.Drawing.Size(260, 111);
            this.grpSetting.TabIndex = 0;
            this.grpSetting.TabStop = false;
            this.grpSetting.Text = "Cấu hình máy chủ";
            this.grpSetting.Enter += new System.EventHandler(this.grpSetting_Enter);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Lưu thông tin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 183);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpSetting);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.grpSetting.ResumeLayout(false);
            this.grpSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSetting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown sendPort;
        private System.Windows.Forms.Button button1;
    }
}