using System;

namespace Practical_05C6
{
    public partial class Practical_05C6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int count = 0;
            if (Application["Visits"] != null)
            {
                count = int.Parse(Application["Visits"].ToString());
            }
            count = count + 1;
            Application["Visits"] = count;
            Result.Text = "Total Visits: " + count;
        }
    }
}