using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataAccessApplication
{
    public partial class Form1 : Form
    {
        private DbAccessLayer _dbSession;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //try
            //{

            SqlConnection connection = new SqlConnection();

            var datasource = @"DANIELROBERFA92\SQLEXPRESS";//your server
            var database = "Northwind"; //your database name
            var username = "droberts";
            var password = "northwind";

            //your connection string 
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            _dbSession = new DbAccessLayer(connString);
            /*
            connection.ConnectionString = connString;
            connection.Open();
            */
            //dbSession.activeConn.Open();
            lblStatusBar.Text = "Connection Successful";
            lblStatus.Text = "Connected to " + database + " database.";
            _dbSession.activeConn.Close();
            /*
            connection.Close();
        }
        catch(Exception ex)
        {
            MessageBox.Show("Error, " +ex);
        }
            */
        }

        private void btnViewDatabase_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            var datasource = @"DANIELROBERFA92\SQLEXPRESS";//your server
            var database = "Northwind"; //your database name
            var username = "droberts";
            var password = "northwind";

            //your connection string 
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            //DbAccessLayer dbSession = new DbAccessLayer(connString);
            //Constructor Start
            //connection.ConnectionString = connString;
            //connection.Open();
            //dbSession.activeConn.Open();


            SqlCommand command = new SqlCommand();

            command.Connection = _dbSession.activeConn;
            command.CommandText = "SELECT * FROM customers";

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            _dbSession.activeConn.Close();
        }

        private void btnCountRecords_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();

            var datasource = @"DANIELROBERFA92\SQLEXPRESS";//your server
            var database = "Northwind"; //your database name
            var username = "droberts";
            var password = "northwind";

            //your connection string 
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            connection.ConnectionString = connString;


            lblCount.Text = _dbSession.CountRecords(_dbSession.activeConn).ToString();
            connection.Close();
        }

        public event System.Windows.Forms.FormClosingEventHandler FormClosing;

    }
}
