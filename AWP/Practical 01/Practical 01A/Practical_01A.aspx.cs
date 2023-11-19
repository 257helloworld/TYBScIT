using System;

namespace Practical_01A
{
    public partial class Practical_01A : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TextBox1.Text);
            int b = int.Parse(TextBox2.Text);
            int c = int.Parse(TextBox3.Text);
            int d = int.Parse(TextBox4.Text);
            int product = a * b * c * d;
            Result.Text = "Product: " + product;
        }
    }
}