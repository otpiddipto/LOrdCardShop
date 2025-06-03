using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LOrdCardShop.Model;

namespace LOrdCardShop.Views
{
    public partial class Home : System.Web.UI.Page
    {
        private readonly LOrdCardShopDBEntities1 db = new LOrdCardShopDBEntities1();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string username = Session["Username"] != null ? Session["Username"].ToString() : "Guest";
                lblWelcome.Text = "Halo, " + username + "!";

                LoadAllCards();
            }
        }

        private void LoadAllCards()
        {
            gvCards.DataSource = db.Cards.ToList(); // Tampilkan semua kartu
            gvCards.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            var filtered = db.Cards
                .Where(c => c.Name.ToLower().Contains(keyword))
                .ToList(); // Pencarian berbasis LINQ ke database

            gvCards.DataSource = filtered;
            gvCards.DataBind();
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Login.aspx");
        }
    }
}