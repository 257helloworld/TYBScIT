<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Practical_05A.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 30px">
    <form id="form1" runat="server">
        <h2>Create web form to demonstrate use of website navigation and controls and sitemap.</h2>
        <asp:SiteMapPath ID="SiteMapPath1" runat="server">
        </asp:SiteMapPath>
        <br />
        <br />
        <br />
        <asp:Menu ID="Menu1" runat="server" RenderingMode="List">
            <Items>
                <asp:MenuItem NavigateUrl="~/Home.aspx" Text="Home" Value="Home"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Courses.aspx" Text="Courses" Value="Courses">
                    <asp:MenuItem NavigateUrl="~/BScIT.aspx" Text="BScIT" Value="BScIT">
                        <asp:MenuItem NavigateUrl="~/FYBScIT.aspx" Text="FYBScIT" Value="FYBScIT"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/SYBScIT.aspx" Text="SYBScIT" Value="SYBScIT"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/TYBScIT.aspx" Text="TYBScIT" Value="TYBScIT"></asp:MenuItem>
                    </asp:MenuItem>
                </asp:MenuItem>
            </Items>
        </asp:Menu>
        <br />
        <br />
        <h1>Home</h1>
        <p>Hello, World!</p>
    </form>
</body>
</html>
