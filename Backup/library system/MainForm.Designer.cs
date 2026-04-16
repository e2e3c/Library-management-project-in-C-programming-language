namespace library_system
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBorrow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDemurage = new System.Windows.Forms.ToolStripMenuItem();
            this.MainmenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.UserNameToolstrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableUserTableAdapter = new library_system.UmAliDataSetTableAdapters.TableUserTableAdapter();
            this.umAliDataSet = new library_system.UmAliDataSet();
            this.tableFormPermissionsTableAdapter = new library_system.UmAliDataSetTableAdapters.TableFormPermissionsTableAdapter();
            this.MainmenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.umAliDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuBooks
            // 
            this.MenuBooks.Name = "MenuBooks";
            this.MenuBooks.Size = new System.Drawing.Size(51, 20);
            this.MenuBooks.Text = "Books";
            this.MenuBooks.Visible = false;
            this.MenuBooks.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
            // 
            // MenuCategory
            // 
            this.MenuCategory.Name = "MenuCategory";
            this.MenuCategory.Size = new System.Drawing.Size(67, 20);
            this.MenuCategory.Text = "Category";
            this.MenuCategory.Visible = false;
            this.MenuCategory.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // MenuMembers
            // 
            this.MenuMembers.Name = "MenuMembers";
            this.MenuMembers.Size = new System.Drawing.Size(69, 20);
            this.MenuMembers.Text = "Members";
            this.MenuMembers.Visible = false;
            this.MenuMembers.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // MenuBorrow
            // 
            this.MenuBorrow.Name = "MenuBorrow";
            this.MenuBorrow.Size = new System.Drawing.Size(57, 20);
            this.MenuBorrow.Text = "Borrow";
            this.MenuBorrow.Visible = false;
            this.MenuBorrow.Click += new System.EventHandler(this.borrowToolStripMenuItem_Click);
            // 
            // MenuDemurage
            // 
            this.MenuDemurage.Name = "MenuDemurage";
            this.MenuDemurage.Size = new System.Drawing.Size(74, 20);
            this.MenuDemurage.Text = "Demurage";
            this.MenuDemurage.Visible = false;
            this.MenuDemurage.Click += new System.EventHandler(this.MenuDemurage_Click);
            // 
            // MainmenuStrip
            // 
            this.MainmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBooks,
            this.MenuCategory,
            this.MenuMembers,
            this.MenuSearch,
            this.MenuBorrow,
            this.MenuDemurage,
            this.exitToolStripMenuItem});
            this.MainmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainmenuStrip.Name = "MainmenuStrip";
            this.MainmenuStrip.Size = new System.Drawing.Size(813, 24);
            this.MainmenuStrip.TabIndex = 1;
            this.MainmenuStrip.Text = "menuStrip1";
            // 
            // MenuSearch
            // 
            this.MenuSearch.Name = "MenuSearch";
            this.MenuSearch.Size = new System.Drawing.Size(54, 20);
            this.MenuSearch.Text = "Search";
            this.MenuSearch.Visible = false;
            this.MenuSearch.Click += new System.EventHandler(this.MenuSearch_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.UserNameToolstrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 405);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(813, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabel1.Text = "Welcome  ";
            // 
            // UserNameToolstrip
            // 
            this.UserNameToolstrip.Name = "UserNameToolstrip";
            this.UserNameToolstrip.Size = new System.Drawing.Size(0, 17);
            // 
            // tableUserTableAdapter
            // 
            this.tableUserTableAdapter.ClearBeforeFill = true;
            // 
            // umAliDataSet
            // 
            this.umAliDataSet.DataSetName = "UmAliDataSet";
            this.umAliDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableFormPermissionsTableAdapter
            // 
            this.tableFormPermissionsTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 427);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainmenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainmenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainmenuStrip.ResumeLayout(false);
            this.MainmenuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.umAliDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem MenuBooks;
        private System.Windows.Forms.ToolStripMenuItem MenuCategory;
        private System.Windows.Forms.ToolStripMenuItem MenuMembers;
        private System.Windows.Forms.ToolStripMenuItem MenuBorrow;
        private System.Windows.Forms.ToolStripMenuItem MenuDemurage;
        private System.Windows.Forms.MenuStrip MainmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel UserNameToolstrip;
        private library_system.UmAliDataSetTableAdapters.TableUserTableAdapter tableUserTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem MenuSearch;
        private UmAliDataSet umAliDataSet;
        private library_system.UmAliDataSetTableAdapters.TableFormPermissionsTableAdapter tableFormPermissionsTableAdapter;


    }
}