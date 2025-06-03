<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="LOrdCardShop.Views.Cart" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cart - Lord Card Shop</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Keranjang Belanja</h2>

        <asp:Label ID="lblMessage" runat="server" ForeColor="Red" /><br /><br />

        <asp:GridView ID="gvCart" runat="server" AutoGenerateColumns="False" OnRowCommand="gvCart_RowCommand">
            <Columns>
                <asp:BoundField DataField="Card.Name" HeaderText="Nama Kartu" />
                <asp:BoundField DataField="Quantity" HeaderText="Jumlah" />

                <asp:TemplateField HeaderText="Aksi">
                    <ItemTemplate>
                        <asp:Button ID="btnHapus" runat="server" CommandName="DeleteItem" CommandArgument='<%# Eval("CartItemID") %>' Text="Hapus" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView><br />

        <asp:Button ID="btnCheckout" runat="server" Text="Checkout" OnClick="btnCheckout_Click" />
    </form>
</body>
</html>