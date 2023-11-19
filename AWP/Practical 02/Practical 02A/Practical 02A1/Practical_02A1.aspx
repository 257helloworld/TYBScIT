<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical_02A1.aspx.cs" Inherits="Practical_02A1.Practical_02A1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 30px">
    <form id="form1" runat="server">
        <h2>Finding Factorial Value</h2>

        Enter Number:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Factorial" />
        <br />
        <br />
        <asp:Label ID="Result" runat="server"></asp:Label>

    </form>
</body>
</html>
