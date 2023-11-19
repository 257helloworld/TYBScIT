<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Practical_05B.Login" Theme="Theme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Username: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    Password: <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
    <br />
<br />
<asp:Label ID="ErrorResult" runat="server"></asp:Label>
<br />
    <br />
    New user? <asp:Button ID="Button2" runat="server" Text="Register" OnClick="Button2_Click" />
</asp:Content>
