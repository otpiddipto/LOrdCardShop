<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditCard.aspx.cs" Inherits="LordCardShop.Views.Admin.EditCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           

            <h2>Edit Card</h2>

            <asp:Label ID="lblMessage" runat="server" ForeColor="Red" /><br /><br />

            <table>
                <tr>
                    <td>Name:</td>
                    <td><asp:TextBox ID="txtName" runat="server" /></td>
                </tr>
                <tr>
                    <td>Price:</td>
                    <td><asp:TextBox ID="txtPrice" runat="server" /></td>
                </tr>
                <tr>
                    <td>Description:</td>
                    <td><asp:TextBox ID="txtDesc" runat="server" TextMode="MultiLine" Rows="3" Columns="40" /></td>
                </tr>
                <tr>
                    <td>Type:</td>
                    <td>
                        <asp:DropDownList ID="ddlType" runat="server">
                            <asp:ListItem Text="Spell" Value="Spell" />
                            <asp:ListItem Text="Monster" Value="Monster" />
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Foil?</td>
                    <td>
                        <asp:RadioButtonList ID="rblFoil" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Text="Yes" Value="1" />
                            <asp:ListItem Text="No" Value="0" />
                        </asp:RadioButtonList>
                    </td>
                </tr>
            </table>

            <br />
            <asp:Button ID="btnUpdate" runat="server" Text="Update Card" OnClick="btnUpdate_Click" />

        </div>
    </form>
</body>
</html>
