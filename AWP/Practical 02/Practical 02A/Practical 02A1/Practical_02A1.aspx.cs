using System;

namespace Practical_02A1
{
    public partial class Practical_02A1 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(TextBox1.Text);
            int fact = 1;
            while(n > 0)
            {
                fact = fact * n;
                n--;
            }
            Result.Text = "Factorial: " + fact;
        }
    }
}