<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CardDetail.aspx.cs" Inherits="LordCardShop.Views.Customer.CardDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
            

        
            <h2>Card Detail</h2>

            <asp:Label ID="lblMessage" runat="server" ForeColor="Red" /><br /><br />

            <table>
                <tr>
                    <td>Name:</td>
                    <td><asp:Label ID="lblName" runat="server" /></td>
                </tr>
                <tr>
                    <td>Type:</td>
                    <td><asp:Label ID="lblType" runat="server" /></td>
                </tr>
                <tr>
                    <td>Price:</td>
                    <td><asp:Label ID="lblPrice" runat="server" /></td>
                </tr>
                <tr>
                    <td>Foil:</td>
                    <td><asp:Label ID="lblFoil" runat="server" /></td>
                </tr>
                <tr>
                    <td>Description:</td>
                    <td><asp:Label ID="lblDesc" runat="server" /></td>
                </tr>
                <tr>
                    <td>Quantity:</td>
                    <td><asp:TextBox ID="txtQuantity" runat="server" Text="1" /></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="btnAddToCart" runat="server" Text="Add to Cart" OnClick="btnAddToCart_Click" /></td>
                </tr>
            </table>
        

        
    </form>
</body>
</html>
