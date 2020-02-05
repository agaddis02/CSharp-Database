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

namespace Lab_Assignment_3_1
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
        // E:\\GitHub\\CSharp-Database\\Programs\\Chapter 3\\books.accdb

        private void FrmTitles_Load(object sender, EventArgs e)
        {
            // connect to books database
            booksConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = E:\\GitHub\\CSharp-Database\\Programs\\Chapter 3\\books.accdb");
            //open the connection
            booksConnection.Open();
            // establish command object
            titlesCommand = new OleDbCommand("Select * from Titles", booksConnection);
            // establish data adapter/data table
            titlesAdapter = new OleDbDataAdapter();
            titlesAdapter.SelectCommand = titlesCommand;
            titlesTable = new DataTable();
            titlesAdapter.Fill(titlesTable);
            // bind controls to data table
            txtTitle.DataBindings.Add("Text", titlesTable, "Title");
            txtYearPublished.DataBindings.Add("Text", titlesTable, "Year_Published");
            txtISBN.DataBindings.Add("Text", titlesTable, "ISBN");
            txtPubID.DataBindings.Add("Text", titlesTable, "PubID");
            // establish currency manager
            titlesManager = (CurrencyManager)BindingContext[titlesTable];
            //close the connection
            booksConnection.Close();
            //dispose of the connection object
            booksConnection.Dispose();
            titlesCommand.Dispose();
            titlesAdapter.Dispose();
            titlesTable.Dispose();
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            titlesManager.Position = 0;
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            titlesManager.Position--;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            titlesManager.Position++;
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            titlesManager.Position = titlesManager.Count - 1;
        }
    }
}
