using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Lab_Assignment_5_3
{
    public partial class frmTitles : Form
    {
        OleDbConnection booksConnection;
        OleDbCommand titlesCommand;
        OleDbDataAdapter titlesAdapter;
        DataTable titlesTable;
        CurrencyManager titlesManager;
        public frmTitles()
        {
            InitializeComponent();
        }

        private void FrmTitles_Load(object sender, EventArgs e)
        {
            try
            {
                // connect to books database
                booksConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = E:\\GitHub\\CSharp-Database\\Programs\\Chapter 5\\BooksDB.accdb");
                booksConnection.Open();
                // establish command object
                titlesCommand = new OleDbCommand("Select * from Titles ORDER BY Title", booksConnection);
                // establish data adapter/data table
                titlesAdapter = new OleDbDataAdapter();
                titlesAdapter.SelectCommand = titlesCommand;
                titlesTable = new DataTable();
                titlesAdapter.Fill(titlesTable);
                // bind controls to data table
                txtTitle.DataBindings.Add("Text", titlesTable, "Title");
                txtYear_Published.DataBindings.Add("Text", titlesTable, "Year_Published");
                txtISBN.DataBindings.Add("Text", titlesTable, "ISBN");
                txtPubID.DataBindings.Add("Text", titlesTable, "PubID");
                txtDescription.DataBindings.Add("Text", titlesTable, "Description");
                txtNotes.DataBindings.Add("Text", titlesTable, "Notes");
                txtSubject.DataBindings.Add("Text", titlesTable, "Subject");
                txtComments.DataBindings.Add("Text", titlesTable, "Comments");
                // establish currency manager
                titlesManager = (CurrencyManager)this.BindingContext[titlesTable];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error establishing Authors table.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Show();
            SetState("View");

        }

        private void FrmTitles_FormClosing(object sender, FormClosingEventArgs e)
        {
            // close the connection
            booksConnection.Close();
            // dispose of the objects
            booksConnection.Dispose();
            titlesCommand.Dispose();
            titlesAdapter.Dispose();
            titlesTable.Dispose();

        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (titlesManager.Position == 0)
            {
                Console.Beep();
            }
            titlesManager.Position--;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (titlesManager.Position == titlesManager.Count - 1)
            {
                Console.Beep();
            }
            titlesManager.Position++;
        }
        private void SetState(string appState)
        {
            switch (appState)
            {
                case "View":
                    txtTitle.BackColor = Color.White;
                    txtTitle.ForeColor = Color.Black;
                    txtTitle.ReadOnly = true;
                    txtYear_Published.ReadOnly = true;
                    txtISBN.ReadOnly = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    //btnAddNew.Enabled = true;
                    //btnSave.Enabled = false;
                    //btnCancel.Enabled = false;
                    //btnEdit.Enabled = true;
                    //btnDelete.Enabled = true;
                    txtTitle.Focus();
                    break;
                default: // Add or Edit if not View
                    txtTitle.BackColor = Color.Red;
                    txtTitle.ForeColor = Color.Black;
                    txtTitle.ReadOnly = false;
                    txtYear_Published.ReadOnly = false;
                    txtISBN.ReadOnly = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    //btnAddNew.Enabled = false;
                    //btnSave.Enabled = true;
                    //btnCancel.Enabled = true;
                    //btnEdit.Enabled = false;
                    //btnDelete.Enabled = false;
                    txtTitle.Focus();
                    break;
            }
        }
        private bool ValidateData()
        {
            string message = "";
            int inputYear, currentYear;
            bool allOK = true;
            // Check for name
            if (txtISBN.Text.Trim().Equals(""))
            {
                message = "You must enter an ISBN." + "\r\n";
                txtISBN.Focus();
                allOK = false;
            }
            // Check length and range on Year Born
            if (!txtYear_Published.Text.Trim().Equals(""))
            {
                inputYear = Convert.ToInt32(txtYear_Published.Text);
                currentYear = DateTime.Now.Year;
                if (inputYear > currentYear || inputYear < currentYear - 150)
                {
                    message += "Year Published must be between " + (currentYear - 150).ToString() + " and " + currentYear.ToString();
                    txtYear_Published.Focus();
                    allOK = false;
                }
            }
            if (!allOK)
            {
                MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return (allOK);
        }

        private void TxtTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
                if ((int)e.KeyChar == 13)
                {
                    txtTitle.Focus();
                }

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            SetState("Edit");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }
            try
            {
                MessageBox.Show("Record saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetState("View");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            SetState("View");
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                SetState("Add");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult response;
            response = MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (response == DialogResult.No)
            {
                return;
            }
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtYear_Published_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (int)e.KeyChar == 8)
            {
                //Acceptable keystrokes
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 13)
            {
                txtTitle.Focus();
            }
            else
            {
                e.Handled = true;
                Console.Beep();
            }
        }
    }
}
