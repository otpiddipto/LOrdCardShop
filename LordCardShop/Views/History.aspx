<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="LOrdCardShop.Views.History" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>History - Lord Card Shop</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Riwayat Transaksi</h2>

        <asp:Label ID="lblMessage" runat="server" ForeColor="Red" /><br /><br />

        <asp:GridView ID="gvTransactions" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvTransactions_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="TransactionID" HeaderText="ID Transaksi" />
                <asp:BoundField DataField="Date" HeaderText="Tanggal" DataFormatString="{0:dd MMM yyyy}" />
                <asp:BoundField DataField="Status" HeaderText="Status" />
                <asp:CommandField ShowSelectButton="true" SelectText="Lihat Detail" />
            </Columns>
        </asp:GridView>

        <h3>Detail Transaksi</h3>
        <asp:GridView ID="gvDetails" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Card.Name" HeaderText="Nama Kartu" />
                <asp:BoundField DataField="Quantity" HeaderText="Jumlah" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
