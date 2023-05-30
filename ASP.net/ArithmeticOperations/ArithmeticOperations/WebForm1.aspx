<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ArithmeticOperations.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 64%;
            height: 96px;
            margin-left: 131px;
        }
        .auto-style2 {
            width: 498px;
        }
        .auto-style3 {
            text-align: center;
        }
        .auto-style4 {
            width: 498px;
            text-align: right;
        }
        .auto-style5 {
            text-align: center;
            width: 331px;
        }
        .auto-style6 {
            width: 331px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style3">
            Arithmatic Operations<br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">Number 1</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Number 2</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Result</td>
                    <td class="auto-style6">&nbsp;&nbsp;
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
        </div>
        <div class="auto-style3">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" Width="46px" />
            <asp:Button ID="Button2" runat="server" Text="Subtract" OnClick="Button2_Click" Width="101px" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Multiplication" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Division" />
        </div>
    </form>
</body>
</html>
