using System;

namespace Practical_01D4
{
    public partial class Practical_01D4 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] names = { "ABC", "PQR", "XYZ" };
            foreach (string name in names)
            {
                Result.Text += name + "<br/>";
            }
        }
    }
}