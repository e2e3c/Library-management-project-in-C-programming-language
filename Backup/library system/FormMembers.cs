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
    public partial class FormMembers : Form
    {
        public FormMembers()
        {
            InitializeComponent();
        }

        private void memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.umAliDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'umAliDataSet.MamberType' table. You can move, or remove it, as needed.
            this.mamberTypeTableAdapter.Fill(this.umAliDataSet.MamberType);
            // TODO: This line of code loads data into the 'umAliDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.umAliDataSet.Member);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.memberBindingSource.EndEdit();
                this.memberBindingSource.AddNew();
            }
            catch
            {
                
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.memberBindingSource.EndEdit();
                this.memberBindingSource.RemoveCurrent();
            }
            catch
            {

            }
        }

     

     
    }
}
