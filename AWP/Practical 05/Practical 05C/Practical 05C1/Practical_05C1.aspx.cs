using System;

namespace Practical_05C1
{
    public partial class Practical_05C1 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            int count = int.Parse(HiddenField1.Value);
            count = count + 1;
            Result.Text = "Count: " + count;
            HiddenField1.Value = count.ToString();
        }
    }
}