using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessApplication
{
    public partial class AppContainer : Form
    {
        public AppContainer()
        {
            InitializeComponent();
        }

        private void AppContainer_MdiChildActivate(Object sender, EventArgs e)
        {
            if(Program.connString != null)
            { 
                updateConnectionStatus();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.MdiParent = this;
            login.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void updateConnectionStatus()
        {
            string stsConnString = Program.connString;
            string database;
            string username;

            int dFrom = stsConnString.IndexOf("Initial Catalog=") + "Initial Catalog=".Length;
            int dTo = stsConnString.LastIndexOf(";Persist");
            int uFrom = stsConnString.IndexOf("User ID=") + "User ID=".Length;
            int uTo = stsConnString.LastIndexOf(";Password=");

            database = stsConnString.Substring(dFrom, dTo - dFrom);
            username = stsConnString.Substring(uFrom, uTo - uFrom);
            this.stsConnected.Text = "Connected to " + database + " Database as " + username + ".";
        }
    }
}
