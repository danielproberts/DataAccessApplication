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
        public int CountRecords(BusinessLayer busProc, string tableName)
        {
            try 
            {
                SqlCommand command = new SqlCommand();
                SqlConnection connection = new SqlConnection(Program.connString);
                command.Connection = connection;
                command.Connection.Open();
                command.CommandText = "SELECT COUNT(*) FROM " + tableName;
                int count = (int)command.ExecuteScalar();
                command.Connection.Close();
                return count;
            }
            catch(SqlException ex)
            {
                string caption = "Access Denied";
                string message = "You do not have permission to view this table.";
                MessageBoxButtons button = MessageBoxButtons.OK;
                DialogResult messageBox;
                messageBox = MessageBox.Show(message, caption, button);
                Console.WriteLine("Error " + ex);
                return 0;
            }
        }
        
        public DataTable getRecords(BusinessLayer busProc, string tableName)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection connection = new SqlConnection(Program.connString);
                command.Connection = connection;
                command.CommandText = "SELECT * FROM " + tableName;
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                string caption = "Access Denied";
                string message = "You do not have permission to view this table.";
                MessageBoxButtons button = MessageBoxButtons.OK;
                DialogResult messageBox;
                messageBox = MessageBox.Show(message, caption, button);
                Console.WriteLine("Error " + ex);
                return null;
            }
        }
    }
}

