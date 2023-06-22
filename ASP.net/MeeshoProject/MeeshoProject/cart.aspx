<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="MeeshoProject.addToCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <head>
        <style>
            .mno {
  border: 2px solid;
  padding: 2em 2em 2em 2em;
  margin: 2em 22em 3em 18em;
}
        </style>
    </head>
    <div align="center" class="mno">
        <h3><b>Sign up To Save your Order</b></h3>&nbsp;
        <h5>Enter mobile Number : 
            <asp:TextBox ID="TextBox1" runat="server" MaxLength="10" TextMode="Number"></asp:TextBox>
        </h5>
        <p>&nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Continue" OnClick="Button1_Click" /><br />
        </p>
    </div>
    <div align="center">
        <p>&nbsp;</p>
    </div>
</asp:Content>
