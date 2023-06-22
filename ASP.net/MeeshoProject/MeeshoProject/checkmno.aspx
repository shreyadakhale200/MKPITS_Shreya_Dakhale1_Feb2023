<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="checkmno.aspx.cs" Inherits="MeeshoProject.checkmno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">
        <h5>&nbsp;</h5>
    </div>
    <div align="center">
        <h5>Enter OTP : 
            <asp:TextBox ID="TextBox1" runat="server" MaxLength="6" TextMode="Number"></asp:TextBox>
        </h5>
    </div>
    <div align="center">
        <p>&nbsp;</p>
    </div>
    <div align="center">
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" />
        </p>
    </div>
    <div align="center">
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </div>
</asp:Content>
