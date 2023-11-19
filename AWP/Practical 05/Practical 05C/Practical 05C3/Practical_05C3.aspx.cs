using System;

namespace Practical_05C3
{
    public partial class Practical_05C3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["Counter"] == null)
            {
                ViewState["Counter"] = 0;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int count = int.Parse(ViewState["Counter"].ToString());
            count = count + 1;
            ViewState["Counter"] = count;
            Result.Text = "Count: " + count;
        }
    }
}