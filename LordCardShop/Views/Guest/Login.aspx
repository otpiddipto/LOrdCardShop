<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LordCardShop.Views.Admin.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login LOrdCardShop</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <h2>Login</h2>
            <asp:TextBox ID="txtUsername" runat="server" Placeholder="Username" /><br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Placeholder="Password" /><br />
            <asp:CheckBox ID="chkRememberMe" runat="server" Text="Remember me" /><br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /><br />
            <asp:Label ID="lblError" runat="server" ForeColor="Red" />

        </div>
    </form>
</body>
</html>
