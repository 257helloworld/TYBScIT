using System;

namespace Practical_01D
{
    public partial class Practical_01D : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(TextBox1.Text);
            int n1 = 0; int n2 = 1;
            string fib = n1.ToString() + ", " + n2.ToString();
            n = n - 2;
            while(n > 0)
            {
                int next = n1 + n2;
                fib += ", " + next.ToString();
                n1 = n2;
                n2 = next;
                n--;
            }
            Result.Text = fib;
        }
    }
}