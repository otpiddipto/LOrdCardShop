using LordCardShop.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LordCardShop.Views.Admin
{
    public partial class EditCard : System.Web.UI.Page
    {

        CardController cardController = new CardController();
        private int cardId;
        protected void Page_Load(object sender, EventArgs e)
        {
            User admin = Session["User"] as User;
            if (admin == null || admin.UserRole != "Admin")
            {
                Response.Redirect("~/Views/Guest/Login.aspx");
            }

            if (Request.QueryString["id"] == null || !int.TryParse(Request.QueryString["id"], out cardId))
            {
                Response.Redirect("ManageCard.aspx");
            }

            if (!IsPostBack)
            {
                LoadCard();
            }
        }

        private void LoadCard()
        {
            var card = cardController.GetCard(cardId);
            if (card == null)
            {
                lblMessage.Text = "Card not found.";
                return;
            }

            txtName.Text = card.CardName;
            txtPrice.Text = card.CardPrice.ToString();
            txtDesc.Text = card.CardDesc;
            ddlType.SelectedValue = card.CardType;
            rblFoil.SelectedValue = card.isFoil[0].ToString();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string priceText = txtPrice.Text.Trim();
            string desc = txtDesc.Text.Trim();
            string type = ddlType.SelectedValue;
            string foilValue = rblFoil.SelectedValue;

            if (!double.TryParse(priceText, out double price))
            {
                lblMessage.Text = "Price must be a valid number.";
                return;
            }

            byte[] isFoil = new byte[] { foilValue == "1" ? (byte)1 : (byte)0 };

            string error = cardController.ValidateCard(name, price, desc, type, isFoil);
            if (!string.IsNullOrEmpty(error))
            {
                lblMessage.Text = error;
                return;
            }

            Card updatedCard = new Card
            {
                CardID = cardId,
                CardName = name,
                CardPrice = price,
                CardDesc = desc,
                CardType = type,
                isFoil = isFoil
            };

            cardController.UpdateCard(updatedCard);
            Response.Redirect("ManageCard.aspx");
        }
    }
}