<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practise.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
            border-collapse: collapse;
        }
        .auto-style3 {
            width: 302px;
        }
        .auto-style4 {
            width: 302px;
            height: 24px;
        }
        .auto-style5 {
            height: 24px;
        }
        .auto-style6 {
            width: 302px;
            height: 27px;
        }
        .auto-style7 {
            height: 27px;
        }
    </style>

    <link rel ="stylesheet" href ="StyleSheet1.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <h1>mkpits solutions</h1>
            <h2>fortune mall</h2>
        </div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">example</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">country</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>select </asp:ListItem>
                        <asp:ListItem>India</asp:ListItem>
                        <asp:ListItem>Nepal</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">state</td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">city</td>
                <td class="auto-style7">
                    <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">course</td>
                <td class="auto-style5">
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                        <asp:ListItem>Java</asp:ListItem>
                        <asp:ListItem>Dotnet</asp:ListItem>
                        <asp:ListItem>Android</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">centers</td>
                <td>
                    <asp:ListBox ID="ListBox1" runat="server">
                        <asp:ListItem>Nagpur</asp:ListItem>
                        <asp:ListItem>Mumbai</asp:ListItem>
                        <asp:ListItem Selected="True">Chandigarh</asp:ListItem>
                    </asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SUBMIT" />
                </td>
            </tr>
        </table>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:Image ID="Image2" runat="server" Height="137px" ImageUrl="india.png" Width="307px" />
        </p>
    </form>
</body>
</html>
