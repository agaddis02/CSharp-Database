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

namespace Lab_Assignment_4
{
    public partial class frmSQLTester : Form
    {
        OleDbConnection booksConnection;
        public frmSQLTester()
        {
            InitializeComponent();
        }

        private void FrmSQLTester_Load(object sender, EventArgs e)
        {
            // connect to books database
            booksConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = E:\\GitHub\\CSharp-Database\\Programs\\Chapter 4\\BooksDB.accdb");
            booksConnection.Open();

        }

        private void FrmSQLTester_FormClosing(object sender, FormClosingEventArgs e)
        {
            booksConnection.Close();
            booksConnection.Dispose();

        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            OleDbCommand resultsCommand = null;
            OleDbDataAdapter resultsAdapter = new OleDbDataAdapter();
            DataTable resultsTable = new DataTable();
            try
            {
                // establish command object and data adapter
                resultsCommand = new OleDbCommand(txtSQLTester.Text, booksConnection);
                resultsAdapter.SelectCommand = resultsCommand;
                resultsAdapter.Fill(resultsTable);
                // bind grid view to data table
                grdSQLTester.DataSource = resultsTable;
                lblRecords.Text = resultsTable.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Processing SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            resultsCommand.Dispose();
            resultsAdapter.Dispose();
            resultsTable.Dispose();

        }
    }
}
