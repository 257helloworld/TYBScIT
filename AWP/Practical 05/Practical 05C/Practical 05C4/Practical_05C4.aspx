<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical_05C4.aspx.cs" Inherits="Practical_05C4.Practical_05C4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 30px">
    <form id="form1" runat="server">
        <h2>Cookies</h2>
        Name: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        City: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
    </form>
</body>
</html>
