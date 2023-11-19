using System;

namespace Practical_05B
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            string password = TextBox2.Text;
            if(username != "" && password != "")
            {
                Response.Cookies["Username"].Value = username;
                Response.Cookies["Password"].Value = password;
                Response.Redirect("Login.aspx");
            } else
            {
                ErrorResult.Text = "Enter username & password";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}