<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical_04B.aspx.cs" Inherits="Practical_04B.Practical_04B" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 30px">
    <form id="form1" runat="server">
        <h2>Create web form to demonstrate use of Adrotator Control.</h2>

        <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/Advertisements.xml" />

    </form>
</body>
</html>
