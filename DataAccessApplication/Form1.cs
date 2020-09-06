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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
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
                connection.Open();

                lblStatusBar.Text = "Connection Successful";
                lblStatus.Text = "Connected to " + database + " database.";

                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error, " +ex);
            }
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

            connection.ConnectionString = connString;
            connection.Open();

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT * FROM customers";

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            connection.Close();
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
            connection.Open();

            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandText = "SELECT COUNT(*) FROM customers";

            int count = (int)command.ExecuteScalar();
            lblCount.Text = count.ToString();
            connection.Close();
        }
    }
}
