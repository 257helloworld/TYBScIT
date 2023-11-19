using System;

namespace Practical_03C
{
    public partial class Practical_03C : System.Web.UI.Page
    {
        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
            Result.Text = "Selected Node: " + TreeView1.SelectedValue;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataList1.DataSource = TreeView1.CheckedNodes;
            DataList1.DataBind();
        }
    }
}