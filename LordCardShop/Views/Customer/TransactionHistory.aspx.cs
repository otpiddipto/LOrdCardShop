using LordCardShop.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LordCardShop.Views.Customer
{

        public partial class TransactionHistory : Page
        {
        TransactionController TransactionController = new TransactionController();
        protected void Page_Load(object sender, EventArgs e)
            {
                if (!IsPostBack)
                {
                    LoadTransactions();
                }
            }

            private void LoadTransactions()
            {
                User user = Session["User"] as User;
                if (user == null)
                {
                    Response.Redirect("~/Views/Guest/Login.aspx");
                }

                List<TransactionHeader> transactions = TransactionController.GetUserTransactions(user.UserId);
                if (transactions.Count == 0)
                {
                    lblMessage.Text = "You have no transactions.";
                }
                rptTransactions.DataSource = transactions;
                rptTransactions.DataBind();
            }
        }
    

}