using System;

namespace Practical_05C2
{
    public partial class Practical_05C2 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string city = TextBox2.Text;
            string url = "Details.aspx?name=" + name + "&city=" + city;
            Response.Redirect(url);
        }
    }
}