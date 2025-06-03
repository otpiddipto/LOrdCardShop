using LordCardShop.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LordCardShop.Views.Admin
{
    public partial class ManageCard : System.Web.UI.Page
    {
        CardController cardController = new CardController();

        protected void Page_Load(object sender, EventArgs e)
        {
            User admin = Session["User"] as User;
            if (admin == null || admin.UserRole != "Admin")
            {
                Response.Redirect("~/Views/Guest/Login.aspx");
            }

            if (!IsPostBack)
            {
                LoadCards();
            }

        }

        private void LoadCards()
        {
            List<Card> cards = cardController.GetAllCards();
            rptCards.DataSource = cards;
            rptCards.DataBind();
        }

        protected void rptCards_ItemCommand(object source, System.Web.UI.WebControls.RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                int id = int.Parse(e.CommandArgument.ToString());
                cardController.DeleteCard(id);
                LoadCards();
            }
        }
    }
}