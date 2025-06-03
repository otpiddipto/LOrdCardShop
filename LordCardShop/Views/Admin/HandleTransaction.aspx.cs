using LordCardShop.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LordCardShop.Views.Admin
{
    public partial class HandleTransaction : System.Web.UI.Page
    {
        TransactionController TransactionController = new TransactionController();  
        protected void Page_Load(object sender, EventArgs e)
        {
            User admin = Session["User"] as User;
            if (admin == null || admin.UserRole != "Admin")
            {
                Response.Redirect("~/Views/Guest/Login.aspx");
            }

            if (!IsPostBack)
            {
                LoadTransactions();
            }
        }

        private void LoadTransactions()
        {
            List<TransactionHeader> transactions = TransactionController.GetAllTransactions();
            rptTransactions.DataSource = transactions;
            rptTransactions.DataBind();
        }

        protected void rptTransactions_ItemCommand(object source, System.Web.UI.WebControls.RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Handle")
            {
                int id = int.Parse(e.CommandArgument.ToString());
                TransactionController.Handle(id);
                lblMessage.Text = $"Transaction #{id} has been handled.";
                LoadTransactions();
            }
        }
    }
}