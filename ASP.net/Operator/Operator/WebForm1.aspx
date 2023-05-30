<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Operator.WebForm1" %>

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
        <div class="auto-style1">
            Operator<br />
        </div>
        <hr />
            <p class="auto-style1">
                Number 1&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </p>
            <p class="auto-style1">
                Number 2&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>
            <p class="auto-style1">
                Operator&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" />
            <br />
            <br />
            Result&nbsp;&nbsp;&nbsp; <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
    <p class="auto-style1">
        &nbsp;</p>
</body>
</html>
