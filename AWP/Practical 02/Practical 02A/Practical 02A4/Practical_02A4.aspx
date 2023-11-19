<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical_02A4.aspx.cs" Inherits="Practical_02A4.Practical_02A4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 30px">
    <form id="form1" runat="server">
        <h2>Temperature Conversion</h2>

        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="ctof">Celcius to Farenheit</asp:ListItem>
            <asp:ListItem Value="ftoc">Farenheit to Celcius</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Enter value: "></asp:Label>
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
