<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical_01D3.aspx.cs" Inherits="Practical_01D3.Practical_01D3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 30px">
    <form id="form1" runat="server">
        <h2>Test for Vowels</h2>
        Enter string: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Check" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="Result" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
