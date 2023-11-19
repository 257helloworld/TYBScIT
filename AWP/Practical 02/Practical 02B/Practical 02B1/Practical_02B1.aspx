<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical_02B1.aspx.cs" Inherits="Practical_02B1.Practical_02B1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 30px">
    <form id="form1" runat="server">
        <h2>Function Overloading</h2>
        <h4>Area of Circle</h4>
        Enter Radius:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Area" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="Result1" runat="server"></asp:Label>
        <hr />
        <h4>Area of Rectangle</h4>
        Enter Length: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        Enter Breadth:
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Area" OnClick="Button2_Click" />
        <br />
        <br />
        <asp:Label ID="Result2" runat="server"></asp:Label>
    </form>
</body>
</html>
