using System;

namespace Practical_02B1
{
    public class Geometry
    {
        public double Area(int radius)
        {
            return (Math.PI * radius * radius);
        }
        public double Area(int length, int breadth)
        {
            return (length * breadth);
        }
    }
    public partial class Practical_02B1 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            int radius = int.Parse(TextBox1.Text);
            Geometry gm = new Geometry();
            double area = gm.Area(radius);
            Result1.Text = "Area: " + area;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int length = int.Parse(TextBox2.Text);
            int breadth = int.Parse(TextBox3.Text);
            Geometry gm = new Geometry();
            double area = gm.Area(length, breadth);
            Result2.Text = "Area: " + area;
        }
    }
}