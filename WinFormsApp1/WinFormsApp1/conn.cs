using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class conn
    {
        SqlConnection sqlconn;
        public conn()
        {
            sqlconn = new SqlConnection("Server=HASAN-RAZA\\SQLEXPRESS; User=Hasan_Raza; Password=1253; Database=first; ");
        }
        public DataTable fetch(string query)
        {
            DataTable dt = new DataTable();
            sqlconn.Open();
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            sqlconn.Close();
            return dt;
        }
    }
}
