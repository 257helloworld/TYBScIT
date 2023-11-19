using System;

namespace Practical_01D2
{
    public partial class Practical_01D2 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, System.EventArgs e)
        {
            bool test = true;
            int n = int.Parse(TextBox1.Text);
            for(int i = 2; i < n; i++)
            {
                if(n % i == 0)
                {
                    test = false;
                    break;
                }
            }
            if(test == true)
            {
                Result.Text = "Number is <b>Prime</b>";
            } else
            {
                Result.Text = "Number is <b>Not Prime</b>";
            }
        }
    }
}