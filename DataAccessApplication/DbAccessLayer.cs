using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessApplication
{
    class DbAccessLayer
    {
        public SqlConnection activeConn;
        public DbAccessLayer(string connString)
        {
            try
            {
                SqlConnection connection = new SqlConnection();

                connection.ConnectionString = connString;
                connection.Open();

                //mainForm.lblStatusBar.Text = "Connection Successful";
                //lblStatus.Text = "Connected to " + database + " database.";
                this.activeConn = connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, " + ex);
            }
        }
    
        public int CountRecords(SqlConnection connection)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT COUNT(*) FROM customers";

            int count = (int)command.ExecuteScalar();
            return count;
        }
    }
}

