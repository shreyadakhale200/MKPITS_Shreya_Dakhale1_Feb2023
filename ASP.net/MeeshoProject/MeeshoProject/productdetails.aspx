<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="productdetails.aspx.cs" Inherits="MeeshoProject.productdetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <head>
        <style>
            a{
                text-decoration:none;
            }
            thead, tbody, tfoot, tr, td, th {
  border-color: inherit;
  border-style: solid;
  border-width: 0;
  padding-left: 7em;
}
            #MainContent_DataList1_Image1_0 {
 border: 3px solid lightgray;
padding: 8px;
margin: 80px 0px 2px 18px;
}
            .bodmeesho {
  border: 2px solid lightgray;
  padding: 3em;
  margin: 0em;
}
 .size {
  border: 2px solid lightgray;
  padding: 11px;
  font-size: 2em;
}
 .cart {
  background-color: darkblue;
padding: 1em 1em 1em 1em;
margin-left: 2em;
color: aliceblue;
font-size: 19px;
border-radius: 18px;
text-decoration: none;
font-family: calibri;
}
 .buy {
  background-color: darkblue;
  padding: 1em 1em 1em 1em;
  margin-left: 2em;
  color: white;
  font-size: 19px;
  border-radius: 18px;
  text-decoration: none;
  font-family: calibri;
}
 .cart:hover,.buy:hover{
     background-color:#5252bd;
     color:white;
 }

        </style>
    </head>
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
<%--            <asp:Label ID="prodname" Text='<%# Eval("prodname") %>' runat ="server"/>--%>

            <table width="100%" class="products">
                <tr>
                    <td>
                          <asp:Image ID="Image1" ImageUrl='<%# Bind("prodimage", "~/images/{0}") %>' runat="server"  Height="380px" Width="320px" ImageAlign="AbsMiddle" EnableTheming="true" />
                    </td>
                    <td>
                        <p class="bodmeesho">

                            <span style="color:gray;font-size:2em;">
                        <asp:Label ID="prodname" Text='<%# Eval("prodname") %>' runat ="server" /></b><br />
                            </span>
                            <span style="font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;">
                        &#8377; <asp:Label ID="prodprice" Text='<%# Eval("prodprice") %>' runat ="server"/><br />
                            </span>
                                <small style="font-size: x-large;">
                            Free Delivery
                            </small>
                        </p>
                        <br />
                        <span class="size">
                            SIZE :  XS , S , M , L , XL , XXL , XXL
                        </span>
                    </td>
                </tr>
            </table>
            <br />
            <table>
                <tr>
                    <td>

                        <%--prodid parameter is passed to the cart.aspx page--%>
                        <a href='<%# Eval("prodid","cart.aspx?prodid={0}") %>'>
                        <span class="cart">Add To Cart</span>
                        </a>

                        <a href="addToCart.aspx" class="buy">Buy Now</a>
                    </td>
                    
                    

                </tr>

            </table>
                  
        
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
