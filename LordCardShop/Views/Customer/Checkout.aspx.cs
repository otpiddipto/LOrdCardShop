using LordCardShop.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LordCardShop.Views.Customer
{
    public partial class Checkout : System.Web.UI.Page
    {
        CartController cartController = new CartController();
        TransactionController transactionController = new TransactionController();

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

                List<LordCardShop.Cart> cart = cartController.GetCart(user.UserId);
                rptCart.DataSource = cart;
                rptCart.DataBind();

                decimal total = cartController.GetTotal(user.UserId);
                lblTotal.Text = "Total: " + total.ToString("C");

                if (cart.Count == 0)
                {
                    lblMessage.Text = "Cart is empty. Redirecting to Cart...";
                    Response.AddHeader("REFRESH", "2;URL=Cart.aspx");
                    btnCheckout.Enabled = false;
                }
            }

            protected void btnCheckout_Click(object sender, EventArgs e)
            {
                User user = Session["User"] as User;
                transactionController.Checkout(user.UserId);
                Response.Redirect("TransactionHistory.aspx");
            }
        
    }

}