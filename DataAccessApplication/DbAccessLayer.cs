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
    public class DbAccessLayer
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
            /*
            if (LoginForm.busProc.dbSession.activeConn.State == ConnectionState.Closed)
            {
                LoginForm.busProc.dbSession.activeConn.Open();
            }
            */
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(Program.connString);
            command.Connection = connection;
            command.Connection.Open();
            command.CommandText = "SELECT COUNT(*) FROM customers";
            int count = (int)command.ExecuteScalar();
            command.Connection.Close();
            //busProc.dbSession.activeConn.Close();
            return count;
        }
        //{
        /*
        if (busProc.dbSession.activeConn.State == ConnectionState.Closed)
        {
            busProc.dbSession.activeConn.Open();
        }
        SqlCommand command = new SqlCommand();
        command.Connection.ConnectionString = LoginForm.busProc.dbSession.activeConn.ConnectionString;
        //command.Connection.Open();
        command.CommandText = "SELECT COUNT(*) FROM customers";
        int count = (int)command.ExecuteScalar();
        //command.Connection.Close();
        return count;
        */
        //}
        public DataTable getCustomerNames(BusinessLayer busProc)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(Program.connString);
            command.Connection = connection;
            command.CommandText = "SELECT CompanyName FROM customers";
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //command.Connection.Close();
            return dt;
        }
    }
}

