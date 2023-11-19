using System;

namespace Practical_04C
{
    public partial class Calculator_User_Control : System.Web.UI.UserControl
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TextBox1.Text);
            int b = int.Parse(TextBox2.Text);
            Result.Text = "Addition: " + (a + b);
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TextBox1.Text);
            int b = int.Parse(TextBox2.Text);
            Result.Text = "Subraction: " + (a - b);
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TextBox1.Text);
            int b = int.Parse(TextBox2.Text);
            Result.Text = "Multiplication: " + (a * b);
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TextBox1.Text);
            int b = int.Parse(TextBox2.Text);
            Result.Text = "Division: " + (a / b);
        }
    }
}