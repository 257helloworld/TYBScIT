<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical_01D5.aspx.cs" Inherits="Practical_01D5.Practical_01D5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 30px">
    <form id="form1" runat="server">
        <h2>Reverse a number and find sum of digits of a number.</h2>
        Enter a Number: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="Result" runat="server"></asp:Label>
    </form>
</body>
</html>
