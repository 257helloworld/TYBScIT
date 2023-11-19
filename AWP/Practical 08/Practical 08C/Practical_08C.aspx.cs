using System;
using System.Data;
using System.Data.SqlClient;

namespace Practical_08C
{
    public partial class Practical_08C : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"ConnectionString";
            conn.Open();
            string selectQuery = "SELECT * FROM Student;";
            SqlDataAdapter da = new SqlDataAdapter(selectQuery, conn);
            DataSet ds = new DataSet();
            conn.Close();
            // Connection Closed.
            da.Fill(ds);
            GridView1.DataSource = ds;
            // GridView DataBind.
            GridView1.DataBind();
        }
    }
}