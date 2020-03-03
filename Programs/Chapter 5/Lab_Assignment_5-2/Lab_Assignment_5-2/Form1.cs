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
    public partial class frmAuthors : Form
    {
        OleDbConnection booksConnection;
        OleDbCommand authorsCommand;
        OleDbDataAdapter authorsAdapter;
        DataTable authorsTable;
        CurrencyManager authorsManager;
        public frmAuthors()
        {
            InitializeComponent();
        }

        private void FrmAuthors_Load(object sender, EventArgs e)
        {
            try
            {
                // connect to books database
                booksConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = E:\\GitHub\\CSharp-Database\\Programs\\Chapter 5\\BooksDB.accdb");
                booksConnection.Open();
                // establish command object
                authorsCommand = new OleDbCommand("Select * from Authors ORDER BY Author", booksConnection);
                // establish data adapter/data table
                authorsAdapter = new OleDbDataAdapter();
                authorsAdapter.SelectCommand = authorsCommand;
                authorsTable = new DataTable();
                authorsAdapter.Fill(authorsTable);
                // bind controls to data table
                txtAuthorID.DataBindings.Add("Text", authorsTable, "Au_ID");
                txtAuthorName.DataBindings.Add("Text", authorsTable, "Author");
                txtYearBorn.DataBindings.Add("Text", authorsTable, "Year_Born");
                // establish currency manager
                authorsManager = (CurrencyManager)this.BindingContext[authorsTable];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error establishing Authors table.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Show();
            SetState("View");


        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (authorsManager.Position == 0)
            {
                Console.Beep();
            }
            authorsManager.Position--;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (authorsManager.Position == authorsManager.Count - 1)
            {
                Console.Beep();
            }
            authorsManager.Position++;
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

        private void BtnDone_Click(object sender, EventArgs e)
        {

        }
        private void SetState(string appState)
        {
            switch (appState)
            {
                case "View":
                    txtAuthorID.BackColor = Color.White;
                    txtAuthorID.ForeColor = Color.Black;
                    txtAuthorName.ReadOnly = true;
                    txtYearBorn.ReadOnly = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnAddNew.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDone.Enabled = true;
                    txtAuthorName.Focus();
                    break;
                default: // Add or Edit if not View
                    txtAuthorID.BackColor = Color.Red;
                    txtAuthorID.ForeColor = Color.White;
                    txtAuthorName.ReadOnly = false;
                    txtYearBorn.ReadOnly = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnAddNew.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnDone.Enabled = false;
                    txtAuthorName.Focus();
                    break;
            }
        }

        private void TxtYearBorn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (int)e.KeyChar == 8)
            {
                //Acceptable keystrokes
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 13)
            {
                txtAuthorName.Focus();
            }
            else
            {
                e.Handled = true;
                Console.Beep();
            }


        }

        private bool ValidateData()
        {
            string message = "";
            int inputYear, currentYear;
            bool allOK = true;
            // Check for name
            if (txtAuthorName.Text.Trim().Equals(""))
            {
                message = "You must enter an Author Name." + "\r\n";
                txtAuthorName.Focus();
                allOK = false;
            }
            // Check length and range on Year Born
            if (!txtYearBorn.Text.Trim().Equals(""))
            {
                inputYear = Convert.ToInt32(txtYearBorn.Text);
                currentYear = DateTime.Now.Year;
                if (inputYear > currentYear || inputYear < currentYear - 150)
                {
                    message += "Year born must be between " + (currentYear - 150).ToString() + " and " + currentYear.ToString();
                    txtYearBorn.Focus();
                    allOK = false;
                }
            }
            if (!allOK)
            {
                MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return (allOK);
        }

        private void TxtAuthorName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                txtYearBorn.Focus();
            }

        }
    }
}
