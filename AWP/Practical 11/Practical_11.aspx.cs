using System;
using NewMath;

namespace Practical_11
{
    public partial class Practical_11 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            Factorial f = new Factorial();
            int n = int.Parse(TextBox1.Text);
            double fact = f.factorial(n);
            Result.Text = "Factorial: " + fact;
        }
    }
}