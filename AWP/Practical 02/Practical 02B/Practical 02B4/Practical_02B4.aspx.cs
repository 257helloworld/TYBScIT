using System;

namespace Practical_02B4
{
    public interface Calculator 
    {
        double Product(double a, double b, double c);
    }
    public class Multiplication : Calculator
    {
        public double Product(double a, double b, double c)
        {
            double product = a * b * c;
            return product;
        }
    }
    public partial class Practical_02B4 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TextBox1.Text);
            int b = int.Parse(TextBox2.Text);
            int c = int.Parse(TextBox3.Text);
            Multiplication m = new Multiplication();
            Result.Text = "Product: " + m.Product(a, b, c);
        }
    }
}