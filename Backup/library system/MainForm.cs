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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBook frmBook = new FormBook();
            frmBook.MdiParent = this;
            frmBook.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategory frmCat = new FormCategory();
            frmCat.MdiParent = this;
            frmCat.Show();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMembers frmMem = new FormMembers();
            frmMem.MdiParent = this;
            frmMem.Show();
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBorrow frmBor = new FormBorrow();
            frmBor.MdiParent = this;
            frmBor.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormLogin frmlogin = new FormLogin();
            if (frmlogin.ShowDialog() == DialogResult.Abort)
                this.Close();
            else
            {
                UserNameToolstrip.Text = this.tableUserTableAdapter.GetUserNameByID(Program.UserID);
            }

            this.tableFormPermissionsTableAdapter.FillByUserID(umAliDataSet.TableFormPermissions, Program.UserID);
            for (int i = 0; i < this.umAliDataSet.TableFormPermissions.Rows.Count; i++)
            {
                string FormEngName = this.umAliDataSet.TableFormPermissions.Rows[i]["FormEnglishName"].ToString();
                MainmenuStrip.Items[FormEngName].Visible = true;
            }
        }

        private void MenuSearch_Click(object sender, EventArgs e)
        {
            FormSearch frmSearch = new FormSearch();
            frmSearch.MdiParent = this;
            frmSearch.Show();
        }

        private void MenuDemurage_Click(object sender, EventArgs e)
        {
            FormDemurrage frmDem = new FormDemurrage();
            frmDem.MdiParent = this;
            frmDem.Show();
        }


    }
}
