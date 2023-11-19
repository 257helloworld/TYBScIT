<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical_05C3.aspx.cs" Inherits="Practical_05C3.Practical_05C3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 30px">
    <form id="form1" runat="server">
        <h2>ViewState</h2>
        <asp:Label ID="Result" runat="server" Text="Count: 0"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Hit Count" OnClick="Button1_Click" />
    </form>
</body>
</html>
