<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Calculator_User_Control.ascx.cs" Inherits="Practical_04C.Calculator_User_Control" %>
First Number:
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<br />
<br />
Second Number:
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
<br />
<br />
<asp:Button ID="Button1" runat="server" Text="+" OnClick="Button1_Click" />
&nbsp;
<asp:Button ID="Button2" runat="server" Text="-" OnClick="Button2_Click" />
&nbsp;
<asp:Button ID="Button3" runat="server" Text="*" OnClick="Button3_Click" />
&nbsp;
<asp:Button ID="Button4" runat="server" Text="/" OnClick="Button4_Click" />

<br />
<br />

<asp:Label ID="Result" runat="server"></asp:Label>


