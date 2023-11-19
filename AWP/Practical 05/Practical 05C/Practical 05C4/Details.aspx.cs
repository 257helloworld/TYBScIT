using System;

namespace Practical_05C4
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.Cookies["Name"].Value;
            string city = Request.Cookies["City"].Value;
            Result.Text = "<b>Name: </b>" + name + "<br/><b>City: </b>" + city;
        }
    }
}