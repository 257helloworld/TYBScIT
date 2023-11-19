<%@ Page language="C#" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = TextBox1.Text;
    }
</script>


<head runat="server">
    <title></title>
</head>
<html xmlns="http://www.w3.org/1999/xhtml">
<body style="margin: 30px">
    <form id="form1" runat="server">
        <h2>Write a web application to demonstrate HTMLEditorExtender<asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </h2>
        <asp:TextBox ID="TextBox1" runat="server" Height="205px" Width="693px"></asp:TextBox>
        <ajaxToolkit:HtmlEditorExtender ID="TextBox1_HtmlEditorExtender" runat="server" BehaviorID="TextBox1_HtmlEditorExtender" TargetControlID="TextBox1" EnableSanitization="False">
        </ajaxToolkit:HtmlEditorExtender>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
