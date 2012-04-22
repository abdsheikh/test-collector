namespace FT_Server_Win
{
    partial class InformationSetup
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toTimeMinutes = new System.Windows.Forms.NumericUpDown();
            this.toTimeHours = new System.Windows.Forms.NumericUpDown();
            this.fromTimeMinutes = new System.Windows.Forms.NumericUpDown();
            this.fromTimeHours = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericTestPeriod = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownStudentCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toTimeMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toTimeHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromTimeMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromTimeHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTestPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudentCount)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(153, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Lưu thông tin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.toTimeMinutes);
            this.groupBox1.Controls.Add(this.toTimeHours);
            this.groupBox1.Controls.Add(this.fromTimeMinutes);
            this.groupBox1.Controls.Add(this.fromTimeHours);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericTestPeriod);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDownStudentCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePickerDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSubject);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 190);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(247, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Đến";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(129, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Từ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = ":";
            // 
            // toTimeMinutes
            // 
            this.toTimeMinutes.Location = new System.Drawing.Point(331, 121);
            this.toTimeMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.toTimeMinutes.Name = "toTimeMinutes";
            this.toTimeMinutes.Size = new System.Drawing.Size(33, 20);
            this.toTimeMinutes.TabIndex = 18;
            // 
            // toTimeHours
            // 
            this.toTimeHours.Location = new System.Drawing.Point(285, 121);
            this.toTimeHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.toTimeHours.Name = "toTimeHours";
            this.toTimeHours.Size = new System.Drawing.Size(33, 20);
            this.toTimeHours.TabIndex = 17;
            // 
            // fromTimeMinutes
            // 
            this.fromTimeMinutes.Location = new System.Drawing.Point(198, 121);
            this.fromTimeMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.fromTimeMinutes.Name = "fromTimeMinutes";
            this.fromTimeMinutes.Size = new System.Drawing.Size(33, 20);
            this.fromTimeMinutes.TabIndex = 16;
            // 
            // fromTimeHours
            // 
            this.fromTimeHours.Location = new System.Drawing.Point(155, 121);
            this.fromTimeHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.fromTimeHours.Name = "fromTimeHours";
            this.fromTimeHours.Size = new System.Drawing.Size(33, 20);
            this.fromTimeHours.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Thời gian thi:";
            // 
            // numericTestPeriod
            // 
            this.numericTestPeriod.Location = new System.Drawing.Point(134, 89);
            this.numericTestPeriod.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericTestPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTestPeriod.Name = "numericTestPeriod";
            this.numericTestPeriod.Size = new System.Drawing.Size(72, 20);
            this.numericTestPeriod.TabIndex = 13;
            this.numericTestPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ca thi:";
            // 
            // numericUpDownStudentCount
            // 
            this.numericUpDownStudentCount.Location = new System.Drawing.Point(134, 152);
            this.numericUpDownStudentCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownStudentCount.Name = "numericUpDownStudentCount";
            this.numericUpDownStudentCount.Size = new System.Drawing.Size(72, 20);
            this.numericUpDownStudentCount.TabIndex = 11;
            this.numericUpDownStudentCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số sinh viên dự thi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ngày thi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Môn học:";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(134, 13);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(230, 20);
            this.txtSubject.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Thông tin buổi thi";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CustomFormat = "dd/mm/yyyy";
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(134, 48);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(228, 20);
            this.dateTimePickerDate.TabIndex = 8;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimeDate_ValueChanged);
            // 
            // InformationSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 305);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InformationSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toTimeMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toTimeHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromTimeMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromTimeHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTestPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudentCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownStudentCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericTestPeriod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown toTimeMinutes;
        private System.Windows.Forms.NumericUpDown toTimeHours;
        private System.Windows.Forms.NumericUpDown fromTimeMinutes;
        private System.Windows.Forms.NumericUpDown fromTimeHours;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;

    }
}