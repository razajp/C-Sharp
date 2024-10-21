using System.Data.SqlClient;
using System.Diagnostics.Metrics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection;
        search search;
        private void submit_Click(object sender, EventArgs e)
        {
            string username = usertxbx.Text.Trim();
            string email = emailtxbx.Text.Trim();
            string address = addtxbx.Text.Trim();
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter a username");
                usertxbx.Focus();
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter a email");
                emailtxbx.Focus();
            }
            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please enter a address");
                addtxbx.Focus();
            }
            sqlConnection = new SqlConnection("Server=HASAN-RAZA\\SQLEXPRESS; User=Hasan_Raza; Password=1253; Database=first; ");
            sqlConnection.Open();
            string query = "insert into add_user values('" + username + "', '" + email + "', '" + address + "')";
            SqlCommand cm = new SqlCommand(query, sqlConnection);
            cm.ExecuteNonQuery();
            MessageBox.Show("user added");
            sqlConnection.Close();
            usertxbx.Text = string.Empty;
            emailtxbx.Text = string.Empty;
            addtxbx.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search = new search();
            this.Hide();
            search.Show();
        }
    }
}
