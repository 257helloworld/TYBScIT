<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical_06A.aspx.cs" Inherits="Practical_06A.Practical_06A" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 30px">
    <form id="form1" runat="server">
        <h2>Create a web application bind data in a multiline textbox by querying in another textbox</h2>
        Enter Query:
        <asp:TextBox ID="queryTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show Data" />
        <br />
        <br />
        <asp:TextBox ID="resultTextBox" runat="server" Rows="5" TextMode="MultiLine"></asp:TextBox>
    </form>
</body>
</html>
