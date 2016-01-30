namespace SondosGlasses
{
    partial class Main
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
            this.butNUser = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تسجيلالخروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إغلاقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إضافةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إضافةعميلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إضافةنضارةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ادارةالعملاءToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إدارةالنضاراتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إدارةالموظفينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مساعدةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مساعدةToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.حولالبرنامجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إضافةToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.butRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // butNUser
            // 
            this.butNUser.Location = new System.Drawing.Point(791, 83);
            this.butNUser.Name = "butNUser";
            this.butNUser.Size = new System.Drawing.Size(89, 23);
            this.butNUser.TabIndex = 0;
            this.butNUser.Text = "New User";
            this.butNUser.UseVisualStyleBackColor = true;
            this.butNUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(788, 394);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(89, 23);
            this.butClose.TabIndex = 2;
            this.butClose.Text = "إغلاق";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(91, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(581, 305);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 135;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "الإســــــــــــــم";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "المحمول";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 135;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "العمر";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 134;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.إضافةToolStripMenuItem,
            this.إعToolStripMenuItem,
            this.مساعدةToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تسجيلالخروجToolStripMenuItem,
            this.إغلاقToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.fileToolStripMenuItem.Text = "ملف";
            // 
            // تسجيلالخروجToolStripMenuItem
            // 
            this.تسجيلالخروجToolStripMenuItem.Name = "تسجيلالخروجToolStripMenuItem";
            this.تسجيلالخروجToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.تسجيلالخروجToolStripMenuItem.Text = "تسجيل الخروج";
            this.تسجيلالخروجToolStripMenuItem.Click += new System.EventHandler(this.تسجيلالخروجToolStripMenuItem_Click);
            // 
            // إغلاقToolStripMenuItem
            // 
            this.إغلاقToolStripMenuItem.Name = "إغلاقToolStripMenuItem";
            this.إغلاقToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.إغلاقToolStripMenuItem.Text = "إغلاق";
            this.إغلاقToolStripMenuItem.Click += new System.EventHandler(this.إغلاقToolStripMenuItem_Click);
            // 
            // إضافةToolStripMenuItem
            // 
            this.إضافةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إضافةعميلToolStripMenuItem,
            this.إضافةنضارةToolStripMenuItem});
            this.إضافةToolStripMenuItem.Name = "إضافةToolStripMenuItem";
            this.إضافةToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.إضافةToolStripMenuItem.Text = "إضافة";
            // 
            // إضافةعميلToolStripMenuItem
            // 
            this.إضافةعميلToolStripMenuItem.Name = "إضافةعميلToolStripMenuItem";
            this.إضافةعميلToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.إضافةعميلToolStripMenuItem.Text = "إضافة عميل";
            this.إضافةعميلToolStripMenuItem.Click += new System.EventHandler(this.إضافةعميلToolStripMenuItem_Click);
            // 
            // إضافةنضارةToolStripMenuItem
            // 
            this.إضافةنضارةToolStripMenuItem.Name = "إضافةنضارةToolStripMenuItem";
            this.إضافةنضارةToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.إضافةنضارةToolStripMenuItem.Text = "إضافة نضارة";
            this.إضافةنضارةToolStripMenuItem.Click += new System.EventHandler(this.إضافةنضارةToolStripMenuItem_Click);
            // 
            // إعToolStripMenuItem
            // 
            this.إعToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ادارةالعملاءToolStripMenuItem,
            this.إدارةالنضاراتToolStripMenuItem,
            this.إدارةالموظفينToolStripMenuItem});
            this.إعToolStripMenuItem.Name = "إعToolStripMenuItem";
            this.إعToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.إعToolStripMenuItem.Text = "إعدادات";
            // 
            // ادارةالعملاءToolStripMenuItem
            // 
            this.ادارةالعملاءToolStripMenuItem.Name = "ادارةالعملاءToolStripMenuItem";
            this.ادارةالعملاءToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.ادارةالعملاءToolStripMenuItem.Text = "ادارة العملاء";
            // 
            // إدارةالنضاراتToolStripMenuItem
            // 
            this.إدارةالنضاراتToolStripMenuItem.Name = "إدارةالنضاراتToolStripMenuItem";
            this.إدارةالنضاراتToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.إدارةالنضاراتToolStripMenuItem.Text = "إدارة النضارات";
            // 
            // إدارةالموظفينToolStripMenuItem
            // 
            this.إدارةالموظفينToolStripMenuItem.Name = "إدارةالموظفينToolStripMenuItem";
            this.إدارةالموظفينToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.إدارةالموظفينToolStripMenuItem.Text = "إدارة الموظفين";
            this.إدارةالموظفينToolStripMenuItem.Click += new System.EventHandler(this.إدارةالموظفينToolStripMenuItem_Click);
            // 
            // مساعدةToolStripMenuItem
            // 
            this.مساعدةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مساعدةToolStripMenuItem1,
            this.حولالبرنامجToolStripMenuItem,
            this.إضافةToolStripMenuItem1});
            this.مساعدةToolStripMenuItem.Name = "مساعدةToolStripMenuItem";
            this.مساعدةToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.مساعدةToolStripMenuItem.Text = "مساعدة";
            // 
            // مساعدةToolStripMenuItem1
            // 
            this.مساعدةToolStripMenuItem1.Name = "مساعدةToolStripMenuItem1";
            this.مساعدةToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.مساعدةToolStripMenuItem1.Text = "مساعدة";
            // 
            // حولالبرنامجToolStripMenuItem
            // 
            this.حولالبرنامجToolStripMenuItem.Name = "حولالبرنامجToolStripMenuItem";
            this.حولالبرنامجToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.حولالبرنامجToolStripMenuItem.Text = "حول البرنامج";
            this.حولالبرنامجToolStripMenuItem.Click += new System.EventHandler(this.حولالبرنامجToolStripMenuItem_Click);
            // 
            // إضافةToolStripMenuItem1
            // 
            this.إضافةToolStripMenuItem1.Name = "إضافةToolStripMenuItem1";
            this.إضافةToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.إضافةToolStripMenuItem1.Text = "إضافة ";
            // 
            // MainTab
            // 
            this.MainTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MainTab.Controls.Add(this.tabPage1);
            this.MainTab.Controls.Add(this.tabPage2);
            this.MainTab.Controls.Add(this.tabPage3);
            this.MainTab.Cursor = System.Windows.Forms.Cursors.Cross;
            this.MainTab.Location = new System.Drawing.Point(65, 45);
            this.MainTab.Name = "MainTab";
            this.MainTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainTab.RightToLeftLayout = true;
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(695, 397);
            this.MainTab.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.MainTab.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(687, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "العملاء";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(687, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "النضارات";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView2.Location = new System.Drawing.Point(83, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(589, 309);
            this.dataGridView2.TabIndex = 0;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "#";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "النوع";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "الموديل";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "السعر";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "الكمية";
            this.Column9.Name = "Column9";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(687, 371);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "مبيعات";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // butRefresh
            // 
            this.butRefresh.Location = new System.Drawing.Point(791, 54);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(89, 23);
            this.butRefresh.TabIndex = 7;
            this.butRefresh.Text = "تحديث";
            this.butRefresh.UseVisualStyleBackColor = true;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(892, 464);
            this.Controls.Add(this.butRefresh);
            this.Controls.Add(this.MainTab);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butNUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butNUser;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إغلاقToolStripMenuItem;
        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button butRefresh;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ToolStripMenuItem إضافةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إضافةعميلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إضافةنضارةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إعToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ادارةالعملاءToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إدارةالنضاراتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إدارةالموظفينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مساعدةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مساعدةToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem حولالبرنامجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إضافةToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem تسجيلالخروجToolStripMenuItem;
    }
}