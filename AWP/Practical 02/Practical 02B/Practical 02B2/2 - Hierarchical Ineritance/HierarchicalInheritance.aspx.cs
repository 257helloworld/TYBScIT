using System;

namespace Practical_02B2
{
    public class Circle
    {
        public double radius;
        public void CircleInput(double r)
        {
            radius = r;
        }
    }
    public class Circumference : Circle
    {
        public double GetCircumference()
        {
            double circumference = 2 * Math.PI * radius;
            return (Math.Round(circumference, 2));
        }
    }
    public class Area : Circle
    {
        public double GetArea()
        {
            double area = Math.PI * radius * radius;
            return (Math.Round(area, 2));
        }
    }
    public partial class HierarchicalInheritance : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            int radius = int.Parse(TextBox1.Text);
            Circumference cr = new Circumference();
            Area ar = new Area();
            cr.CircleInput(radius);
            ar.CircleInput(radius);
            double area = ar.GetArea();
            double circumference = cr.GetCircumference();
            Result.Text = "Circumference: " + circumference + "<br/>Area: " + area;
        }
    }
}