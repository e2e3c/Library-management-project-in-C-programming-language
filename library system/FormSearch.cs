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
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        

        private void Form3_Load(object sender, EventArgs e)
        {

            this.catTableAdapter.Fill(this.umAliDataSet.Cat);
            catComboBox.SelectedIndex = -1;

        }

        private void search_Click(object sender, EventArgs e)
        {
            string QureySearch = string.Empty; //Varabile for Search Query

            string SqlConditions = string.Empty;// Varabile for Search Condition With (Where)

            if (BookIDtextBox.Text.Trim() != string.Empty) // Search by Book ID
            {
                if (SqlConditions == string.Empty) SqlConditions = " Where ";
                else SqlConditions += " AND ";
                SqlConditions += " BookID =" + BookIDtextBox.Text.Trim();
            }

            if (BookNametextBox.Text.Trim() != string.Empty)
            {
                if (SqlConditions == string.Empty) SqlConditions = " Where ";
                else SqlConditions += " AND ";
                SqlConditions += " BookName Like '%" + BookNametextBox.Text.Trim() + "%'"; //ability search part of book name
            }

            if (AuthertextBox.Text.Trim() != string.Empty)
            {
                if (SqlConditions == string.Empty) SqlConditions = " Where ";
                else SqlConditions += " AND ";
                SqlConditions += " Author Like '%" + AuthertextBox.Text.Trim() + "%'"; //ability search part of Auther
            }

            if (PublishertextBox.Text.Trim() != string.Empty)
            {
                if (SqlConditions == string.Empty) SqlConditions = " Where ";
                else SqlConditions += " AND ";
                SqlConditions += " Pub Like '%" + PublishertextBox.Text.Trim() + "%'"; //ability search part of Publisher
            }

            if (catComboBox.SelectedIndex >= 0)
            {
                if (SqlConditions == string.Empty) SqlConditions = " Where ";
                else SqlConditions += " AND ";
                SqlConditions += " CatID = " + catComboBox.SelectedValue.ToString(); //SelectedValue has CatID Value
            }
            QureySearch = "Select * from Book";
            QureySearch += SqlConditions;

            umAliDataSet.Book.Clear();// Clear Data in the dataTable before fill new query
            OleDbCommand Command = new OleDbCommand(QureySearch, new OleDbConnection(Properties.Settings.Default.UmAliConnectionString));
            //Command variable for search query
            this.bookTableAdapter.Adapter.SelectCommand = Command;
            this.bookTableAdapter.Adapter.Fill(umAliDataSet.Book);
            this.bookDataGridView.DataSource = umAliDataSet.Book; // Set DataTable to DataSource of DataGrid 
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        
    }
}
