<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical_03A.aspx.cs" Inherits="Practical_03A.Practical_03A" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 30px">
    <form id="form1" runat="server">
        <h2>Create a simple page with various server controls to demonstrate setting and use of their properties (Ex. Autopostback)</h2>

        Name: <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        &nbsp;
        <asp:Label ID="Result1" runat="server"></asp:Label>
        <br />
        <br />
        Select State: <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="Maharashtra"></asp:ListItem>
            <asp:ListItem Value="Karnataka"></asp:ListItem>
            <asp:ListItem Value="Gujarat"></asp:ListItem>
            <asp:ListItem Value="Rajasthan"></asp:ListItem>
        </asp:DropDownList>
    &nbsp;
        <asp:Label ID="Result2" runat="server"></asp:Label>
        <br />
        <br />
        Select Sports:
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
            <asp:ListItem Value="Cricket"></asp:ListItem>
            <asp:ListItem Value="Volleyball"></asp:ListItem>
            <asp:ListItem Value="Football"></asp:ListItem>
            <asp:ListItem Value="Kabaddi"></asp:ListItem>
        </asp:ListBox>
&nbsp;<asp:Label ID="Result3" runat="server"></asp:Label>
        <br />
        <hr />
        <br />
        <asp:Label ID="Label" runat="server" Text="Hello, World!"></asp:Label>
        <br />
        <br />
        Select Color:&nbsp;
        <asp:RadioButton ID="Rb1" runat="server" AutoPostBack="True" GroupName="color" OnCheckedChanged="Rb1_CheckedChanged" Text="Red" />
&nbsp;
        <asp:RadioButton ID="Rb2" runat="server" AutoPostBack="True" GroupName="color" OnCheckedChanged="Rb2_CheckedChanged" Text="Blue" />
&nbsp;
        <br />
        <br />
        Select Styling: <asp:CheckBox ID="Cb1" runat="server" AutoPostBack="True" OnCheckedChanged="Cb1_CheckedChanged" Text="Bold" />
&nbsp;
        <asp:CheckBox ID="Cb2" runat="server" AutoPostBack="True" OnCheckedChanged="Cb2_CheckedChanged" Text="Underline" />
&nbsp;
        <asp:CheckBox ID="Cb3" runat="server" AutoPostBack="True" OnCheckedChanged="Cb2_CheckedChanged" Text="Italic" />
    </form>
</body>
</html>
