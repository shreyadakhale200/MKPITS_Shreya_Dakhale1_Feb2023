<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="adrotater.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            adrotater control&nbsp; - image will change when we refresh the page</div>
        <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/XMLFile.xml" Height="200px" ImageUrlField="shortcut.png" Width="400px" />
        <asp:XmlDataSource ID="XmlDataSource1" runat="server"></asp:XmlDataSource>
    </form>
</body>
</html>
