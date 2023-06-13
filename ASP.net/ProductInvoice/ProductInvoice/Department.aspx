<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="ProductInvoice.Department" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style3 {
        font-size: large;
    }
        .auto-style4 {
            font-size: medium;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style2">
    Department</p>
<p class="auto-style3">
    Department ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
</p>
    <p class="auto-style3">
    Department Name&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
</p>
<p class="auto-style3">
    <asp:Button ID="Button1" runat="server" Text="Insert" CssClass="auto-style4" OnClick="Button1_Click" />
    <span class="auto-style4">&nbsp;&nbsp;&nbsp; </span>
    <asp:Button ID="Button2" runat="server" CssClass="auto-style4" OnClick="Button2_Click" Text="Update" />
    <span class="auto-style4">&nbsp;&nbsp;&nbsp; </span>
    <asp:Button ID="Button3" runat="server" CssClass="auto-style4" OnClick="Button3_Click" Text="Delete" />
    <span class="auto-style4">&nbsp;&nbsp;&nbsp; </span>
    <asp:Button ID="Button4" runat="server" CssClass="auto-style4" OnClick="Button4_Click" Text="Search" />
</p>
    <p class="auto-style3">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</p>
    <p class="auto-style3">
        &nbsp;</p>
</asp:Content>
