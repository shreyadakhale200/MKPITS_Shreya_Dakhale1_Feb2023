<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AccountDetails.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Account Details</div>
        <hr />
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
        <p class="auto-style1">
            Acct No&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style1">
            Amount&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style1">
            Type&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style1">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" OnLoad="Button1_Load" />
        </p>
        <p class="auto-style1">
            Result&nbsp;&nbsp;&nbsp;  <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
