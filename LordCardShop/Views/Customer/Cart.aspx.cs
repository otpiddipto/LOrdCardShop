using LordCardShop.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LordCardShop.Views.Customer
{
    public partial class Cart : System.Web.UI.Page
    {
        CartController CartController = new CartController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCart();
            }
        }

        private void LoadCart()
        {
            User user = Session["User"] as User;
            if (user == null)
            {
                Response.Redirect("~/Views/Guest/Login.aspx");
            }

            List<LordCardShop.Cart> cart = CartController.GetCart(user.UserId);
            rptCart.DataSource = cart;
            rptCart.DataBind();

            decimal total = CartController.GetTotal(user.UserId);
            lblTotal.Text = "Total: " + total.ToString("C");

            lblMessage.Text = cart.Count == 0 ? "Your cart is empty." : "";
        }

        protected void rptCart_ItemCommand(object source, System.Web.UI.WebControls.RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Remove")
            {
                int cardId = int.Parse(e.CommandArgument.ToString());
                User user = Session["User"] as User;
                CartController.RemoveItem(user.UserId, cardId);
                LoadCart();
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            User user = Session["User"] as User;
            CartController.ClearCart(user.UserId);
            LoadCart();
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Customer/Checkout.aspx");
        }
    }
}