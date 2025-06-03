<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LordCardShop.Views.Customer.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HomePage</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
                <h2>Welcome to Lord Card Shop</h2>
                <asp:Label ID="lblInfo" runat="server" ForeColor="Green" />
                <asp:Repeater ID="rptCards" runat="server">
                    <HeaderTemplate>
                        <table border="1" cellpadding="10" cellspacing="0">
                            <tr>
                                <th>Name</th>
                                <th>Type</th>
                                <th>Price</th>
                                <th>Foil</th>
                                <th>Description</th>
                                <th>Action</th>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("CardName") %></td>
                            <td><%# Eval("CardType") %></td>
                            <td><%# String.Format("{0:C}", Eval("CardPrice")) %></td>
                            <td><%# ((byte[])Eval("isFoil"))[0] == 1 ? "Yes" : "No" %></td>
                            <td><%# Eval("CardDesc") %></td>
                            <td>
                                <asp:HyperLink ID="lnkDetail" runat="server"
                                    NavigateUrl='<%# Eval("CardID", "~/Customer/CardDetail.aspx?id={0}") %>'
                                    Text="View Detail" />
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
           
        </div>
    </form>
</body>
</html>
