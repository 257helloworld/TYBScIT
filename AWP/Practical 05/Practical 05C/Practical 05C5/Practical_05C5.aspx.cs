using System;

namespace Practical_05C5
{
    public partial class Practical_05C5 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = "Hello";
            string password = "1234";
            if (TextBox1.Text == username && TextBox2.Text == password)
            {
                Session["Name"] = TextBox1.Text;
                Response.Redirect("Details.aspx");
            }
            else
            {
                Result.Text = "Incorrect Username or Password";
            }
        }
    }
}