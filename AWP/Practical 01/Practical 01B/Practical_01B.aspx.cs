using System;

namespace Practical_01B
{
    public partial class Practical_01B : System.Web.UI.Page
    {
        // Upper
        protected void Button1_Click(object sender, EventArgs e)
        {
            string s1 = TextBox1.Text;
            string s2 = TextBox2.Text;
            Result.Text = "Upper 1: " + s1.ToUpper() + "<br/>" + "Upper 2: " + s2.ToUpper();
        }
        // Lower
        protected void Button2_Click(object sender, EventArgs e)
        {
            string s1 = TextBox1.Text;
            string s2 = TextBox2.Text;
            Result.Text = "Upper 1: " + s1.ToLower() + "<br/>" + "Upper 2: " + s2.ToLower();
        }
        // Concat
        protected void Button3_Click(object sender, EventArgs e)
        {
            string s1 = TextBox1.Text;
            string s2 = TextBox2.Text;
            Result.Text = "Concat: " + String.Concat(s1, s2);
        }
    }
}