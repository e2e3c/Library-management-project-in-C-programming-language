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
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }

        private void catBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.catBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.umAliDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'umAliDataSet.Cat' table. You can move, or remove it, as needed.
            this.catTableAdapter.Fill(this.umAliDataSet.Cat);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.catBindingSource.EndEdit();
                this.catBindingSource.AddNew();
            }
            catch
            {
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.catBindingSource.EndEdit();
                this.catBindingSource.RemoveCurrent();
            }
            catch
            {
            }
        }
    }
}
