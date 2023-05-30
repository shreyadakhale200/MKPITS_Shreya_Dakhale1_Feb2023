<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ArithmeticOperations1.WebForm1" %>

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
        }
        .auto-style3 {
            width: 216px;
            text-align: center;
        }
        .auto-style4 {
            width: 309px;
        }
        .auto-style5 {
            width: 216px;
            height: 26px;
            text-align: center;
        }
        .auto-style6 {
            width: 309px;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        <div class="auto-style1">
            Operations</div>
        <hr />
            <table class="auto-style2">
                <tr>
                    <td class="auto-style3">Number 1</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Number 2</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Result</td>
                    <td class="auto-style4">
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Subtract" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Multiply" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Delete" />
        </div>
    </form>
</body>
</html>
