using LordCardShop.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LordCardShop.Views.Customer
{
    public partial class Home : System.Web.UI.Page
    {
        CardController CardController = new CardController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCards();
            }
        }

        private void LoadCards()
        {
            List<Card> cards = CardController.GetAllCards();
            if (cards.Count == 0)
            {
                lblInfo.Text = "No cards available.";
            }
            rptCards.DataSource = cards;
            rptCards.DataBind();
        }
    }

}