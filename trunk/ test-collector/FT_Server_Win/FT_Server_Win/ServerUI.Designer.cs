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
            this.components = new System.ComponentModel.Container();
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
            this.xuấtDanhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewClientList = new System.Windows.Forms.DataGridView();
            this.rowContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemBàiLàmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.rightPanel = new System.Windows.Forms.GroupBox();
            this.lblStartedTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTimeToTest = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTestPeriod = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStudentSum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sentCount = new System.Windows.Forms.Label();
            this.connectCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.imgServer = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.GroupBox();
            this.btnViewFolder = new System.Windows.Forms.Button();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.lblSaveFolder = new System.Windows.Forms.Label();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.startedTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClientList)).BeginInit();
            this.rowContextMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgServer)).BeginInit();
            this.bottomPanel.SuspendLayout();
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
            this.thiếtLậpThôngTinToolStripMenuItem.Click += new System.EventHandler(this.thiếtLậpThôngTinToolStripMenuItem_Click);
            // 
            // xuấtDanhSáchToolStripMenuItem
            // 
            this.xuấtDanhSáchToolStripMenuItem.Name = "xuấtDanhSáchToolStripMenuItem";
            resources.ApplyResources(this.xuấtDanhSáchToolStripMenuItem, "xuấtDanhSáchToolStripMenuItem");
            this.xuấtDanhSáchToolStripMenuItem.Click += new System.EventHandler(this.xuấtDanhSáchToolStripMenuItem_Click);
            // 
            // gridViewClientList
            // 
            this.gridViewClientList.AllowUserToAddRows = false;
            this.gridViewClientList.AllowUserToDeleteRows = false;
            this.gridViewClientList.AllowUserToResizeColumns = false;
            this.gridViewClientList.AllowUserToResizeRows = false;
            this.gridViewClientList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridViewClientList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridViewClientList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridViewClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewClientList.GridColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.gridViewClientList, "gridViewClientList");
            this.gridViewClientList.MultiSelect = false;
            this.gridViewClientList.Name = "gridViewClientList";
            this.gridViewClientList.ReadOnly = true;
            this.gridViewClientList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gridViewClientList.RowHeadersVisible = false;
            this.gridViewClientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridViewClientList.ShowCellErrors = false;
            this.gridViewClientList.ShowCellToolTips = false;
            this.gridViewClientList.ShowEditingIcon = false;
            this.gridViewClientList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewClientList_CellContentClick);
            this.gridViewClientList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridViewClientList_CellMouseClick);
            this.gridViewClientList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridViewClientList_DataBindingComplete);
            this.gridViewClientList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridViewClientList_MouseClick);
            // 
            // rowContextMenu
            // 
            this.rowContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemBàiLàmToolStripMenuItem});
            this.rowContextMenu.Name = "contextMenuStrip1";
            resources.ApplyResources(this.rowContextMenu, "rowContextMenu");
            this.rowContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // xemBàiLàmToolStripMenuItem
            // 
            this.xemBàiLàmToolStripMenuItem.Name = "xemBàiLàmToolStripMenuItem";
            resources.ApplyResources(this.xemBàiLàmToolStripMenuItem, "xemBàiLàmToolStripMenuItem");
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
            // rightPanel
            // 
            resources.ApplyResources(this.rightPanel, "rightPanel");
            this.rightPanel.Controls.Add(this.lblStartedTime);
            this.rightPanel.Controls.Add(this.panel1);
            this.rightPanel.Controls.Add(this.imgServer);
            this.rightPanel.Controls.Add(this.label4);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.TabStop = false;
            this.rightPanel.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // lblStartedTime
            // 
            resources.ApplyResources(this.lblStartedTime, "lblStartedTime");
            this.lblStartedTime.Name = "lblStartedTime";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTimeToTest);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblTestPeriod);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblStudentSum);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblSubject);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.sentCount);
            this.panel1.Controls.Add(this.connectCount);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Name = "panel1";
            // 
            // lblTimeToTest
            // 
            resources.ApplyResources(this.lblTimeToTest, "lblTimeToTest");
            this.lblTimeToTest.Name = "lblTimeToTest";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // lblTestPeriod
            // 
            resources.ApplyResources(this.lblTestPeriod, "lblTestPeriod");
            this.lblTestPeriod.Name = "lblTestPeriod";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // lblStudentSum
            // 
            resources.ApplyResources(this.lblStudentSum, "lblStudentSum");
            this.lblStudentSum.Name = "lblStudentSum";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.Name = "lblDate";
            this.lblDate.TextChanged += new System.EventHandler(this.lblDate_TextChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // lblSubject
            // 
            resources.ApplyResources(this.lblSubject, "lblSubject");
            this.lblSubject.Name = "lblSubject";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // sentCount
            // 
            resources.ApplyResources(this.sentCount, "sentCount");
            this.sentCount.Name = "sentCount";
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
            // imgServer
            // 
            resources.ApplyResources(this.imgServer, "imgServer");
            this.imgServer.Image = global::FT_Server_Win.Properties.Resources.running;
            this.imgServer.Name = "imgServer";
            this.imgServer.TabStop = false;
            this.imgServer.Click += new System.EventHandler(this.imgServer_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.btnViewFolder);
            this.bottomPanel.Controls.Add(this.btnSelectFolder);
            this.bottomPanel.Controls.Add(this.lblSaveFolder);
            resources.ApplyResources(this.bottomPanel, "bottomPanel");
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.TabStop = false;
            this.bottomPanel.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnViewFolder
            // 
            resources.ApplyResources(this.btnViewFolder, "btnViewFolder");
            this.btnViewFolder.Image = global::FT_Server_Win.Properties.Resources._1330792413_old_edit_find;
            this.btnViewFolder.Name = "btnViewFolder";
            this.btnViewFolder.UseVisualStyleBackColor = true;
            this.btnViewFolder.Click += new System.EventHandler(this.btnViewFolder_Click);
            // 
            // btnSelectFolder
            // 
            resources.ApplyResources(this.btnSelectFolder, "btnSelectFolder");
            this.btnSelectFolder.Image = global::FT_Server_Win.Properties.Resources._1330792173_user_home;
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // lblSaveFolder
            // 
            resources.ApplyResources(this.lblSaveFolder, "lblSaveFolder");
            this.lblSaveFolder.Name = "lblSaveFolder";
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // startedTimer
            // 
            this.startedTimer.Interval = 1000;
            this.startedTimer.Tick += new System.EventHandler(this.startedTimer_Tick);
            // 
            // ServerUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gridViewClientList);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerUI_FormClosing);
            this.SizeChanged += new System.EventHandler(this.ServerUI_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClientList)).EndInit();
            this.rowContextMenu.ResumeLayout(false);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgServer)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtKếtNốiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.GroupBox rightPanel;
        private System.Windows.Forms.DataGridView gridViewClientList;
        private System.Windows.Forms.ToolStripMenuItem bậtKếtNốiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngắtKếtNốiToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.GroupBox bottomPanel;
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PictureBox imgServer;
        private System.Windows.Forms.ContextMenuStrip rowContextMenu;
        private System.Windows.Forms.ToolStripMenuItem xemBàiLàmToolStripMenuItem;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblStudentSum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStartedTime;
        private System.Windows.Forms.Timer startedTimer;
        private System.Windows.Forms.Label lblTimeToTest;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label testPeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTestPeriod;
    }
}