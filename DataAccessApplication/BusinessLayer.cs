using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DataAccessApplication
{
    public class BusinessLayer
    {
        public DbAccessLayer dbSession;

        public bool isLoggedIn = false;

        public BusinessLayer(string datasource, string database, string username, string password)
        {
            string connString = generateConnString(datasource, database, username, password);
            this.dbSession = ConnectToDb(connString);
            using (dbSession.activeConn)
            {
                try
                {
                    if (dbSession.activeConn != null)
                    {
                        isLoggedIn = true;
                        Program.connString = connString;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Invalid Username or Password");
                    Console.WriteLine("Error, " + ex);
                }
            }
        }

        private DbAccessLayer ConnectToDb(string connString)
        {
            DbAccessLayer dbSession = new DbAccessLayer(connString);
            return dbSession;
        }

        public string generateConnString(string datasource, string database, string username, string password)
        {
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            return connString;
        }

        public DataTable getRecords(BusinessLayer busProc, string tableName)
        {
            return busProc.dbSession.getRecords(busProc, tableName);
        }

        public int CountRecords(BusinessLayer busProc, string tableName)
        {
            return busProc.dbSession.CountRecords(busProc, tableName);
        }
    }
}
