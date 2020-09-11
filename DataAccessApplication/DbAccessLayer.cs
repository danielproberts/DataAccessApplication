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
            SqlConnection connection = new SqlConnection(connString);
            try
            {
                connection.Open();
                this.activeConn = connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Username or Password");
                Console.WriteLine("Error, " + ex);
            }
        }
        public int CountRecords(BusinessLayer busProc)
        {
            if (busProc.dbSession.activeConn.State == ConnectionState.Closed)
            {
                busProc.dbSession.activeConn.Open();
            }
            SqlCommand command = new SqlCommand();
            command.Connection = busProc.dbSession.activeConn;
            command.CommandText = "SELECT COUNT(*) FROM customers";
            int count = (int)command.ExecuteScalar();
            busProc.dbSession.activeConn.Close();
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

