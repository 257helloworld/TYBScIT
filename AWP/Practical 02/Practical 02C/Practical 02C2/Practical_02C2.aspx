<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical_02C2.aspx.cs" Inherits="Practical_02C2.Practical_02C2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 30px">
    <form id="form1" runat="server">
        <h2>Exception Handling</h2>
        Enter Dividend: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Enter Divisor: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Divide" OnClick="Button1_Click" style="height: 26px" />
        <br />
        <br />
        <asp:Label ID="Result" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
