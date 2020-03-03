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


namespace Lab_Assignment_5_1
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

            this.Show();
            SetState("View");


        }

        private void FrmAuthors_FormClosing(object sender, FormClosingEventArgs e)
        {
            // close the connection
            booksConnection.Close();
            // dispose of the objects
            booksConnection.Dispose();
            authorsCommand.Dispose();
            authorsAdapter.Dispose();
            authorsTable.Dispose();

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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Record saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SetState("View");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult response;
            response = MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (response == DialogResult.No)
            {
                return;
            }

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

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            SetState("Add");
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            SetState("Edit");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            SetState("View");
        }
    }
}
