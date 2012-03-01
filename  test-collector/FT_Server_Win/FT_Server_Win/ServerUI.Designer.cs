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
            this.nghiệpVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thiếtLậpThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridViewClientList = new System.Windows.Forms.DataGridView();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.connectCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sentCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnViewFolder = new System.Windows.Forms.Button();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.lblSaveFolder = new System.Windows.Forms.Label();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.xuấtDanhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClientList)).BeginInit();
            this.statusBar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.nghiệpVụToolStripMenuItem});
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
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // nghiệpVụToolStripMenuItem
            // 
            this.nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thiếtLậpThôngTinToolStripMenuItem,
            this.xuấtDanhSáchToolStripMenuItem});
            this.nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            resources.ApplyResources(this.nghiệpVụToolStripMenuItem, "nghiệpVụToolStripMenuItem");
            this.nghiệpVụToolStripMenuItem.Click += new System.EventHandler(this.nghiệpVụToolStripMenuItem_Click);
            // 
            // thiếtLậpThôngTinToolStripMenuItem
            // 
            this.thiếtLậpThôngTinToolStripMenuItem.Name = "thiếtLậpThôngTinToolStripMenuItem";
            resources.ApplyResources(this.thiếtLậpThôngTinToolStripMenuItem, "thiếtLậpThôngTinToolStripMenuItem");
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
            this.gridViewClientList.AllowUserToAddRows = false;
            this.gridViewClientList.AllowUserToDeleteRows = false;
            this.gridViewClientList.AllowUserToResizeColumns = false;
            this.gridViewClientList.AllowUserToResizeRows = false;
            this.gridViewClientList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridViewClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.gridViewClientList, "gridViewClientList");
            this.gridViewClientList.GridColor = System.Drawing.SystemColors.Control;
            this.gridViewClientList.Name = "gridViewClientList";
            this.gridViewClientList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gridViewClientList.RowHeadersVisible = false;
            this.gridViewClientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewClientList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridViewClientList_DataBindingComplete);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText,
            this.toolStripStatusLabel2});
            resources.ApplyResources(this.statusBar, "statusBar");
            this.statusBar.Name = "statusBar";
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            resources.ApplyResources(this.statusText, "statusText");
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.connectCount);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.sentCount);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // connectCount
            // 
            resources.ApplyResources(this.connectCount, "connectCount");
            this.connectCount.Name = "connectCount";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // sentCount
            // 
            resources.ApplyResources(this.sentCount, "sentCount");
            this.sentCount.Name = "sentCount";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnViewFolder);
            this.groupBox3.Controls.Add(this.btnSelectFolder);
            this.groupBox3.Controls.Add(this.lblSaveFolder);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // btnViewFolder
            // 
            resources.ApplyResources(this.btnViewFolder, "btnViewFolder");
            this.btnViewFolder.Name = "btnViewFolder";
            this.btnViewFolder.UseVisualStyleBackColor = true;
            this.btnViewFolder.Click += new System.EventHandler(this.btnViewFolder_Click);
            // 
            // btnSelectFolder
            // 
            resources.ApplyResources(this.btnSelectFolder, "btnSelectFolder");
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // lblSaveFolder
            // 
            resources.ApplyResources(this.lblSaveFolder, "lblSaveFolder");
            this.lblSaveFolder.Name = "lblSaveFolder";
            // 
            // xuấtDanhSáchToolStripMenuItem
            // 
            this.xuấtDanhSáchToolStripMenuItem.Name = "xuấtDanhSáchToolStripMenuItem";
            resources.ApplyResources(this.xuấtDanhSáchToolStripMenuItem, "xuấtDanhSáchToolStripMenuItem");
            this.xuấtDanhSáchToolStripMenuItem.Click += new System.EventHandler(this.xuấtDanhSáchToolStripMenuItem_Click);
            // 
            // ServerUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusBar);
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
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridViewClientList;
        private System.Windows.Forms.ToolStripMenuItem bậtKếtNốiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngắtKếtNốiToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnViewFolder;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label lblSaveFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem thiếtLậpThôngTinToolStripMenuItem;
        private System.Windows.Forms.Label sentCount;
        private System.Windows.Forms.Label connectCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem xuấtDanhSáchToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}