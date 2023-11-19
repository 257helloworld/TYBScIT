<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MultilevelInheritance.aspx.cs" Inherits="Practical_02B2.MultilevelInheritance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 30px">
    <form id="form1" runat="server">
        <h2>Multilevel Inheritance</h2>
        <h4>Marks</h4>
        Maths: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Science: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        History: <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        Geography: <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        Sanskrit: <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Get Result" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="Result" runat="server"></asp:Label>
    </form>
</body>
</html>
