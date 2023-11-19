using System;

namespace Practical_05C2
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.QueryString["name"];
            string city = Request.QueryString["city"];
            Result.Text = "<b>Name: </b>" + name + "<br/><b>City: </b>" + city;
        }
    }
}