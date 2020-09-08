using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessApplication
{
    class BusinessLayer
    {
        public DbAccessLayer dbSession;
        public BusinessLayer()
        {
            this.dbSession = ConnectToDb();
            this.dbSession.activeConn.Close();

        }
        private DbAccessLayer ConnectToDb()
        {
            string connString = generateConnString();
            DbAccessLayer dbSession = new DbAccessLayer(connString);
            return dbSession;
        }

        public string generateConnString()
        {
            var datasource = @"DANIELROBERFA92\SQLEXPRESS";//your server
            var database = "Northwind"; //your database name
            var username = "droberts";
            var password = "northwind";

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
