using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataAccessApplication
{
    public partial class session : Form
    {
        public session()
        {
            InitializeComponent();
        }

        private void SessionWindow_Load(object sender, EventArgs e)
        {
            boxTableSelect.SelectedIndex = 0;
        }

        private void btnViewDatabase_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoginForm.busProc.getRecords(LoginForm.busProc, boxTableSelect.SelectedItem.ToString());
        }

        private void btnCountRecords_Click(object sender, EventArgs e)
        {
            lblCount.Text = LoginForm.busProc.CountRecords(LoginForm.busProc, boxTableSelect.SelectedItem.ToString()).ToString();
        }
    }
}
