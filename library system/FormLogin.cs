using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace library_system
{
    
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'umAliDataSet.TableUser' table. You can move, or remove it, as needed.
            this.tableUserTableAdapter.Fill(this.umAliDataSet.TableUser);
            

      }

       
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (UserTypecomboBox.SelectedIndex < 0)
            {
                errorProvider1.SetError(UserTypecomboBox, "Please Choice User Type");
                UserTypecomboBox.Focus();
                return;

            }
            else
                errorProvider1.SetError(UserTypecomboBox, string.Empty);
            if (UserNametextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(UserNametextBox, "Please Enter User Name");
                UserNametextBox.Focus();
                return;
            }
            else
                errorProvider1.SetError(UserNametextBox, string.Empty);

            if (PasswordtextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(PasswordtextBox, "Please Enter Password");
                PasswordtextBox.Focus();
                return;
            }
            else
                errorProvider1.SetError(PasswordtextBox, string.Empty);
            
            int? Res = (int?)this.tableUserTableAdapter.CheckUser(UserTypecomboBox.SelectedValue.ToString(),UserNametextBox.Text.Trim(),PasswordtextBox.Text.Trim());
            
            if (Res.HasValue && Res.Value > 0)
            {
                Program.UserID = (int)this.tableUserTableAdapter.GetUserID(UserTypecomboBox.SelectedValue.ToString(), UserNametextBox.Text.Trim(), PasswordtextBox.Text.Trim());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("User Name or Password is not correct", "Login");

            }
           
        }

        }
    }


