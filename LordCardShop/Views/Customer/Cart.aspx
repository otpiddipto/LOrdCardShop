<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="LordCardShop.Views.Customer.Cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        


    <h2>Your Cart</h2>

    <asp:Label ID="lblMessage" runat="server" ForeColor="Green" /><br /><br />

    <asp:Repeater ID="rptCart" runat="server" OnItemCommand="rptCart_ItemCommand">
        <HeaderTemplate>
            <table border="1" cellpadding="10" cellspacing="0">
                <tr>
                    <th>Card Name</th>
                    <th>Quantity</th>
                    <th>Price</th>
                    <th>Total</th>
                    <th>Action</th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><%# Eval("Card.CardName") %></td>
                <td><%# Eval("Quantity") %></td>
                <td><%# String.Format("{0:C}", Eval("Card.CardPrice")) %></td>
                <td><%# String.Format("{0:C}", Convert.ToDecimal(Eval("Card.CardPrice")) * Convert.ToInt32(Eval("Quantity"))) %></td>
                <td>
                    <asp:Button ID="btnRemove" runat="server" Text="Remove"
                        CommandName="Remove"
                        CommandArgument='<%# Eval("CardID") %>' />
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>

    <br />
    <asp:Label ID="lblTotal" runat="server" Font-Bold="true" /><br /><br />
    <asp:Button ID="btnClear" runat="server" Text="Clear Cart" OnClick="btnClear_Click" />
    <asp:Button ID="btnCheckout" runat="server" Text="Checkout" OnClick="btnCheckout_Click" />


    </form>
</body>
</html>
