<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewInfo.aspx.cs" Inherits="ApplicationandSession.ViewInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 50%; border-collapse: collapse; border-style: solid; border-width: 1px">
    <tr>
        <td style="width: 267px">Username :</td>
        <td style="margin-left: 40px">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 267px">Email:</td>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 267px">Pizza:</td>
        <td>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 267px">Pizza Crust:</td>
        <td>
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>
