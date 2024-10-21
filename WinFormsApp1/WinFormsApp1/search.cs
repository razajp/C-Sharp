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

namespace WinFormsApp1
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }
        SqlConnection sqlconn;
        conn conn = new conn();
        Form1 form1;
        private void search_Load(object sender, EventArgs e)
        {
            conn conn = new conn();
            string query = "select * from add_user";
            DataTable dt = conn.fetch(query);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
