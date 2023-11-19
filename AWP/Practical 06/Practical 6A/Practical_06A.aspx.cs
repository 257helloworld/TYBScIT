using System;
using System.Data.SqlClient;

namespace Practical_06A
{
    public partial class Practical_06A : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection();
        SqlDataReader reader;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"ConnectionString";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (queryTextBox.Text == "")
            {
                return;
            }
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            // Get query from textbox.
            cmd.CommandText = queryTextBox.Text;
            // Execute query.
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();
            // Display data in textarea.
            while (reader.Read())
            {
                string result = resultTextBox.Text;
                string rno = reader[0].ToString();
                string name = reader[1].ToString();
                string age = reader[2].ToString();
                string newRow = rno + " " + name + " " + age;
                resultTextBox.Text = result + "\n" + newRow;
            }
            conn.Close();
        }
    }
}