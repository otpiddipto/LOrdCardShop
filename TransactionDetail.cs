 
using LordCardShop.Controllers;  
using System;  
using System.Collections.Generic;  
using System.EnterpriseServices;  
using System.Linq;  
using System.Web;  
using System.Web.UI;  
using System.Web.UI.WebControls;  

namespace LordCardShop.Views.Customer  
{  
    public partial class TransactionDetail : System.Web.UI.Page  
    {  
        TransactionController TransactionController = new TransactionController();  

        protected void Page_Load(object sender, EventArgs e)  
        {  
            if (!IsPostBack)  
            {  
                LoadDetail();  
            }  
        }  

        private void LoadDetail()  
        {  
            if (Request.QueryString["id"] == null)  
            {  
                lblMessage.Text = "Transaction ID not found.";  
                return;  
            }  

            int transactionId;  
            if (!int.TryParse(Request.QueryString["id"], out transactionId))  
            {  
                lblMessage.Text = "Invalid transaction ID.";  
                return;  
            }  

            var transaction = TransactionController.GetTransactionDetail(transactionId);  
            if (transaction == null)  
            {  
                lblMessage.Text = "Transaction not found.";  
                return;  
            }  

            // Display transaction info  
            pnlDetail.Visible = true;  
            lblID.Text = transaction.TransactionID.ToString();  
            lblDate.Text = transaction.TransactionDate.ToString("dd MMM yyyy HH:mm");  
            lblStatus.Text = transaction.Status;  

            // Bind card details  
            rptDetails.DataSource = TransactionController.GetTransactionDetail(transactionId);  
            rptDetails.DataBind();  
        }  
    }  
}  
