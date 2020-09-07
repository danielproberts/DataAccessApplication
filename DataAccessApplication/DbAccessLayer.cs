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
                SqlConnection connection = new SqlConnection(connString);
                connection.Open();
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
            connection.Close();
            return count;
        }

        public DataTable getCustomerNames(BusinessLayer busProc)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = busProc.dbSession.activeConn;
            command.Connection.Open();
            command.CommandText = "SELECT CompanyName FROM customers";
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            command.Connection.Close();

            return dt;
        }
    }
}

