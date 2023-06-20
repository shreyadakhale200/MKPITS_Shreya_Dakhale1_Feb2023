<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Transaction.aspx.cs" Inherits="ProductInvoice.Transaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style11 {
            font-size: large;
        }
        .auto-style12 {
            font-size: xx-large;
            margin-left: 40px;
        }
        .auto-style13 {
            margin-left: 720px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style2">
        Transaction<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TrustProjectConnectionString %>" SelectCommand="SELECT [Item_Id], [Item_Name] FROM [Item_master]"></asp:SqlDataSource>
    </p>
    <p class="auto-style12">
        <span class="auto-style11">&nbsp;&nbsp;Transaction Type&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged1" Text="Issue" AutoPostBack="True" GroupName="mode" />
&nbsp;&nbsp;&nbsp; </span>
        <asp:RadioButton ID="RadioButton2" runat="server" CssClass="auto-style11" Text="Purchase" AutoPostBack="True" GroupName="mode" OnCheckedChanged="RadioButton2_CheckedChanged" />
    </p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Item Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList6" runat="server" DataSourceID="SqlDataSource1" DataTextField="Item_Name" DataValueField="Item_Id" Width="179px">
    </asp:DropDownList>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Department Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox8" runat="server" TextMode="Date" Width="174px"></asp:TextBox>
            &nbsp;<asp:Panel ID="Panel1" runat="server">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Department Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList7" runat="server" DataSourceID="SqlDataSource2" DataTextField="Department_name" DataValueField="Department_id" Width="183px">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:TrustProjectConnectionString %>" SelectCommand="SELECT [Department_id], [Department_name] FROM [Department_mast]"></asp:SqlDataSource>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Vendor Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:DropDownList ID="DropDownList8" runat="server" DataSourceID="SqlDataSource3" DataTextField="Vendor_name" DataValueField="Vendor_id" Width="190px">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:TrustProjectConnectionString %>" SelectCommand="SELECT [Vendor_id], [Vendor_name] FROM [Vendor_mast]"></asp:SqlDataSource>
    </asp:Panel>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Quantity&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox9" runat="server" Width="174px"></asp:TextBox>
            &nbsp;<p>
        <asp:Button ID="Button1" runat="server" Text="Save" CssClass="auto-style11" OnClick="Button1_Click" />
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" CssClass="auto-style11" OnClick="Button2_Click" Text="Load" />
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <p class="auto-style13">
        &nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Transaction_id" DataSourceID="SqlDataSource4" Width="933px">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="Transaction_id" HeaderText="Transaction_id" InsertVisible="False" ReadOnly="True" SortExpression="Transaction_id" />
                <asp:BoundField DataField="item_id" HeaderText="item_id" SortExpression="item_id" />
                <asp:BoundField DataField="transaction_date" HeaderText="transaction_date" SortExpression="transaction_date" />
                <asp:BoundField DataField="Department_id" HeaderText="Department_id" SortExpression="Department_id" />
                <asp:BoundField DataField="Vendor_Id" HeaderText="Vendor_Id" SortExpression="Vendor_Id" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:TrustProjectConnectionString %>" DeleteCommand="DELETE FROM [Transaction_Proces] WHERE [Transaction_id] = @Transaction_id" InsertCommand="INSERT INTO [Transaction_Proces] ([item_id], [transaction_date], [Department_id], [Vendor_Id], [Quantity]) VALUES (@item_id, @transaction_date, @Department_id, @Vendor_Id, @Quantity)" SelectCommand="SELECT [Transaction_id], [item_id], [transaction_date], [Department_id], [Vendor_Id], [Quantity] FROM [Transaction_Proces]" UpdateCommand="UPDATE [Transaction_Proces] SET [item_id] = @item_id, [transaction_date] = @transaction_date, [Department_id] = @Department_id, [Vendor_Id] = @Vendor_Id, [Quantity] = @Quantity WHERE [Transaction_id] = @Transaction_id">
            <DeleteParameters>
                <asp:Parameter Name="Transaction_id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="item_id" Type="Int32" />
                <asp:Parameter DbType="Date" Name="transaction_date" />
                <asp:Parameter Name="Department_id" Type="Int32" />
                <asp:Parameter Name="Vendor_Id" Type="Int32" />
                <asp:Parameter Name="Quantity" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="item_id" Type="Int32" />
                <asp:Parameter DbType="Date" Name="transaction_date" />
                <asp:Parameter Name="Department_id" Type="Int32" />
                <asp:Parameter Name="Vendor_Id" Type="Int32" />
                <asp:Parameter Name="Quantity" Type="Int32" />
                <asp:Parameter Name="Transaction_id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </p>
</asp:Content>
