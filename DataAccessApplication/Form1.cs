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
        //private BusinessLayer busProc = new BusinessLayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int count = boxTableSelect.Items.Count;
            for(int i = 0; i <= count; count--)
            {
                boxTableSelect.SelectedIndex = i;
                if (LoginForm.busProc.CountRecords(LoginForm.busProc, boxTableSelect.SelectedItem.ToString()) == 0)
                {
                    boxTableSelect.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
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
