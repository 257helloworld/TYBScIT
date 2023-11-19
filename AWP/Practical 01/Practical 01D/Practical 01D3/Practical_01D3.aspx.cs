using System;
using System.Linq;

namespace Practical_01D3
{
    public partial class Practical_01D3 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = (TextBox1.Text).ToLower();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;
            foreach(char c in s){
                if (vowels.Contains(c))
                {
                    count++;
                }
            }
            Result.Text = "<b>No. of Vowels: </b>" + count;
        }
    }
}