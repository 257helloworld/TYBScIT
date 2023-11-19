using System;
using System.Data.SqlClient;

namespace Practical_06B
{
    public partial class Practical_06B : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection();
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"ConnectionString";
        }

        protected void getData_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM Student WHERE Id = " + idTextbox.Text;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Result.Text = "<b>Name: </b>" + dr[1] + "<br>" + "<b>Address: </b>" + dr[2];
            }
            conn.Close();
        }
    }
}