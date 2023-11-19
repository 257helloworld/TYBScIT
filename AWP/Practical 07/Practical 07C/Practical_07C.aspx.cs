using System;
using System.Data.SqlClient;

namespace Practical_07C
{
    public partial class Practical_07C : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"ConnectionString";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string insertQuery = "INSERT INTO Student VALUES({0},'{1}','{2}')";
            string Id = TextBox1.Text;
            string Name = TextBox2.Text;
            string City = TextBox3.Text;
            string query = String.Format(insertQuery, Id, Name, City);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            Result.Text = "Record inserted successfully.";
            GridView1.DataBind();
            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string updateQuery = "UPDATE Student SET Name = '{1}', Address = '{2}' WHERE Id = {0}";
            string Id = TextBox1.Text;
            string Name = TextBox2.Text;
            string City = TextBox3.Text;
            string query = String.Format(updateQuery, Id, Name, City);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            Result.Text = "Record updated successfully.";
            GridView1.DataBind();
            conn.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            string deleteQuery = "DELETE FROM Student WHERE Id = {0}";
            string Id = TextBox1.Text;
            string query = String.Format(deleteQuery, Id);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            Result.Text = "Record deleted successfully.";
            GridView1.DataBind();
            conn.Close();
        }
    }
}