<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HandleTransaction.aspx.cs" Inherits="LordCardShop.Views.Admin.HandleTransaction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            


                <h2>Handle Transactions</h2>

                <asp:Label ID="lblMessage" runat="server" ForeColor="Green" /><br /><br />

                <asp:Repeater ID="rptTransactions" runat="server" OnItemCommand="rptTransactions_ItemCommand">
                    <HeaderTemplate>
                        <table border="1" cellpadding="10">
                            <tr>
                                <th>ID</th>
                                <th>Date</th>
                                <th>Customer</th>
                                <th>Status</th>
                                <th>Action</th>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("TransactionID") %></td>
                            <td><%# Eval("TransactionDate", "{0:dd MMM yyyy HH:mm}") %></td>
                            <td><%# Eval("User.UserName") %></td>
                            <td><%# Eval("Status") %></td>
                            <td>
                                <asp:Button ID="btnHandle" runat="server" Text="Handle"
                                    CommandName="Handle"
                                    CommandArgument='<%# Eval("TransactionID") %>'
                                    Enabled='<%# Eval("Status").ToString() != "Handled" %>' />
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
