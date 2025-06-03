<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="LordCardShop.Views.Customer.Checkout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Checkout</h2>

                <asp:Label ID="lblMessage" runat="server" ForeColor="Red" /><br /><br />

                <asp:Repeater ID="rptCart" runat="server">
                    <HeaderTemplate>
                        <table border="1" cellpadding="10" cellspacing="0">
                            <tr>
                                <th>Card Name</th>
                                <th>Quantity</th>
                                <th>Price</th>
                                <th>Total</th>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("Card.CardName") %></td>
                            <td><%# Eval("Quantity") %></td>
                            <td><%# String.Format("{0:C}", Eval("Card.CardPrice")) %></td>
                            <td><%# String.Format("{0:C}", Convert.ToDecimal(Eval("Card.CardPrice")) * Convert.ToInt32(Eval("Quantity"))) %></td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>

                <br />
                <asp:Label ID="lblTotal" runat="server" Font-Bold="true" /><br /><br />
                <asp:Button ID="btnCheckout" runat="server" Text="Confirm Checkout" OnClick="btnCheckout_Click" />

        </div>
    </form>
</body>
</html>
