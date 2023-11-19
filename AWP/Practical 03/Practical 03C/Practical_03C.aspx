<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practical_03C.aspx.cs" Inherits="Practical_03C.Practical_03C" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin: 30px">
    <form id="form1" runat="server">
        <h2>Demonstrate the use of Treeview control perform following operations.</h2>
        <h3>a) Treeview control and datalist </h3>
        <h3>b) Treeview operations</h3>

        <asp:TreeView ID="TreeView1" runat="server" ImageSet="Arrows" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged" ShowCheckBoxes="All">
            <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
            <Nodes>
                <asp:TreeNode Text="B.Com" Value="B.Com">
                    <asp:TreeNode Text="F.Y.B.Com" Value="F.Y.B.Com"></asp:TreeNode>
                    <asp:TreeNode Text="S.Y.B.Com" Value="S.Y.B.Com"></asp:TreeNode>
                    <asp:TreeNode Text="T.Y.B.Com" Value="T.Y.B.Com"></asp:TreeNode>
                </asp:TreeNode>
                <asp:TreeNode Text="B.Sc.I.T." Value="B.Sc.I.T.">
                    <asp:TreeNode Text="F.Y.B.Sc.I.T." Value="F.Y.B.Sc.I.T."></asp:TreeNode>
                    <asp:TreeNode Text="S.Y.B.Sc.I.T." Value="S.Y.B.Sc.I.T."></asp:TreeNode>
                    <asp:TreeNode Text="T.Y.B.Sc.I.T." Value="T.Y.B.Sc.I.T."></asp:TreeNode>
                </asp:TreeNode>
            </Nodes>
            <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
            <ParentNodeStyle Font-Bold="False" />
            <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
        </asp:TreeView>

        <br />
        <asp:Label ID="Result" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Data" />
        <br />
        <br />
        <asp:DataList ID="DataList1" runat="server" CellPadding="4" ForeColor="#333333">
            <AlternatingItemStyle BackColor="White" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#EFF3FB" />
            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <ItemTemplate>
                <%#Eval("text") %>
            </ItemTemplate>
        </asp:DataList>

    </form>
</body>
</html>
