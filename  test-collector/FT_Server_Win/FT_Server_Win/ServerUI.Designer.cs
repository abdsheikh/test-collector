namespace FT_Server_Win
{
    partial class ServerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bậtKếtNốiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngắtKếtNốiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.càiĐặtKếtNốiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridViewClientList = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClientList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bậtKếtNốiToolStripMenuItem,
            this.ngắtKếtNốiToolStripMenuItem,
            this.càiĐặtKếtNốiToolStripMenuItem,
            this.toolStripMenuItem1,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            resources.ApplyResources(this.hệThốngToolStripMenuItem, "hệThốngToolStripMenuItem");
            // 
            // bậtKếtNốiToolStripMenuItem
            // 
            this.bậtKếtNốiToolStripMenuItem.Name = "bậtKếtNốiToolStripMenuItem";
            resources.ApplyResources(this.bậtKếtNốiToolStripMenuItem, "bậtKếtNốiToolStripMenuItem");
            this.bậtKếtNốiToolStripMenuItem.Click += new System.EventHandler(this.bậtKếtNốiToolStripMenuItem_Click);
            // 
            // ngắtKếtNốiToolStripMenuItem
            // 
            this.ngắtKếtNốiToolStripMenuItem.Name = "ngắtKếtNốiToolStripMenuItem";
            resources.ApplyResources(this.ngắtKếtNốiToolStripMenuItem, "ngắtKếtNốiToolStripMenuItem");
            this.ngắtKếtNốiToolStripMenuItem.Click += new System.EventHandler(this.ngắtKếtNốiToolStripMenuItem_Click);
            // 
            // càiĐặtKếtNốiToolStripMenuItem
            // 
            this.càiĐặtKếtNốiToolStripMenuItem.Name = "càiĐặtKếtNốiToolStripMenuItem";
            resources.ApplyResources(this.càiĐặtKếtNốiToolStripMenuItem, "càiĐặtKếtNốiToolStripMenuItem");
            this.càiĐặtKếtNốiToolStripMenuItem.Click += new System.EventHandler(this.càiĐặtKếtNốiToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            resources.ApplyResources(this.thoátToolStripMenuItem, "thoátToolStripMenuItem");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridViewClientList);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gridViewClientList
            // 
            this.gridViewClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.gridViewClientList, "gridViewClientList");
            this.gridViewClientList.Name = "gridViewClientList";
            this.gridViewClientList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridViewClientList.RowHeadersVisible = false;
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // txtMessage
            // 
            resources.ApplyResources(this.txtMessage, "txtMessage");
            this.txtMessage.Name = "txtMessage";
            // 
            // ServerUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerUI_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtKếtNốiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridViewClientList;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ToolStripMenuItem bậtKếtNốiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngắtKếtNốiToolStripMenuItem;
    }
}