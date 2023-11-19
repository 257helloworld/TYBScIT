using System;

namespace Practical_05C5
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Name"] == null)
            {
                Result.Text = "Your session is expired.";
            }
            else
            {
                Result.Text = "<h2>Welcome " + Session["Name"].ToString() + "</h2>";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Name"] = null;
            Response.Redirect("Practical_05C5.aspx");
        }
    }
}