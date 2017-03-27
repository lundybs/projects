using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmployeeProjectWindowsAppPrototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDataSet();
        }

        private void FillDataSet()
        {

            //1. Make a Connection
            System.Data.SqlClient.SqlConnection objCon;
            objCon = new System.Data.SqlClient.SqlConnection();
            objCon.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = EmployeeProjects; Integrated Security=True;";
            objCon.Open();

            //2. Issue a Command
            System.Data.SqlClient.SqlCommand objCmd;
            objCmd = new System.Data.SqlClient.SqlCommand();
            objCmd.Connection = objCon;
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.CommandText = @"pSelEmployeeProjectHours";

            //3. Process the Results
            System.Data.DataSet objDS = new DataSet();
            System.Data.SqlClient.SqlDataAdapter objDA;
            objDA = new System.Data.SqlClient.SqlDataAdapter();
            objDA.SelectCommand = objCmd;
            objDA.Fill(objDS); // objCon.Open() is not needed!
            dataGridView1.DataSource = objDS.Tables[0];

            //4. Clean up code
            objCon.Close();
            dataGridView1.Refresh();
        }

        private void refeshDataGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This wont work because it pulls data from the data set and not the database!
            dataGridView1.Refresh();

            //This works of course because it reloads all of the data and rebinds it.
            FillDataSet();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
