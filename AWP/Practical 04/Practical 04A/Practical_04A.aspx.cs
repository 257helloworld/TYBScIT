using System;

namespace Practical_04A
{
    public partial class Practical_04A : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string age = TextBox2.Text;
            string emailId = TextBox3.Text;
            Result.Text = String.Format("Name: {0}<br/>Age: {1}<br/>EmailID: {2}",name, age, emailId);
        }
    }
}