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

namespace Lab_Assignment_5_4
{
    public partial class frmPublishers : Form

    {
        OleDbConnection booksConnection;
        OleDbCommand publishersCommand;
        OleDbDataAdapter publishersAdapter;
        DataTable publishersTable;
        CurrencyManager publishersManager;

        public frmPublishers()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // connect to books database
                booksConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = E:\\GitHub\\CSharp-Database\\Programs\\Chapter 5\\BooksDB.accdb");
                booksConnection.Open();
                // establish command object
                publishersCommand = new OleDbCommand("SELECT * FROM Publishers ORDER BY Name", booksConnection);
                // establish data adapter/data table
                publishersAdapter = new OleDbDataAdapter();
                publishersAdapter.SelectCommand = publishersCommand;
                publishersTable = new DataTable();
                publishersAdapter.Fill(publishersTable);
                // bind controls to data table
                txtPubID.DataBindings.Add("Text", publishersTable, "PubID");
                txtPubName.DataBindings.Add("Text", publishersTable, "Name");
                txtCompanyName.DataBindings.Add("Text", publishersTable, "Company_Name");
                txtPubAddress.DataBindings.Add("Text", publishersTable, "Address");
                txtPubCity.DataBindings.Add("Text", publishersTable, "City");
                txtPubState.DataBindings.Add("Text", publishersTable, "State");
                txtPubZip.DataBindings.Add("Text", publishersTable, "Zip");
                txtPubTelephone.DataBindings.Add("Text", publishersTable, "Telephone");
                txtPubFAX.DataBindings.Add("Text", publishersTable, "FAX");
                txtPubComments.DataBindings.Add("Text", publishersTable, "Comments");
                // establish currency manager
                publishersManager = (CurrencyManager)this.BindingContext[publishersTable];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error establishing Publishers table.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Show();
            SetState("View");

        }

        private void FrmPublishers_FormClosing(object sender, FormClosingEventArgs e)
        {
            // close the connection
            booksConnection.Close();
            // dispose of the objects
            booksConnection.Dispose();
            publishersCommand.Dispose();
            publishersAdapter.Dispose();
            publishersTable.Dispose();

        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (publishersManager.Position == 0)
            {
                Console.Beep();
            }
            publishersManager.Position--;

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (publishersManager.Position == publishersManager.Count - 1)
            {
                Console.Beep();
            }
            publishersManager.Position++;

        }
        private void SetState(string appState)
        {
            switch (appState)
            {
                case "View":
                    txtPubID.BackColor = Color.White;
                    txtPubID.ForeColor = Color.Black;
                    txtPubName.ReadOnly = true;
                    txtCompanyName.ReadOnly = true;
                    txtPubAddress.ReadOnly = true;
                    txtPubCity.ReadOnly = true;
                    txtPubState.ReadOnly = true;
                    txtPubZip.ReadOnly = true;
                    txtPubTelephone.ReadOnly = true;
                    txtPubFAX.ReadOnly = true;
                    txtPubComments.ReadOnly = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnAddNew.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDone.Enabled = true;
                    txtPubName.Focus();
                    break;
                default: // Add or Edit if not View
                    txtPubID.BackColor = Color.Red;
                    txtPubID.ForeColor = Color.White;
                    txtPubName.ReadOnly = false;
                    txtCompanyName.ReadOnly = false;
                    txtPubAddress.ReadOnly = false;
                    txtPubCity.ReadOnly = false;
                    txtPubState.ReadOnly = false;
                    txtPubZip.ReadOnly = false;
                    txtPubTelephone.ReadOnly = false;
                    txtPubFAX.ReadOnly = false;
                    txtPubComments.ReadOnly = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnAddNew.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnDone.Enabled = false;
                    txtPubName.Focus();
                    break;

            }

        }
        private bool ValidateData()
        {
            string message = "";
            bool allOK = true;
            // Check for name
            if (txtPubName.Text.Trim().Equals(""))
            {
                message = "You must enter an Publisher Name." + "\r\n";
                txtPubName.Focus();
                allOK = false;
            }
            if (!allOK)
            {
                MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return (allOK);
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
    }
}
