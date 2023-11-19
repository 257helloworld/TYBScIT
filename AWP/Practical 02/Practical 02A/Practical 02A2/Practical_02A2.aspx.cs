using System;

namespace Practical_02A2
{
    public partial class Practical_02A2 : System.Web.UI.Page
    {
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedValue == "1")
            {
                Label1.Text = "Enter Rupees: ";
            } else
            {
                Label1.Text = "Enter Dollars: ";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(TextBox1.Text);
            if(DropDownList1.SelectedValue == "1")
            // If INR to USD is selected.
            // N2 is for upto 2 precision. Ex. 3.13534 = 3.13
            {
                Result.Text = String.Format("{0} INR = {1:N2} USD", a, (a / 80.25));
            } else
            // If USD to INR is selected.
            {
                Result.Text = String.Format("{0} USD = {1:N2} INR", a, (a * 80.25));
            }
        }
    }
}