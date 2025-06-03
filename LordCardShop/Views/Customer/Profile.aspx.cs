using LordCardShop.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LordCardShop.Views.Customer
{
    public partial class Profile : System.Web.UI.Page
    {

        private User currentUser;

        UserController userController = new UserController();
        protected void Page_Load(object sender, EventArgs e)
        {
            currentUser = Session["User"] as User;
            if (currentUser == null)
            {
                Response.Redirect("~/Views/Guest/Login.aspx");
            }

            if (!IsPostBack)
            {
                LoadProfile();
            }
        }
        private void LoadProfile()
        {
            txtUsername.Text = currentUser.UserName;
            txtEmail.Text = currentUser.UserEmail;
            ddlGender.SelectedValue = currentUser.UserGender;
        }

        protected void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string gender = ddlGender.SelectedValue;

            string error = userController.ValidateProfileUpdate(username, email, gender);
            if (!string.IsNullOrEmpty(error))
            {
                lblMessage.Text = error;
                return;
            }

            currentUser.UserName = username;
            currentUser.UserEmail = email;
            currentUser.UserGender = gender;

            userController.UpdateProfile(currentUser);
            lblMessage.ForeColor = System.Drawing.Color.Green;
            lblMessage.Text = "Profile updated successfully.";
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            string oldPwd = txtOldPassword.Text;
            string newPwd = txtNewPassword.Text;
            string confirmPwd = txtConfirmPassword.Text;

            string error = UserController.ValidatePasswordChange(oldPwd, newPwd, confirmPwd, currentUser.UserPassword);
            if (!string.IsNullOrEmpty(error))
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = error;
                return;
            }

            currentUser.UserPassword = newPwd;
            userController.UpdateProfile(currentUser);
            lblMessage.ForeColor = System.Drawing.Color.Green;
            lblMessage.Text = "Password changed successfully.";
        }

    }
}