using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LordCardShop.Factories
{
    public class TransactionFactory
    {
        public static TransactionHeader CreateTransaction(int customerId)
        {
            return new TransactionHeader
            {
                TransactionDate = DateTime.Now,
                CustomerID = customerId,
                Status = "Unhandled"
            };
        }

        public static TransactionDetail CreateTransactionDetail(int transactionId, int cardId, int quantity)
        {
            return new TransactionDetail
            {
                TransactionID = transactionId,
                CardID = cardId,
                Quantity = quantity
            };
        }
    }
}