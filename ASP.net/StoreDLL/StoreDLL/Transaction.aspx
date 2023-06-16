<%@ Page Title="" Language="C#" MasterPageFile="~/1.Master" AutoEventWireup="true" CodeBehind="Transaction.aspx.cs" Inherits="StoreDLL.Transaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    Transaction Details</p>
<p>
    <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" Checked="True" GroupName="Mode" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Issue" />
&nbsp;&nbsp;&nbsp;
    <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="Mode" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Purchase" />
</p>
<p>
    Transaction ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Item Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Item_Name" DataValueField="Item_Id" Width="168px">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TrustProjectConnectionString %>" ProviderName="<%$ ConnectionStrings:TrustProjectConnectionString.ProviderName %>" SelectCommand="SELECT [Item_Id], [Item_Name] FROM [Item_master]"></asp:SqlDataSource>
</p>
<p>
    Transaction Date&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
</p>
<asp:Panel ID="Panel1" runat="server">
    <asp:Label ID="Label3" runat="server" Text="Department Name"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Department_name" DataValueField="Department_id" Width="175px">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:TrustProjectConnectionString %>" SelectCommand="SELECT [Department_id], [Department_name] FROM [Department_mast]"></asp:SqlDataSource>
</asp:Panel>
<asp:Panel ID="Panel2" runat="server">
    <asp:Label ID="Label2" runat="server" Text="Vendor Name"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource3" DataTextField="Vendor_name" DataValueField="Vendor_id" Width="175px">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:TrustProjectConnectionString %>" SelectCommand="SELECT [Vendor_id], [Vendor_name] FROM [Vendor_mast]"></asp:SqlDataSource>
</asp:Panel>
<p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Quantity&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox3" runat="server" Width="177px"></asp:TextBox>
    <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:TrustProjectConnectionString2 %>" ProviderName="<%$ ConnectionStrings:TrustProjectConnectionString2.ProviderName %>" SelectCommand="SELECT [Vendor_name], [Vendor_id] FROM [Vendor_mast]"></asp:SqlDataSource>
</p>
<p>
    <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
</p>
<p>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</p>
</asp:Content>
