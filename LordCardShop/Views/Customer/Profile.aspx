<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="LordCardShop.Views.Customer.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

               

                <h2>My Profile</h2>

                <asp:Label ID="lblMessage" runat="server" ForeColor="Red" /><br /><br />

                <asp:Panel ID="pnlProfile" runat="server">
                    <b>Username:</b><br />
                    <asp:TextBox ID="txtUsername" runat="server" /><br /><br />

                    <b>Email:</b><br />
                    <asp:TextBox ID="txtEmail" runat="server" /><br /><br />

                    <b>Gender:</b><br />
                    <asp:DropDownList ID="ddlGender" runat="server">
                        <asp:ListItem Text="Male" Value="Male" />
                        <asp:ListItem Text="Female" Value="Female" />
                    </asp:DropDownList><br /><br />

                    <asp:Button ID="btnUpdateProfile" runat="server" Text="Update Profile" OnClick="btnUpdateProfile_Click" /><br /><br />
                </asp:Panel>

                <hr />

                <h3>Change Password</h3>
                <asp:TextBox ID="txtOldPassword" runat="server" TextMode="Password" Placeholder="Old Password" /><br />
                <asp:TextBox ID="txtNewPassword" runat="server" TextMode="Password" Placeholder="New Password" /><br />
                <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" Placeholder="Confirm Password" /><br /><br />
                <asp:Button ID="btnChangePassword" runat="server" Text="Change Password" OnClick="btnChangePassword_Click" />


        </div>
    </form>
</body>
</html>
