<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical_10A.aspx.cs" Inherits="Practical_10A.Practical_10A" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 30px">
    <form id="form1" runat="server">
        <h2>Create a web application to demonstrate reading and writing operation with XML.</h2>
        
        <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="XML Writer" />
        <br />
        <br />
        <asp:Label ID="Result1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button2_Click" Text="XML Reader" />
        <br />
        <br />
        <asp:Label ID="Result2" runat="server"></asp:Label>
        
    </form>
</body>
</html>
