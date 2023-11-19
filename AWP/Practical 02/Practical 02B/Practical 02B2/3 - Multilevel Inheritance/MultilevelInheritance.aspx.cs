using System;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Web.UI.WebControls;

namespace Practical_02B2
{
    public class Marks
    {
        public double outOf = 500, s1, s2, s3, s4, s5;
        public void MarksInput(int a, int b, int c, int d, int e)
        {
            s1 = a;
            s2 = b;
            s3 = c;
            s4 = d;
            s5 = e;
        }
    }
    public class Total : Marks
    {
        public double total;
        public double GetTotal()
        {
            total = s1 + s2 + s3 + s4 + s5;
            return (total);
        }
    }
    public class Percentage : Total
    {
        public double percentage;
        public double GetPercentage()
        {
            total = GetTotal();
            percentage = (total / outOf) * 100;
            return (Math.Round(percentage, 2));
        }
    }
    public partial class MultilevelInheritance : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            int s1 = int.Parse(TextBox1.Text);
            int s2 = int.Parse(TextBox2.Text);
            int s3 = int.Parse(TextBox3.Text);
            int s4 = int.Parse(TextBox4.Text);
            int s5 = int.Parse(TextBox5.Text);
            Percentage p = new Percentage();
            p.MarksInput(s1, s2, s3, s4, s5);
            double total = p.GetTotal();
            double percentage = p.GetPercentage();
            Result.Text = "Total: " + total + "<br/>Percentage: " + percentage; 
        }
    }
}