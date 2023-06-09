<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ObjectServer.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ServerObject (Execute)</div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <p>
            ServerObject (Transfer)</p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        </p>
        <p>
            Server.HTMLencode</p>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
        <br />
        <br />
        Server.URLencode<br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Button" />
        <p>
            ServerMapPath</p>
        <p>
            <asp:Button ID="Button5" runat="server" Text="Button" />
        </p>
    </form>
</body>
</html>
