using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataAccessApplication
{
    class DbAccessLayer
    {
        public DbAccessLayer(string connString)
        {
            try
            {
                SqlConnection connection = new SqlConnection();

                connection.ConnectionString = connString;
                connection.Open();

                //lblStatusBar.Text = "Connection Successful";
                //lblStatus.Text = "Connected to " + database + " database.";
                this.activeConn = connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, " + ex);
            }
        }
        SqlConnection activeConn;
    }
}

