<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical_01D2.aspx.cs" Inherits="Practical_01D2.Practical_01D2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 30px">
    <form id="form1" runat="server">
        <h2>Test for Prime Numbers</h2>

        Enter a Number:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Test" />
        <br />
        <br />
        <asp:Label ID="Result" runat="server"></asp:Label>

    </form>
</body>
</html>
