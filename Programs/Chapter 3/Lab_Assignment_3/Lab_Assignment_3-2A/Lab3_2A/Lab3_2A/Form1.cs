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

namespace Lab3_2A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbCommand tutorCommand;
        OleDbConnection programmingConnection;
        OleDbDataAdapter tutorAdapter;
        DataTable tutorTable;
        CurrencyManager tutorManager;
        private void Form1_Load(object sender, EventArgs e)
        {
            // connect to books database
            programmingConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = E:\\GitHub\\CSharp-Database\\Programs\\Chapter 3\\Programming.accdb");
            //open the connection
            programmingConnection.Open();
            // establish command object
            tutorCommand = new OleDbCommand("Select * from Tutor", programmingConnection);
            // establish data adapter/data table
            tutorAdapter = new OleDbDataAdapter();
            tutorAdapter.SelectCommand = tutorCommand;
            tutorTable = new DataTable();
            tutorAdapter.Fill(tutorTable);
            // bind controls to data table
            txtTutorID.DataBindings.Add("Text", tutorTable, "TutorID");
            txtFName.DataBindings.Add("Text", tutorTable, "FirstName");
            txtLName.DataBindings.Add("Text", tutorTable, "LastName");
            txtMajor.DataBindings.Add("Text", tutorTable, "Major");
            txtYIS.DataBindings.Add("Text", tutorTable, "YearInSchool");
            txtSchool.DataBindings.Add("Text", tutorTable, "School");
            txtHireD.DataBindings.Add("Text", tutorTable, "HireDate");
            // establish currency manager
            tutorManager = (CurrencyManager)BindingContext[tutorTable];
            //close the connection
            programmingConnection.Close();
            //dispose of the connection object
            programmingConnection.Dispose();
            tutorCommand.Dispose();
            tutorAdapter.Dispose();
            tutorTable.Dispose();

        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            tutorManager.Position = 0;
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            tutorManager.Position--;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            tutorManager.Position++;
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            tutorManager.Position = tutorManager.Count - 1;
        }
    }
}
