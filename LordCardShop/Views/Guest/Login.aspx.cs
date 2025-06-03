using LordCardShop.Controllers;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LordCardShop.Views.Admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        UserController UserController = new UserController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Request.Cookies["RememberMe"] != null)
            {
                string username = Request.Cookies["RememberMe"]["Username"];
                string password = Request.Cookies["RememberMe"]["Password"];

                User user = UserController.Login(username, password);
                if (user != null)
                {
                    Session["User"] = user;
                    RedirectToHome(user.UserRole);
                }
            }

        }

       

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            User user = UserController.Login(username, password);
            if (user != null)
            {
                Session["User"] = user;

                if (chkRememberMe.Checked)
                {
                    HttpCookie cookie = new HttpCookie("RememberMe");
                    cookie.Values["Username"] = username;
                    cookie.Values["Password"] = password;
                    cookie.Expires = DateTime.Now.AddDays(7);
                    Response.Cookies.Add(cookie);
                }

                RedirectToHome(user.UserRole);
            }
            else
            {
                lblError.Text = "Invalid username or password.";
            }
        }

        private void RedirectToHome(string role)
        {
            if (role == "Admin")
                Response.Redirect("~/Admin/Home.aspx");
            else if (role == "Customer")
                Response.Redirect("~/Customer/Home.aspx");
        }
    }



    
}