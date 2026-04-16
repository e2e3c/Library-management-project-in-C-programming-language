using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace library_system
{
    public partial class FormBorrow : Form
    {
        public FormBorrow()
        {
            InitializeComponent();
        }

        private void borrowBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.borrowBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.umAliDataSet);
            this.bookTableAdapter.UpdateStatusBorrow();

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'umAliDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.umAliDataSet.Book);
            // TODO: This line of code loads data into the 'umAliDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.umAliDataSet.Member);
            // TODO: This line of code loads data into the 'umAliDataSet.Cat' table. You can move, or remove it, as needed.
            this.catTableAdapter.Fill(this.umAliDataSet.Cat);
            // TODO: This line of code loads data into the 'umAliDataSet.borrow' table. You can move, or remove it, as needed.
            this.borrowTableAdapter.Fill(this.umAliDataSet.borrow);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.borrowBindingSource.EndEdit();
                this.borrowBindingSource.AddNew();
            }
            catch
            {
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.borrowBindingSource.EndEdit();
                this.borrowBindingSource.RemoveCurrent();
            }
            catch
            {
            }
        }
    }
}
