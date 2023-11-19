using System;
using System.Data.SqlClient;

namespace Practical_07B
{
    public partial class Practical_07B : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"ConnectionString";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            string query = "SELECT Address FROM Student WHERE Id = " + TextBox1.Text;
            cmd.Connection = conn;
            cmd.CommandText = query;
            string city = cmd.ExecuteScalar().ToString();
            Result.Text = "<b>City: </b>" + city;
            conn.Close();
        }
    }
}