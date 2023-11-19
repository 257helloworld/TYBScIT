using System;
using System.Drawing;

namespace Practical_03A
{
    public partial class Practical_03A : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Result1.Text = TextBox1.Text;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Result2.Text = DropDownList1.SelectedValue;
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Result3.Text = ListBox1.SelectedValue;
        }

        protected void Rb1_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb1.Checked)
            {
                Label.ForeColor = Color.Red;
            }
        }
        protected void Rb2_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb2.Checked)
            {
                Label.ForeColor = Color.Blue;
            }
        }


        protected void Cb1_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb1.Checked)
            {
                Label.Font.Bold = true;
            } else
            {
                Label.Font.Bold = false;
            }
        }
        protected void Cb2_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb2.Checked)
            {
                Label.Font.Underline = true;
            }
            else
            {
                Label.Font.Underline = false;
            }
        }
        protected void Cb3_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb3.Checked)
            {
                Label.Font.Italic = true;
            }
            else
            {
                Label.Font.Italic= false;
            }
        }
    }
}