using System;

namespace Practical_05B
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ErrorResult.Text = "";
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            string password = TextBox2.Text;
            if (Request.Cookies["Username"].Value == username && Request.Cookies["Password"].Value == password)
            {
                Session["Username"] = username;
                Response.Redirect("Home.aspx");
            } else
            {
                ErrorResult.Text = "Incorrect username or password";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
    }
}