<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Practical_05B.Registration" Theme="Theme"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Username: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    Password: <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <br />
    Confirm Password: <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="Password &amp; Confirm password does not match."></asp:CompareValidator>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
    <br />
    <br />
<asp:Label ID="ErrorResult" runat="server"></asp:Label>
<br />
    Already have an account? <asp:Button ID="Button2" runat="server" Text="Login" OnClick="Button2_Click" />
</asp:Content>
