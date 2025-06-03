<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageCard.aspx.cs" Inherits="LordCardShop.Views.Admin.ManageCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            


                <h2>Manage Cards</h2>

                <asp:HyperLink ID="lnkAddCard" runat="server" NavigateUrl="AddCard.aspx">+ Add New Card</asp:HyperLink>
                <br /><br />
                <asp:Label ID="lblMessage" runat="server" ForeColor="Red" /><br />

                <asp:Repeater ID="rptCards" runat="server" OnItemCommand="rptCards_ItemCommand">
                    <HeaderTemplate>
                        <table border="1" cellpadding="10">
                            <tr>
                                <th>Name</th>
                                <th>Type</th>
                                <th>Price</th>
                                <th>Foil</th>
                                <th>Description</th>
                                <th>Actions</th>
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
                                <asp:HyperLink ID="lnkEdit" runat="server"
                                    NavigateUrl='<%# Eval("CardID", "EditCard.aspx?id={0}") %>' Text="Edit" />
                                &nbsp;|&nbsp;
                                <asp:Button ID="btnDelete" runat="server" Text="Delete"
                                    CommandName="Delete"
                                    CommandArgument='<%# Eval("CardID") %>' OnClientClick="return confirm('Delete this card?');" />
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
