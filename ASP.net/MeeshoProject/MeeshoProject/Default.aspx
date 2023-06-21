<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MeeshoProject._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <head>
        <style>
            .sc-iBYQkv.jpEZQQ {
                 background-color: #3a86c8;
                 margin: 10px 0em 0em 0em;
                 padding: 20px 28.3em 1em 5em;
                 width: 91%;
            }
            .symbols{
                width: 10em;
                height: 2em;
                margin-top: -2em;
                border-radius: 8px;
            }
            img {
  width: 10em;
  margin-top: 14px;
}
            .meeshoimg {
              width: 12em;
              height: 8em;
              padding-left: 1em;
            
            }
            #DataList1{
            }
           /* MainContent_DataList1_Image1_0{
                height:200px;width:160px;
            }*/
           

        </style>
    </head>
    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 class="sc-iBYQkv jpEZQQ" color="greyBase" font-size="48px" font-weight="bold"><span class="VideoBanner__TextUnderline-sc-149azki-3 demnYS"></span>
                <table width="100%">
                    <tr>
                        <td width="50%" class="slo1"> <span class="slogan">Lowest Prices <br /> Best Quality Shopping</span></td>
                        <td width="50%">
                            <img src="https://images.meesho.com/images/marketing/1687149525469_512.webp" alt="Alternate Text" class="meeshoimg"/>    </td>
                    </tr>
                    
                        <td>
                            <div class="symbols" style="background-color:white;">
                                <img src="Screenshot 2023-06-21 at 14-59-59 Online Shopping Site for Fashion Electronics Home & More Meesho.png" alt="Alternate Text" /></div>
                        </td>
                    
                </table>
               
                
                <span class="VideoBanner__TextUnderline-sc-149azki-3 demnYS"></span></h1>
            <h1 id="aspnetTitle">&nbsp;</h1>
        </section>
    <div class="row">
            <section class="col-md-4" aria-labelledby="hostingTitle">
                <p>
 &nbsp;<asp:DataList ID="DataList1" runat="server" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" CssClass="noBorderStyle" RepeatColumns="4" Width="100%" RepeatDirection="Horizontal" EnableTheming="True">
<ItemTemplate>
<table cellpadding="2" cellspacing="4" border="1" style="width: 300px; height: 100px;
border:3px solid black">
<tr>
<td align="center">
    <asp:HyperLink ID="myLink" runat="server" NavigateUrl='<%# "Contact.aspx?id=" + Eval("prodimage") %>'>
<asp:Image ID="Image1" ImageUrl='<%# Bind("prodimage", "~/images/{0}") %>' runat="server"  Height="380px" Width="320px" ImageAlign="AbsMiddle" EnableTheming="true" />
        </asp:HyperLink>

</td>
</tr>

<tr>
<td align="center">
<span > <%# Eval("prodname") %></span><br />
<span > <%# Eval("proddescription") %></span><br />
<span >Rs. <%# Eval("prodprice") %> onwards</span><br />

</td>
</tr>
</table>
</ItemTemplate>
                    </asp:DataList>
                </p>
            </section>
        </div>
    </main>

</asp:Content>
