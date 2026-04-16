namespace library_system
{
    partial class FormDemurrage
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
            System.Windows.Forms.Label memNumberLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label memberTypeLabel;
            System.Windows.Forms.Label catLabel;
            System.Windows.Forms.Label bookNameLabel;
            System.Windows.Forms.Label borDateLabel;
            System.Windows.Forms.Label retDateLabel;
            System.Windows.Forms.Label returnDateLabel;
            System.Windows.Forms.Label demurageLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDemurrage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BorIDtextBox = new System.Windows.Forms.TextBox();
            this.memNumberTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.memberTypeTextBox = new System.Windows.Forms.TextBox();
            this.catTextBox = new System.Windows.Forms.TextBox();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.borDateTextBox = new System.Windows.Forms.TextBox();
            this.DueDateTextBox = new System.Windows.Forms.TextBox();
            this.dataTableDemurageBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BookIDtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.demurageTextBox = new System.Windows.Forms.MaskedTextBox();
            this.returnDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.LateDaystextBox = new System.Windows.Forms.TextBox();
            this.dataTableDemurageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.umAliDataSet = new library_system.UmAliDataSet();
            this.dataTableDemurageTableAdapter = new library_system.UmAliDataSetTableAdapters.DataTableDemurageTableAdapter();
            this.tableAdapterManager = new library_system.UmAliDataSetTableAdapters.TableAdapterManager();
            this.bookTableAdapter = new library_system.UmAliDataSetTableAdapters.BookTableAdapter();
            memNumberLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            memberTypeLabel = new System.Windows.Forms.Label();
            catLabel = new System.Windows.Forms.Label();
            bookNameLabel = new System.Windows.Forms.Label();
            borDateLabel = new System.Windows.Forms.Label();
            retDateLabel = new System.Windows.Forms.Label();
            returnDateLabel = new System.Windows.Forms.Label();
            demurageLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableDemurageBindingNavigator)).BeginInit();
            this.dataTableDemurageBindingNavigator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableDemurageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.umAliDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // memNumberLabel
            // 
            memNumberLabel.AutoSize = true;
            memNumberLabel.Location = new System.Drawing.Point(297, 79);
            memNumberLabel.Name = "memNumberLabel";
            memNumberLabel.Size = new System.Drawing.Size(69, 13);
            memNumberLabel.TabIndex = 9;
            memNumberLabel.Text = "Borrower ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(6, 106);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(85, 13);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Borrower Name:";
            // 
            // memberTypeLabel
            // 
            memberTypeLabel.AutoSize = true;
            memberTypeLabel.Location = new System.Drawing.Point(284, 106);
            memberTypeLabel.Name = "memberTypeLabel";
            memberTypeLabel.Size = new System.Drawing.Size(82, 13);
            memberTypeLabel.TabIndex = 13;
            memberTypeLabel.Text = "Borrower Type:";
            // 
            // catLabel
            // 
            catLabel.AutoSize = true;
            catLabel.Location = new System.Drawing.Point(32, 83);
            catLabel.Name = "catLabel";
            catLabel.Size = new System.Drawing.Size(56, 13);
            catLabel.TabIndex = 15;
            catLabel.Text = "Category:";
            // 
            // bookNameLabel
            // 
            bookNameLabel.AutoSize = true;
            bookNameLabel.Location = new System.Drawing.Point(302, 53);
            bookNameLabel.Name = "bookNameLabel";
            bookNameLabel.Size = new System.Drawing.Size(64, 13);
            bookNameLabel.TabIndex = 19;
            bookNameLabel.Text = "Book Name:";
            // 
            // borDateLabel
            // 
            borDateLabel.AutoSize = true;
            borDateLabel.Location = new System.Drawing.Point(20, 132);
            borDateLabel.Name = "borDateLabel";
            borDateLabel.Size = new System.Drawing.Size(71, 13);
            borDateLabel.TabIndex = 21;
            borDateLabel.Text = "Borrow Date:";
            // 
            // retDateLabel
            // 
            retDateLabel.AutoSize = true;
            retDateLabel.Location = new System.Drawing.Point(310, 132);
            retDateLabel.Name = "retDateLabel";
            retDateLabel.Size = new System.Drawing.Size(56, 13);
            retDateLabel.TabIndex = 23;
            retDateLabel.Text = "Due Date:";
            // 
            // returnDateLabel
            // 
            returnDateLabel.AutoSize = true;
            returnDateLabel.Location = new System.Drawing.Point(18, 26);
            returnDateLabel.Name = "returnDateLabel";
            returnDateLabel.Size = new System.Drawing.Size(70, 13);
            returnDateLabel.TabIndex = 25;
            returnDateLabel.Text = "Return Date:";
            // 
            // demurageLabel
            // 
            demurageLabel.AutoSize = true;
            demurageLabel.Location = new System.Drawing.Point(187, 103);
            demurageLabel.Name = "demurageLabel";
            demurageLabel.Size = new System.Drawing.Size(60, 13);
            demurageLabel.TabIndex = 27;
            demurageLabel.Text = "Demurage:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(187, 73);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 13);
            label2.TabIndex = 29;
            label2.Text = "Late Days:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(29, 54);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 13);
            label3.TabIndex = 26;
            label3.Text = "Borrow ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.Red;
            label4.Location = new System.Drawing.Point(372, 105);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(15, 16);
            label4.TabIndex = 34;
            label4.Text = "$";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.BorIDtextBox);
            this.groupBox1.Controls.Add(memNumberLabel);
            this.groupBox1.Controls.Add(this.memNumberTextBox);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(memberTypeLabel);
            this.groupBox1.Controls.Add(this.memberTypeTextBox);
            this.groupBox1.Controls.Add(catLabel);
            this.groupBox1.Controls.Add(this.catTextBox);
            this.groupBox1.Controls.Add(bookNameLabel);
            this.groupBox1.Controls.Add(this.bookNameTextBox);
            this.groupBox1.Controls.Add(borDateLabel);
            this.groupBox1.Controls.Add(this.borDateTextBox);
            this.groupBox1.Controls.Add(retDateLabel);
            this.groupBox1.Controls.Add(this.DueDateTextBox);
            this.groupBox1.Controls.Add(this.dataTableDemurageBindingNavigator);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Borrow Data";
            // 
            // BorIDtextBox
            // 
            this.BorIDtextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableDemurageBindingSource, "BorID", true));
            this.BorIDtextBox.Location = new System.Drawing.Point(92, 50);
            this.BorIDtextBox.Name = "BorIDtextBox";
            this.BorIDtextBox.ReadOnly = true;
            this.BorIDtextBox.Size = new System.Drawing.Size(181, 20);
            this.BorIDtextBox.TabIndex = 25;
            // 
            // memNumberTextBox
            // 
            this.memNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableDemurageBindingSource, "MemNumber", true));
            this.memNumberTextBox.Location = new System.Drawing.Point(372, 76);
            this.memNumberTextBox.Name = "memNumberTextBox";
            this.memNumberTextBox.ReadOnly = true;
            this.memNumberTextBox.Size = new System.Drawing.Size(179, 20);
            this.memNumberTextBox.TabIndex = 10;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableDemurageBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(92, 106);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(181, 20);
            this.nameTextBox.TabIndex = 12;
            // 
            // memberTypeTextBox
            // 
            this.memberTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableDemurageBindingSource, "MemberType", true));
            this.memberTypeTextBox.Location = new System.Drawing.Point(372, 106);
            this.memberTypeTextBox.Name = "memberTypeTextBox";
            this.memberTypeTextBox.ReadOnly = true;
            this.memberTypeTextBox.Size = new System.Drawing.Size(179, 20);
            this.memberTypeTextBox.TabIndex = 14;
            // 
            // catTextBox
            // 
            this.catTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableDemurageBindingSource, "Cat", true));
            this.catTextBox.Location = new System.Drawing.Point(92, 76);
            this.catTextBox.Name = "catTextBox";
            this.catTextBox.ReadOnly = true;
            this.catTextBox.Size = new System.Drawing.Size(181, 20);
            this.catTextBox.TabIndex = 16;
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableDemurageBindingSource, "BookName", true));
            this.bookNameTextBox.Location = new System.Drawing.Point(372, 47);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.ReadOnly = true;
            this.bookNameTextBox.Size = new System.Drawing.Size(179, 20);
            this.bookNameTextBox.TabIndex = 20;
            // 
            // borDateTextBox
            // 
            this.borDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableDemurageBindingSource, "BorDate", true));
            this.borDateTextBox.Location = new System.Drawing.Point(94, 132);
            this.borDateTextBox.Name = "borDateTextBox";
            this.borDateTextBox.ReadOnly = true;
            this.borDateTextBox.Size = new System.Drawing.Size(179, 20);
            this.borDateTextBox.TabIndex = 22;
            // 
            // DueDateTextBox
            // 
            this.DueDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableDemurageBindingSource, "RetDate", true));
            this.DueDateTextBox.Location = new System.Drawing.Point(372, 132);
            this.DueDateTextBox.Name = "DueDateTextBox";
            this.DueDateTextBox.ReadOnly = true;
            this.DueDateTextBox.Size = new System.Drawing.Size(179, 20);
            this.DueDateTextBox.TabIndex = 24;
            // 
            // dataTableDemurageBindingNavigator
            // 
            this.dataTableDemurageBindingNavigator.AddNewItem = null;
            this.dataTableDemurageBindingNavigator.BindingSource = this.dataTableDemurageBindingSource;
            this.dataTableDemurageBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dataTableDemurageBindingNavigator.DeleteItem = null;
            this.dataTableDemurageBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.dataTableDemurageBindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.dataTableDemurageBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dataTableDemurageBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dataTableDemurageBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dataTableDemurageBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dataTableDemurageBindingNavigator.Name = "dataTableDemurageBindingNavigator";
            this.dataTableDemurageBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dataTableDemurageBindingNavigator.Size = new System.Drawing.Size(572, 25);
            this.dataTableDemurageBindingNavigator.TabIndex = 5;
            this.dataTableDemurageBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BookIDtextBox
            // 
            this.BookIDtextBox.Location = new System.Drawing.Point(78, 28);
            this.BookIDtextBox.Name = "BookIDtextBox";
            this.BookIDtextBox.Size = new System.Drawing.Size(131, 20);
            this.BookIDtextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Controls.Add(this.BookIDtextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 66);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find By Book ID";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(411, 23);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(132, 23);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(label4);
            this.groupBox3.Controls.Add(this.demurageTextBox);
            this.groupBox3.Controls.Add(this.returnDateTextBox);
            this.groupBox3.Controls.Add(this.btnCalculate);
            this.groupBox3.Controls.Add(this.LateDaystextBox);
            this.groupBox3.Controls.Add(label2);
            this.groupBox3.Controls.Add(returnDateLabel);
            this.groupBox3.Controls.Add(demurageLabel);
            this.groupBox3.Location = new System.Drawing.Point(12, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(575, 139);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Demurrage Data";
            // 
            // demurageTextBox
            // 
            this.demurageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableDemurageBindingSource, "Demurage", true));
            this.demurageTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demurageTextBox.ForeColor = System.Drawing.Color.Red;
            this.demurageTextBox.Location = new System.Drawing.Point(254, 100);
            this.demurageTextBox.Name = "demurageTextBox";
            this.demurageTextBox.ReadOnly = true;
            this.demurageTextBox.Size = new System.Drawing.Size(112, 23);
            this.demurageTextBox.TabIndex = 33;
            this.demurageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // returnDateTextBox
            // 
            this.returnDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataTableDemurageBindingSource, "ReturnDate", true));
            this.returnDateTextBox.HidePromptOnLeave = true;
            this.returnDateTextBox.Location = new System.Drawing.Point(94, 19);
            this.returnDateTextBox.Mask = "00/00/0000";
            this.returnDateTextBox.Name = "returnDateTextBox";
            this.returnDateTextBox.Size = new System.Drawing.Size(179, 20);
            this.returnDateTextBox.TabIndex = 32;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(411, 21);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(142, 23);
            this.btnCalculate.TabIndex = 31;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // LateDaystextBox
            // 
            this.LateDaystextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LateDaystextBox.Location = new System.Drawing.Point(253, 70);
            this.LateDaystextBox.Name = "LateDaystextBox";
            this.LateDaystextBox.ReadOnly = true;
            this.LateDaystextBox.Size = new System.Drawing.Size(113, 23);
            this.LateDaystextBox.TabIndex = 30;
            this.LateDaystextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataTableDemurageBindingSource
            // 
            this.dataTableDemurageBindingSource.DataMember = "DataTableDemurage";
            this.dataTableDemurageBindingSource.DataSource = this.umAliDataSet;
            this.dataTableDemurageBindingSource.PositionChanged += new System.EventHandler(this.dataTableDemurageBindingSource_PositionChanged);
            // 
            // umAliDataSet
            // 
            this.umAliDataSet.DataSetName = "UmAliDataSet";
            this.umAliDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableDemurageTableAdapter
            // 
            this.dataTableDemurageTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = this.bookTableAdapter;
            this.tableAdapterManager.borrowTableAdapter = null;
            this.tableAdapterManager.CatTableAdapter = null;
            this.tableAdapterManager.MamberTypeTableAdapter = null;
            this.tableAdapterManager.MemberTableAdapter = null;
            this.tableAdapterManager.TableFormPermissionsTableAdapter = null;
            this.tableAdapterManager.TableFormTableAdapter = null;
            this.tableAdapterManager.TablePermissionTableAdapter = null;
            this.tableAdapterManager.TableUserTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = library_system.UmAliDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // FormDemurrage
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(594, 395);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDemurrage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Demurrage";
            this.Load += new System.EventHandler(this.FormDemurrage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableDemurageBindingNavigator)).EndInit();
            this.dataTableDemurageBindingNavigator.ResumeLayout(false);
            this.dataTableDemurageBindingNavigator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableDemurageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.umAliDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox BookIDtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFind;
        private UmAliDataSet umAliDataSet;
        private System.Windows.Forms.BindingSource dataTableDemurageBindingSource;
        private library_system.UmAliDataSetTableAdapters.DataTableDemurageTableAdapter dataTableDemurageTableAdapter;
        private library_system.UmAliDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dataTableDemurageBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox memNumberTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox memberTypeTextBox;
        private System.Windows.Forms.TextBox catTextBox;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.TextBox borDateTextBox;
        private System.Windows.Forms.TextBox DueDateTextBox;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox LateDaystextBox;
        private System.Windows.Forms.MaskedTextBox returnDateTextBox;
        private System.Windows.Forms.TextBox BorIDtextBox;
        private System.Windows.Forms.MaskedTextBox demurageTextBox;
        private library_system.UmAliDataSetTableAdapters.BookTableAdapter bookTableAdapter;
    }
}