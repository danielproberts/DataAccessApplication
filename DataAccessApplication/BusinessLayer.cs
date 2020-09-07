using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessApplication
{
    class BusinessLayer
    {
        public DbAccessLayer dbSession;
        public BusinessLayer()
        {
            this.dbSession = ConnectToDb();
        }
        private DbAccessLayer ConnectToDb()
        {
            string connString = generateConnString();
            DbAccessLayer dbSession = new DbAccessLayer(connString);
            return dbSession;
        }

        public int CountRecords(string conn)
        {
            DbAccessLayer dbSession = new DbAccessLayer(conn);
            return dbSession.CountRecords(dbSession.activeConn);
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
    }
}
