using System;

namespace Practical_02C2
{
    public partial class Practical_02C2 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            double dividend = double.Parse(TextBox1.Text);
            double divisor = double.Parse(TextBox2.Text);
            try
            {
                if(divisor == 0)
                {
                    throw new DivideByZeroException();
                }
                Result.Text = "Answer: " + dividend / divisor;
            } catch(DivideByZeroException ex)
            {
                Result.Text = "Cannot divide by zero.";
            }
            
        }
    }
}