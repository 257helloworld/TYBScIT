using System;

namespace Practical_01C
{
    public partial class Practical_01C : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            string Id = TextBox1.Text;
            string Name = TextBox2.Text;
            string CourseName = TextBox3.Text;
            string DateOfBirth = TextBox4.Text;
            Result.Text = "<h3>Student Details</h3>Id: " + Id + "<br/>" + "Name: " + Name + "<br/>" + "Course: " + CourseName + "<br/>" + "Date of Birth: " + DateOfBirth;
        }
    }
}