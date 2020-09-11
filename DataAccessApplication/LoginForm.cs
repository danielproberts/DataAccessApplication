using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            boxServerList.SelectedIndex = 0;
            boxDatabaseList.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                string datasource = @"DANIELROBERFA92\SQLEXPRESS";//your server
                string database = "northwind";
                string username = txtUserName.Text;
                string password = txtPassword.Text;

                try
                {
                    BusinessLayer busProc = new BusinessLayer(datasource, database, username, password);
                }
                catch (SqlException ex)
                {
                    //strLoginStatus.Text = "Bad Username or Password";
                    Console.WriteLine("Error " + ex);
                }
            }
        }
    }
}
