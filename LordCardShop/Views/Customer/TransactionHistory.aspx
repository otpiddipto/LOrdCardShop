<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="LordCardShop.Views.Customer.TransactionHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>



            <h2>Transaction History</h2>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red" /><br /><br />

            <asp:Repeater ID="rptTransactions" runat="server">
                <HeaderTemplate>
                    <table border="1" cellpadding="10" cellspacing="0">
                        <tr>
                            <th>ID</th>
                            <th>Date</th>
                            <th>Status</th>
                            <th>Action</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("TransactionID") %></td>
                        <td><%# Eval("TransactionDate", "{0:dd MMM yyyy HH:mm}") %></td>
                        <td><%# Eval("Status") %></td>
                        <td>
                            <asp:HyperLink ID="lnkDetail" runat="server"
                                NavigateUrl='<%# Eval("TransactionID", "TransactionDetail.aspx?id={0}") %>'
                                Text="View Details" />
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
