using System;

namespace Practical_09C
{
    public partial class Practical_09C : System.Web.UI.Page
    {
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView1.PageIndex = int.Parse(DropDownList1.SelectedValue);
        }
    }
}