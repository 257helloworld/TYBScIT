<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical_01B.aspx.cs" Inherits="Practical_01B.Practical_01B" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 30px">
    <form id="form1" runat="server">
        <h2>Create an application to demonstrate string operations.</h2>
        <br />
	String 1: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        String 2: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upper" />
        &nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Lower" />
        &nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Concat" />
        <br />
        <br />
        <asp:Label ID="Result" runat="server"></asp:Label>
    </form>
</body>
</html>
