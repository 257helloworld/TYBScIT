using System;

namespace Practical_01D5
{
    public partial class Practical_01D5 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(TextBox1.Text);
            int sum = 0;
            int rev = 0;
            while (n > 0)
            {
                int rem = n % 10;
                rev = (rev * 10) + rem;
                sum = sum + rem;
                n = n / 10;
            }
            Result.Text = "Reverse Number: " + rev + "<br/>Sum of Digits: " + sum;
        }
    }
}