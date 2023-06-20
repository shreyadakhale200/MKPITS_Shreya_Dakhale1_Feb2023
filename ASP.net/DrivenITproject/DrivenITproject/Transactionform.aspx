<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Transactionform.aspx.cs" Inherits="DrivenITproject.Transactionform" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    Item ID&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="ItemDescr" DataValueField="ItemID" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="161px">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DrivenITConnectionString %>" ProviderName="<%$ ConnectionStrings:DrivenITConnectionString.ProviderName %>" SelectCommand="SELECT [ItemID], [ItemDescr] FROM [ItemMaster]"></asp:SqlDataSource>
</p>
<p>
    Transaction Type&nbsp;&nbsp;&nbsp;
    <asp:RadioButton ID="RadioButton1" runat="server" Text="Issue" />
&nbsp;&nbsp;&nbsp;
    <asp:RadioButton ID="RadioButton2" runat="server" Text="Recieved" />
</p>
<p>
    Quantity&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p>
&nbsp;&nbsp;&nbsp;&nbsp; Date&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
</p>
</asp:Content>
