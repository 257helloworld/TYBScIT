using System;

namespace Practical_02A4
{
    public partial class Practical_02A4 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedValue == "ftoc")
            {
                double f = double.Parse(TextBox1.Text);
                double c = (f - 32) * 0.5556;
                Result.Text = String.Format("{0} Fareheit = {1} Celcius", f, Math.Round(c,2));
            } 
            else if(DropDownList1.SelectedValue == "ctof")
            {
                double c = double.Parse(TextBox1.Text);
                double f = (c * 1.8) + 32;
                Result.Text = String.Format("{0} Celcius = {1} Farenheit", c, Math.Round(f,2));
            }
        }
    }
}