using System;

namespace Practical_10B
{
    public partial class Practical_10B : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToLongTimeString();
            TimeLabel.Text = time;
            Timer1.Enabled = true;
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToLongTimeString();
            TimeLabel.Text = time;
        }
    }
}