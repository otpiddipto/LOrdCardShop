using LordCardShop.Controllers;
using LordCardShop.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LordCardShop.Views.Admin
{
    public partial class AddCard : System.Web.UI.Page
    {
        CardController cardController = new CardController();
        protected void Page_Load(object sender, EventArgs e)
        {
            User admin = Session["User"] as User;
            if (admin == null || admin.UserRole != "Admin")
            {
                Response.Redirect("~/Views/Guest/Login.aspx");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
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

            Card card = CardFactory.CreateCard(name, price, desc, type, isFoil);
            cardController.AddCard(card);
            Response.Redirect("ManageCard.aspx");
        }
    }
}