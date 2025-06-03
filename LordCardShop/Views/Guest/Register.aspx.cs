using LordCardShop.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LordCardShop.Views.Guest
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        UserController userController = new UserController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string gender = ddlGender.SelectedValue;

            string validationMessage = userController.ValidateRegistration(username, email, password, confirmPassword, gender);

            if (!string.IsNullOrEmpty(validationMessage))
            {
                lblError.Text = validationMessage;
                return;
            }

            userController.RegisterUser(username, email, password, gender);
            Response.Redirect("Login.aspx");
        }
    
    }
}