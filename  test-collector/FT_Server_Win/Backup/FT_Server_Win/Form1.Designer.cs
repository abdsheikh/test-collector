namespace FT_Server_Win
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
            this.btnStartSvr = new System.Windows.Forms.Button();
            this.btnStopSvr = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartSvr
            // 
            this.btnStartSvr.Location = new System.Drawing.Point(170, 32);
            this.btnStartSvr.Name = "btnStartSvr";
            this.btnStartSvr.Size = new System.Drawing.Size(198, 23);
            this.btnStartSvr.TabIndex = 0;
            this.btnStartSvr.Text = "Start Server";
            this.btnStartSvr.UseVisualStyleBackColor = true;
            this.btnStartSvr.Click += new System.EventHandler(this.btnStartSvr_Click);
            // 
            // btnStopSvr
            // 
            this.btnStopSvr.Location = new System.Drawing.Point(170, 74);
            this.btnStopSvr.Name = "btnStopSvr";
            this.btnStopSvr.Size = new System.Drawing.Size(198, 23);
            this.btnStopSvr.TabIndex = 1;
            this.btnStopSvr.Text = "Stop Server";
            this.btnStopSvr.UseVisualStyleBackColor = true;
            this.btnStopSvr.Click += new System.EventHandler(this.btnStopSvr_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(181, 131);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(35, 13);
            this.lblMsg.TabIndex = 2;
            this.lblMsg.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 266);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnStopSvr);
            this.Controls.Add(this.btnStartSvr);
            this.Name = "Form1";
            this.Text = "Server Console";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartSvr;
        private System.Windows.Forms.Button btnStopSvr;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button button1;
    }
}

