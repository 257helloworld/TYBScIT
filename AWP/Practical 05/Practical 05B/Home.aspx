<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Practical_05B.Home" Theme="Theme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label runat="server" ID="Result"></asp:Label>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click" />
</asp:Content>