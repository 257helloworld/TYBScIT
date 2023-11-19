using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac8
{
    public partial class prac8a : System.Web.UI.Page
    {
        SqlDataSource s = new SqlDataSource();
        protected void Page_Load(object sender, EventArgs e)
        {
            s.ConnectionString = @"ConnectionString";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlParameter p1 = new SqlParameter();
            SqlParameter p2 = new SqlParameter();
            SqlParameter p3 = new SqlParameter();
            s.InsertParameters.Add("p1", DbType.Int16, TextBox1.Text);
            s.InsertParameters.Add("p2", DbType.String, TextBox2.Text);
            s.InsertParameters.Add("p3", DbType.String, TextBox3.Text);
            s.InsertCommand = "INSERT INTO Student VALUES(@p1, @p2, @p3);";
            s.Insert();
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlParameter p1 = new SqlParameter();
            s.DeleteParameters.Add("p1", DbType.Int16, TextBox1.Text);
            s.DeleteCommand = "DELETE FROM Student WHERE Id = @p1";
            s.Delete();
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlParameter p1 = new SqlParameter();
            SqlParameter p2 = new SqlParameter();
            s.UpdateParameters.Add("p1", DbType.Int16, TextBox1.Text);
            s.UpdateParameters.Add("p2", DbType.String, TextBox2.Text);
            s.UpdateParameters.Add("p3", DbType.String, TextBox3.Text);
            s.UpdateCommand = "UPDATE Student SET Name = @p2, Address = @p3 WHERE Id = @p1";
            s.Update();
            s.SelectCommand = "SELECT * FROM Student";
            GridView1.DataBind();
        }
    }
}