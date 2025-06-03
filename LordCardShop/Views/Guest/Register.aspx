<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="LordCardShop.Views.Guest.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Register</h2>
        <div>
            <label>Username:</label><br />
            <asp:TextBox ID="txtUsername" runat="server" /><br /><br />

            <label>Email:</label><br />
            <asp:TextBox ID="txtEmail" runat="server" /><br /><br />

            <label>Password:</label><br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" /><br /><br />

            <label>Confirm Password:</label><br />
            <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" /><br /><br />

            <label>Gender:</label><br />
            <asp:DropDownList ID="ddlGender" runat="server">
                <asp:ListItem Text="Select Gender" Value="" />
                <asp:ListItem Text="Male" Value="Male" />
                <asp:ListItem Text="Female" Value="Female" />
            </asp:DropDownList><br /><br />

            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" /><br /><br />
            <asp:Label ID="lblError" runat="server" ForeColor="Red" />
        </div>
    </form>
</body>
</html>
