<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical_02C1.aspx.cs" Inherits="Practical_02C1.Practical_02C1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 30px">
    <form id="form1" runat="server">
        <h2>Using Delegates and Events</h2>
        <h4>Calculator</h4>
        Number 1:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Number 2:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Add &amp; Subtract" OnClick="Button1_Click" />
        &nbsp;<br />
        <br />
        <asp:Label ID="Result" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
