<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LordCardShop.Views.Admin.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          


                <h2>Welcome, Admin</h2>

                <asp:Label ID="lblWelcome" runat="server" Font-Bold="true" Font-Size="Large" /><br /><br />

                <table border="1" cellpadding="10">
                    <tr>
                        <th>Total Cards</th>
                        <th>Total Transactions</th>
                        <th>Total Users</th>
                    </tr>
                    <tr>
                        <td><asp:Label ID="lblCardCount" runat="server" /></td>
                        <td><asp:Label ID="lblTransactionCount" runat="server" /></td>
                        <td><asp:Label ID="lblUserCount" runat="server" /></td>
                    </tr>
                </table>
            

        </div>
    </form>
</body>
</html>
