<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical_04C.aspx.cs" Inherits="Practical_04C.Practical_04C" %>

<%@ Register Src="~/Calculator_User_Control.ascx" TagPrefix="uc1" TagName="Calculator_User_Control" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 30px">
    <form id="form1" runat="server">
        <h2>Create web form to demonstrate use of User Controls.</h2>  
        <uc1:Calculator_User_Control runat="server" id="Calculator_User_Control" />
    </form>
</body>
</html>
