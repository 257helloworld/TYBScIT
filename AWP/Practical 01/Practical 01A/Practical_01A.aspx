<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical_01A.aspx.cs" Inherits="Practical_01A.Practical_01A" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 30px">
    <form id="form1" runat="server">
        <h2>Create an application that obtains four int values from the user and displays the product.</h2>

        Number 1:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Number 2:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        Number 3:
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        Number 4:
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Product" />
        <br />
        <br />
        <asp:Label ID="Result" runat="server"></asp:Label>

    </form>
</body>
</html>
