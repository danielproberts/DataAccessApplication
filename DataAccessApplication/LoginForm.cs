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
        public static BusinessLayer busProc;
        public LoginForm()
        {
            InitializeComponent();
            boxServerList.SelectedIndex = 0;
            boxDatabaseList.SelectedIndex = 0;
            txtUserName.Select();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                string datasource = boxServerList.Text;
                string database = boxDatabaseList.Text;
                string username = txtUserName.Text;
                string password = txtPassword.Text;
                LoginForm.busProc = new BusinessLayer(datasource, database, username, password);
                Program.connString = busProc.generateConnString(datasource, database, username, password);
                if (LoginForm.busProc.isLoggedIn == true)
                {
                    this.Hide();
                    Form1 mainForm = new Form1();
                    mainForm.MdiParent = this.MdiParent;
                    mainForm.Show();
                }
                else
                {
                    Console.WriteLine("Unable to login.");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
