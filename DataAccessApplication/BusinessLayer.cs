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
    class BusinessLayer
    {
        public DbAccessLayer dbSession;

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
                        this.dbSession.activeConn.Close();
                        MessageBox.Show("Login Successful");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Invalid Username or Password");
                    Console.WriteLine("Error, " + ex);
                }
            }
        }

        /*
        public BusinessLayer()
        {
            this.dbSession = ConnectToDb();
            this.dbSession.activeConn.Close();
        }
        */
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

        public DataTable getCustomerNames(BusinessLayer busProc)
        {
            return busProc.dbSession.getCustomerNames(busProc);
        }

        public int CountRecords(BusinessLayer busProc)
        {
            return busProc.dbSession.CountRecords(busProc);
        }
    }
}
