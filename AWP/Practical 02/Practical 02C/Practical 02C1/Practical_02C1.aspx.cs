using System;
using System.Runtime.InteropServices;

namespace Practical_02C1
{
    public partial class Practical_02C1 : System.Web.UI.Page
    {
        public delegate void Calculate(int a, int b);
        class Calculator
        {
            public int result;
            public void Add(int a, int b)
            {
                result = a + b;
            }
            public void Sub(int a, int b)
            {
                result = a - b;
            }
            public int GetResult()
            {
                return result;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TextBox1.Text);
            int b = int.Parse(TextBox2.Text);
            Calculator c = new Calculator();
            Calculate c1 = new Calculate(c.Add);
            Calculate c2 = new Calculate(c.Sub);
            c1(a, b);
            int addition = c.GetResult();
            c2(a, b);
            int subtraction = c.GetResult();
            Result.Text = "Addition: " + addition + "<br/>Subtraction: " + subtraction;
        }
    }
}