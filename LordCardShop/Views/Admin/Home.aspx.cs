using LordCardShop.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LordCardShop.Views.Admin
{
    public partial class Home : System.Web.UI.Page
    {
        CardController CardController = new CardController();
        TransactionController TransactionController = new TransactionController();
        LOrdCardShopDatabaseEntities db = new LOrdCardShopDatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            User admin = Session["User"] as User;
            if (admin == null || admin.UserRole != "Admin")
            {
                Response.Redirect("~/Views/Guest/Login.aspx");
            }

            if (!IsPostBack)
            {
                LoadDashboard(admin);
            }

        }

        private void LoadDashboard(User admin)
        {
            lblWelcome.Text = $"Hello, {admin.UserName}!";

            lblCardCount.Text = CardController.GetAllCards().Count.ToString();
            lblTransactionCount.Text = TransactionController.GetAllTransactions().Count.ToString();
            lblUserCount.Text = GetAllUsersCount().ToString(); // opsional
        }

        private int GetAllUsersCount()
        {
            using (db)
            {
                return db.Users.Count();
            }
        }
    }
}