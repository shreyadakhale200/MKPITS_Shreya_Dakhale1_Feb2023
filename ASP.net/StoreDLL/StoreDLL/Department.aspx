<%@ Page Title="" Language="C#" MasterPageFile="~/1.Master" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="StoreDLL.Department" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    Department Details</p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Department ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
    <p>
    <asp:Label ID="Label2" runat="server" Text="Department Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Height="19px" Width="167px">
            <asp:ListItem>Sales</asp:ListItem>
            <asp:ListItem>Finance</asp:ListItem>
            <asp:ListItem>Accounting</asp:ListItem>
            <asp:ListItem>Computers and Information</asp:ListItem>
            <asp:ListItem>Human Resorces</asp:ListItem>
            <asp:ListItem>Marketing</asp:ListItem>
        </asp:DropDownList>
</p>
<p>
    <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Modify" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" Enabled="False" OnClick="Button3_Click" Text="Update" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button4" runat="server" Enabled="False" OnClick="Button4_Click" Text="Delete" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button5" runat="server" Text="Search" OnClick="Button5_Click" />
</p>
<p>
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
</p>
</asp:Content>
