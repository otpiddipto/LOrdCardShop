using LordCardShop.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LordCardShop.Controllers
{
    public class TransactionController
    {
        TransactionHandler TransactionHandler = new TransactionHandler();
        public void Checkout(int userId)
        {
            TransactionHandler.Checkout(userId);
        }

        public  void Handle(int transactionId)
        {
            TransactionHandler.HandleTransaction(transactionId);
        }

        public List<TransactionHeader> GetUserTransactions(int userId)
        {
            return TransactionHandler.GetTransactionsForUser(userId);
        }

        public  List<TransactionHeader> GetAllTransactions()
        {
            return TransactionHandler.GetAllTransactions();
        }

        public TransactionHeader GetTransactionDetail(int transactionId)
        {
            return TransactionHandler.GetTransactionDetail(transactionId);
        }
    }

}