using System;

namespace Practical_05B
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                Result.Text = "<h3>Welcome " + Session["Username"] + "</h3>";
            } else
            {
                Response.Redirect("Registration.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Username"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}