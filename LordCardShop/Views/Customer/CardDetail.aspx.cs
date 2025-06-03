using LordCardShop.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LordCardShop.Views.Customer
{
    public partial class CardDetail : System.Web.UI.Page
    {
        CardController CardController = new CardController();
        CartController CartController = new CartController();

        protected Card currentCard;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] == null)
                {
                    Response.Redirect("Home.aspx");
                }

                int cardId = int.Parse(Request.QueryString["id"]);
                currentCard = CardController.GetCard(cardId);

                if (currentCard == null)
                {
                    lblMessage.Text = "Card not found.";
                    btnAddToCart.Enabled = false;
                }
                else
                {
                    lblName.Text = currentCard.CardName;
                    lblType.Text = currentCard.CardType;
                    lblPrice.Text = string.Format("{0:C}", currentCard.CardPrice);
                    lblFoil.Text = currentCard.isFoil[0] == 1 ? "Yes" : "No";
                    lblDesc.Text = currentCard.CardDesc;
                    ViewState["CardID"] = cardId;
                }

            }
        }
        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            User user = Session["User"] as User;
            if (user == null)
            {
                Response.Redirect("~/Views/Guest/Login.aspx");
            }

            if (!int.TryParse(txtQuantity.Text, out int qty) || qty <= 0)
            {
                lblMessage.Text = "Quantity must be a positive number.";
                return;
            }

            int cardId = (int)ViewState["CardID"];
            CartController.AddToCart(user.UserId, cardId, qty);
            lblMessage.ForeColor = System.Drawing.Color.Green;
            lblMessage.Text = "Added to cart!";
        }

    }
}