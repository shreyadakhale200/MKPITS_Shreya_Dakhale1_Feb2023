<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="depsitWithdrawal.aspx.cs" Inherits="transactionDLL.depsitWithdrawal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ATM<br />
            <br />
            Enter Amount&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Deposit" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Withdrawal" />
            <br />
            <br />
            Result : - <asp:Label ID="Label1" runat="server" Text="____________"></asp:Label>
        </div>
    </form>
</body>
</html>
