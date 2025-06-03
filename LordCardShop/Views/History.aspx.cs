using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Util;
using LOrdCardShop.Handlers;
using LOrdCardShop.Model;

namespace LOrdCardShop.Views
{
    public partial class History : System.Web.UI.Page
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
                LoadTransactions();
            }
        }

        private void LoadTransactions()
        {
            int userId = Convert.ToInt32(Session["UserID"]);
            List<Transaction> transactions = TransactionHandler.GetUserTransactions(userId);
            gvTransactions.DataSource = transactions;
            gvTransactions.DataBind();
        }

        protected void gvTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = gvTransactions.SelectedIndex;
            int transactionId = Convert.ToInt32(gvTransactions.DataKeys[index].Value);
            LoadTransactionDetails(transactionId);
        }

        private void LoadTransactionDetails(int transactionId)
        {
            List<TransactionDetail> details = TransactionHandler.GetTransactionDetails(transactionId);
            gvDetails.DataSource = details;
            gvDetails.DataBind();
        }
    }
}