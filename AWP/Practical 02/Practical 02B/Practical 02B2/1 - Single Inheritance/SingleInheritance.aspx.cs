using System;
using System.ComponentModel;

namespace Practical_02B2
{
    public class Shape
    {
        public double bs, height;
        public void TriangleInput(double b, double h)
        {
            bs = b;
            height = h;
        }
    }
    public class Triangle : Shape
    {
        public double Area()
        {
            return (0.5 * bs * height);
        }
    }
    public partial class SingleInheritance : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            int bs = int.Parse(TextBox1.Text);
            int height = int.Parse(TextBox2.Text);
            Triangle t = new Triangle();
            t.TriangleInput(bs, height);
            Result.Text = "Area: " + t.Area();
        }
    }
}