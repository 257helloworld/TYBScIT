using System;

namespace Practical_09B
{
    public partial class Practical_09B : System.Web.UI.Page
    {
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            string name = row.Cells[1].Text;
            Result.Text = "Selected name is: " + name;
        }
    }
}