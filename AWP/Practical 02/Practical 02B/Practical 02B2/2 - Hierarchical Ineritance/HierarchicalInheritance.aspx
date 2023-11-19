<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HierarchicalInheritance.aspx.cs" Inherits="Practical_02B2.HierarchicalInheritance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 30px">
    <form id="form1" runat="server">
        <h2>Hierarchical Inheritance</h2>
        <h4>Area & Circumference</h4>
        Enter Radius: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Area & Circumference" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="Result" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
