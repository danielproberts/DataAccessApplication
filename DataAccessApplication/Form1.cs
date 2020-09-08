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
    public partial class Form1 : Form
    {
        private BusinessLayer busProc = new BusinessLayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                busProc = new BusinessLayer();
                lblStatus.Text = "Connection Successful";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error, " +ex);
            }
        }

        private void btnViewDatabase_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busProc.getCustomerNames(busProc);
        }

        private void btnCountRecords_Click(object sender, EventArgs e)
        {
            lblCount.Text = "Number of Records: " + busProc.CountRecords(busProc).ToString();
        }
    }
}
