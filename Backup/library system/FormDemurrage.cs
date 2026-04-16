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
    public partial class FormDemurrage : Form
    {
        public FormDemurrage()
        {
            InitializeComponent();
        }

      
        private void btnFind_Click(object sender, EventArgs e)
        {

            try
            {
                LateDaystextBox.Text = string.Empty;
                if (BookIDtextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Book ID", "Calculate Demurrage");
                    return;
                }
                this.dataTableDemurageTableAdapter.FillByBookID(this.umAliDataSet.DataTableDemurage, new System.Nullable<int>(((int)(System.Convert.ChangeType(BookIDtextBox.Text.Trim(), typeof(int))))));
                if (returnDateTextBox.MaskFull && demurageTextBox.Text.Trim() != string.Empty)
                {
                    returnDateTextBox.ReadOnly = true;
                    btnCalculate.Enabled = false;
                    LateDaystextBox.Text = CalaculeDays().ToString();
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dataTableDemurageBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (returnDateTextBox.MaskFull  && demurageTextBox.Text.Trim() != string.Empty)
            {
                returnDateTextBox.ReadOnly = true;
                btnCalculate.Enabled = false;
                LateDaystextBox.Text = CalaculeDays().ToString();
            }
            else
            {
                returnDateTextBox.ReadOnly = false;
                btnCalculate.Enabled = true;
                LateDaystextBox.Text = string.Empty;
            }

        }

        private int CalaculeDays()
        {
            try
            {
                    DateTime ReturnDate = Convert.ToDateTime(returnDateTextBox.Text);
                    DateTime DueDate = Convert.ToDateTime(DueDateTextBox.Text.Trim());
                    return ReturnDate.Subtract(DueDate).Days;
             
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return 0;
            }


        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (returnDateTextBox.MaskFull)
                {

                    int LateDays = CalaculeDays();
                    int Demurrage = 0;
                    if (LateDays >= 0)
                    {
                        Demurrage = LateDays * 2;
                    }

                    demurageTextBox.Text = Demurrage.ToString();
                    LateDaystextBox.Text = LateDays.ToString();
                    this.dataTableDemurageTableAdapter.UpdateDemurage(returnDateTextBox.Text, Demurrage.ToString(), Convert.ToInt32(BorIDtextBox.Text.Trim()));
                  
                    this.bookTableAdapter.UpdateStatusNotBorrow();
                    btnCalculate.Enabled = false;
                    returnDateTextBox.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Please Enter Return Date", "Calculate Demurrage");
                }
             
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
          
        }

        private void FormDemurrage_Load(object sender, EventArgs e)
        {
            BookIDtextBox.Select();
        }
    }
}
