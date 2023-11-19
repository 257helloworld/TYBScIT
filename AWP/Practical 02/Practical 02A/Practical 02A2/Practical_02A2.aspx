<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical_02A2.aspx.cs" Inherits="Practical_02A2.Practical_02A2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 30px">
    <form id="form1" runat="server">
        <h2>Money Conversion</h2>

         <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
             <asp:ListItem Value="1">INR to USD</asp:ListItem>
             <asp:ListItem Value="2">USD to INR</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />

         <asp:Label ID="Label1" runat="server" Text="Enter Rupees"></asp:Label>

        :
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Convert" />
        <br />
        <br />
        <asp:Label ID="Result" runat="server"></asp:Label>

    </form>
</body>
</html>
