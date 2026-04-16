namespace library_system
{
    partial class FormSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.catComboBox = new System.Windows.Forms.ComboBox();
            this.catBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.umAliDataSet = new library_system.UmAliDataSet();
            this.PublishertextBox = new System.Windows.Forms.TextBox();
            this.BookNametextBox = new System.Windows.Forms.TextBox();
            this.AuthertextBox = new System.Windows.Forms.TextBox();
            this.BookIDtextBox = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new library_system.UmAliDataSetTableAdapters.BookTableAdapter();
            this.tableAdapterManager = new library_system.UmAliDataSetTableAdapters.TableAdapterManager();
            this.catTableAdapter = new library_system.UmAliDataSetTableAdapters.CatTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.umAliDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.catComboBox);
            this.groupBox1.Controls.Add(this.PublishertextBox);
            this.groupBox1.Controls.Add(this.BookNametextBox);
            this.groupBox1.Controls.Add(this.AuthertextBox);
            this.groupBox1.Controls.Add(this.BookIDtextBox);
            this.groupBox1.Controls.Add(this.Exit);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by:";
            // 
            // catComboBox
            // 
            this.catComboBox.DataSource = this.catBindingSource;
            this.catComboBox.DisplayMember = "Cat";
            this.catComboBox.FormattingEnabled = true;
            this.catComboBox.Location = new System.Drawing.Point(513, 24);
            this.catComboBox.Name = "catComboBox";
            this.catComboBox.Size = new System.Drawing.Size(138, 21);
            this.catComboBox.TabIndex = 11;
            this.catComboBox.ValueMember = "CatID";
            // 
            // catBindingSource
            // 
            this.catBindingSource.DataMember = "Cat";
            this.catBindingSource.DataSource = this.umAliDataSet;
            // 
            // umAliDataSet
            // 
            this.umAliDataSet.DataSetName = "UmAliDataSet";
            this.umAliDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PublishertextBox
            // 
            this.PublishertextBox.Location = new System.Drawing.Point(260, 62);
            this.PublishertextBox.Multiline = true;
            this.PublishertextBox.Name = "PublishertextBox";
            this.PublishertextBox.Size = new System.Drawing.Size(161, 20);
            this.PublishertextBox.TabIndex = 10;
            // 
            // BookNametextBox
            // 
            this.BookNametextBox.Location = new System.Drawing.Point(260, 24);
            this.BookNametextBox.Multiline = true;
            this.BookNametextBox.Name = "BookNametextBox";
            this.BookNametextBox.Size = new System.Drawing.Size(161, 20);
            this.BookNametextBox.TabIndex = 9;
            // 
            // AuthertextBox
            // 
            this.AuthertextBox.Location = new System.Drawing.Point(74, 62);
            this.AuthertextBox.Multiline = true;
            this.AuthertextBox.Name = "AuthertextBox";
            this.AuthertextBox.Size = new System.Drawing.Size(100, 20);
            this.AuthertextBox.TabIndex = 8;
            // 
            // BookIDtextBox
            // 
            this.BookIDtextBox.Location = new System.Drawing.Point(74, 24);
            this.BookIDtextBox.Multiline = true;
            this.BookIDtextBox.Name = "BookIDtextBox";
            this.BookIDtextBox.Size = new System.Drawing.Size(100, 20);
            this.BookIDtextBox.TabIndex = 7;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(792, 55);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(792, 21);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 5;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Publisher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Auther";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ID";
            // 
            // bookDataGridView
            // 
            this.bookDataGridView.AllowUserToAddRows = false;
            this.bookDataGridView.AllowUserToDeleteRows = false;
            this.bookDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bookDataGridView.AutoGenerateColumns = false;
            this.bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.bookDataGridView.DataSource = this.bookBindingSource;
            this.bookDataGridView.Location = new System.Drawing.Point(12, 109);
            this.bookDataGridView.Name = "bookDataGridView";
            this.bookDataGridView.ReadOnly = true;
            this.bookDataGridView.Size = new System.Drawing.Size(902, 226);
            this.bookDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BookID";
            this.dataGridViewTextBoxColumn1.FillWeight = 80F;
            this.dataGridViewTextBoxColumn1.HeaderText = "BookID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BookName";
            this.dataGridViewTextBoxColumn2.FillWeight = 200F;
            this.dataGridViewTextBoxColumn2.HeaderText = "BookName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CatID";
            this.dataGridViewTextBoxColumn3.DataSource = this.catBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Cat";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.FillWeight = 150F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Category";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "CatID";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn4.HeaderText = "Author";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Pub";
            this.dataGridViewTextBoxColumn5.HeaderText = "Publishar";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Stat";
            this.dataGridViewTextBoxColumn6.FillWeight = 80F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Status";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Loc";
            this.dataGridViewTextBoxColumn7.HeaderText = "Location";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Limit";
            this.dataGridViewTextBoxColumn8.HeaderText = "Limit";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.umAliDataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = this.bookTableAdapter;
            this.tableAdapterManager.borrowTableAdapter = null;
            this.tableAdapterManager.CatTableAdapter = this.catTableAdapter;
            this.tableAdapterManager.MamberTypeTableAdapter = null;
            this.tableAdapterManager.MemberTableAdapter = null;
            this.tableAdapterManager.TableFormPermissionsTableAdapter = null;
            this.tableAdapterManager.TableFormTableAdapter = null;
            this.tableAdapterManager.TablePermissionTableAdapter = null;
            this.tableAdapterManager.TableUserTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = library_system.UmAliDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // catTableAdapter
            // 
            this.catTableAdapter.ClearBeforeFill = true;
            // 
            // FormSearch
            // 
            this.AcceptButton = this.search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(919, 341);
            this.Controls.Add(this.bookDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search in Books";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.umAliDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox catComboBox;
        private System.Windows.Forms.TextBox PublishertextBox;
        private System.Windows.Forms.TextBox BookNametextBox;
        private System.Windows.Forms.TextBox AuthertextBox;
        private System.Windows.Forms.TextBox BookIDtextBox;
        private UmAliDataSet umAliDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private library_system.UmAliDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private library_system.UmAliDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bookDataGridView;
        private library_system.UmAliDataSetTableAdapters.CatTableAdapter catTableAdapter;
        private System.Windows.Forms.BindingSource catBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}