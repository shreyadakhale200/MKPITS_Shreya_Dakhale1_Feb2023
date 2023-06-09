<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="YourOrders.aspx.cs" Inherits="ApplicationandSession.YourOrders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 50%; border-collapse: collapse; border-style: solid; border-width: 2px">
    <tr>
        <td style="width: 266px">Pizza:</td>
        <td>
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>Pizza</asp:ListItem>
                <asp:ListItem>Mushroom</asp:ListItem>
                <asp:ListItem>Pepproni</asp:ListItem>
                <asp:ListItem>Farmhouse</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td style="width: 266px; height: 30px;">Pizza Crust:</td>
        <td style="height: 30px">
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Pizza Crusts</asp:ListItem>
                <asp:ListItem>Hand Tossed</asp:ListItem>
                <asp:ListItem>Cheese Burst</asp:ListItem>
                <asp:ListItem>Cracker Crust</asp:ListItem>
                <asp:ListItem>Thin Crust</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td style="width: 266px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 266px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 266px">&nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        </td>
    </tr>
    <tr>
        <td style="width: 266px">&nbsp;</td>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>
