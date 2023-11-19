<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical_04A.aspx.cs" Inherits="Practical_04A.Practical_04A" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin:30px">
    <form id="form1" runat="server">
        <h2>Create a Registration form to demonstrate use of various Validation controls.</h2>
        <br />
        Name: 
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Required" ForeColor="#FF5050"></asp:RequiredFieldValidator>
        <br />
        <br />
        Age: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="You must be 18 years old or above." ForeColor="#FF5050" MaximumValue="60" MinimumValue="18"></asp:RangeValidator>
        <br />
        <br />
        Email ID:
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="Invalid Email ID" ForeColor="#FF5050" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
        <br />
        Password:
        <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox4" ErrorMessage="*Required" ForeColor="#FF5050"></asp:RequiredFieldValidator>
        <br />
        <br />
       Confirm Password:
        <asp:TextBox ID="TextBox5" runat="server" TextMode="Password"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox4" ControlToValidate="TextBox5" ErrorMessage="Password &amp; Confirm Password doesn't match." ForeColor="#FF5050"></asp:CompareValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        <br />
        <br />
        <asp:Label ID="Result" runat="server"></asp:Label>
        
    </form>
</body>
</html>
