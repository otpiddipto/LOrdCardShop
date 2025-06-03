<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LOrdCardShop.Views.Home" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home - Lord Card Shop</title>
</head>
<body>
    <form id="form1" runat="server">

        <h2><asp:Label ID="lblWelcome" runat="server" /></h2>

        <asp:HyperLink ID="hlCart" runat="server" NavigateUrl="Cart.aspx">🛒 Lihat Keranjang</asp:HyperLink><br />
        <asp:HyperLink ID="hlHistory" runat="server" NavigateUrl="History.aspx">📜 Riwayat Transaksi</asp:HyperLink><br />
        <asp:LinkButton ID="btnLogout" runat="server" OnClick="btnLogout_Click">🚪 Logout</asp:LinkButton><br /><br />

        <hr />
        <h3>Cari Kartu</h3>
        <asp:Label ID="lblSearch" runat="server" Text="Masukkan nama kartu:" /><br />
        <asp:TextBox ID="txtSearch" runat="server" Width="200px" />
        <asp:Button ID="btnSearch" runat="server" Text="Cari" OnClick="btnSearch_Click" /><br /><br />

        <asp:GridView ID="gvCards" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Nama Kartu" />
                <asp:BoundField DataField="Type" HeaderText="Tipe" />
                <asp:BoundField DataField="Price" HeaderText="Harga" DataFormatString="{0:C}" />
                <asp:BoundField DataField="Foil" HeaderText="Foil" />
                <asp:BoundField DataField="Description" HeaderText="Deskripsi" />
            </Columns>
        </asp:GridView>

    </form>
</body>
</html>