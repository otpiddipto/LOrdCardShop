<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionDetail.aspx.cs" Inherits="LordCardShop.Views.Customer.TransactionDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           


                <h2>Transaction Detail</h2>

                <asp:Label ID="lblMessage" runat="server" ForeColor="Red" /><br /><br />

                <asp:Panel ID="pnlDetail" runat="server" Visible="false">
                    <b>Transaction ID:</b> <asp:Label ID="lblID" runat="server" /><br />
                    <b>Date:</b> <asp:Label ID="lblDate" runat="server" /><br />
                    <b>Status:</b> <asp:Label ID="lblStatus" runat="server" /><br /><br />

                    <asp:Repeater ID="rptDetails" runat="server">
                        <HeaderTemplate>
                            <table border="1" cellpadding="10" cellspacing="0">
                                <tr>
                                    <th>Card Name</th>
                                    <th>Quantity</th>
                                    <th>Price</th>
                                    <th>Subtotal</th>
                                </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("Card.CardName") %></td>
                                <td><%# Eval("Quantity") %></td>
                                <td><%# String.Format("{0:C}", Eval("Card.CardPrice")) %></td>
                                <td><%# String.Format("{0:C}", Convert.ToDecimal(Eval("Quantity")) * Convert.ToDecimal(Eval("Card.CardPrice"))) %></td>
                            </tr>
                        </ItemTemplate>
                        <FooterTemplate>
                            </table>
                        </FooterTemplate>
                    </asp:Repeater>
                </asp:Panel>
            

        </div>
    </form>
</body>
</html>
