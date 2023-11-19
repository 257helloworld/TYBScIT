<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical_06B.aspx.cs" Inherits="Practical_06B.Practical_06B" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 30px">
    <form id="form1" runat="server">
        <h2>Create a web application to display records by using database.</h2>
        Enter ID:
        <asp:TextBox ID="idTextbox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="getData" runat="server" OnClick="getData_Click" Text="Get Data" />
        <br />
        <br />
        <asp:Label ID="Result" runat="server"></asp:Label>
    </form>
</body>
</html>
