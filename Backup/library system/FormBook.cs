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
    public partial class FormBook : Form
    {
        public FormBook()
        {
            InitializeComponent();
        }

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.umAliDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'umAliDataSet.Cat' table. You can move, or remove it, as needed.
            this.catTableAdapter.Fill(this.umAliDataSet.Cat);
            // TODO: This line of code loads data into the 'umAliDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.umAliDataSet.Book);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.bookBindingSource.EndEdit();
                this.bookBindingSource.AddNew();
            }
            catch
            {
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.bookBindingSource.EndEdit();
                this.bookBindingSource.RemoveCurrent();
            }
            catch
            {
            }
        }
    }
}
