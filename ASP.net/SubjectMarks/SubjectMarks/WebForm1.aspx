<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SubjectMarks.WebForm1" %>

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
            width: 743px;
            text-align: left;
        }
        .auto-style4 {
            width: 743px;
            height: 26px;
            text-align: left;
        }
        .auto-style5 {
            height: 26px;
        }
        .auto-style6 {
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Subject Marks Percentage Calculation</div>
        <hr />
        <p class="auto-style1">
            Subject 1&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style1">
            Subject 2&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style1">
            Subject 3&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style1">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Result" />
        </p>
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">
                    <p class="auto-style6">
                        Total&nbsp;&nbsp;&nbsp;
                    </p>
                </td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <p class="auto-style6">
                        Percentage&nbsp;&nbsp;&nbsp;
                    </p>
                </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <p class="auto-style6">
                        Grade&nbsp;&nbsp;&nbsp;
                    </p>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
