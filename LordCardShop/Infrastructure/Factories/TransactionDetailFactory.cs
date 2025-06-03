using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LOrdCardShop.Core.Factories;
using LOrdCardShop.Infrastructure.Factories;
using LOrdCardShop.Model;

namespace LOrdCardShop.Infrastructure.Factories
{
    public class TransactionDetailFactory : ITransactionDetailFactory
    {
        public TransactionDetail CreateDetail(int transactionId, int cardId, int quantity)
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