using System;

namespace Practical_02B3
{
    public class Addition
    {
        public int addition;
        public Addition(int a, int b)
        {
            addition = a + b;
        }
        public Addition(int a, int b, int c)
        {
            addition = a + b + c;
        }
        public int GetAddition()
        {
            return addition;
        }
    }
    public partial class Practical_02B3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedValue == "Two")
            {
                Label3.Visible = false;
                TextBox3.Visible = false;
            } else
            {
                Label3.Visible = true;
                TextBox3.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(TextBox1.Text);
            int n2 = int.Parse(TextBox2.Text);
            int addition;
            if(DropDownList1.SelectedValue == "Two")
            {
                Addition ad = new Addition(n1, n2);
                addition = ad.GetAddition();
            } else
            {
                int n3 = int.Parse(TextBox3.Text);
                Addition ad = new Addition(n1, n2, n3);
                addition = ad.GetAddition();
            }
            Result.Text = "Addition: " + addition;
        }
    }
}