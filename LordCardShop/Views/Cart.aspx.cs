using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LOrdCardShop.Handlers;
using LOrdCardShop.Model;
using LOrdCardShop.Views;

namespace LOrdCardShop.Views
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }

            if (!IsPostBack)
            {
                LoadCartItems();
            }
        }

        private void LoadCartItems()
        {
            int userId = Convert.ToInt32(Session["UserID"]);
            List<CartItem> cartItems = CartHandler.GetCartItems(userId);
            gvCart.DataSource = cartItems;
            gvCart.DataBind();
        }

        protected void gvCart_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            if (e.CommandName == "DeleteItem")
            {
                int cartItemId = Convert.ToInt32(e.CommandArgument);
                CartHandler.RemoveItem(cartItemId);
                LoadCartItems();
            }
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(Session["UserID"]);
            string result = TransactionHandler.Checkout(userId);

            if (result == "SUCCESS")
            {
                Response.Redirect("History.aspx");
            }
            else
            {
                lblMessage.Text = result;
            }
        }
    }
}