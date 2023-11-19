using System;

namespace Practical_05C4
{
    public partial class Practical_05C4 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string city = TextBox2.Text;
            Response.Cookies["Name"].Value = name;
            Response.Cookies["City"].Value = city;
            Response.Redirect("Details.aspx");
        }
    }
}