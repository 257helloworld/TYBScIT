<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical_07B.aspx.cs" Inherits="Practical_07B.Practical_07B" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 30px">
    <form id="form1" runat="server">
        <h2>Create a web application for to display the city of a student using database.</h2>
        Id:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Get City" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="Result" runat="server"></asp:Label>
    </form>
</body>
</html>
