using LOrdCardShop.Core.Factories;
using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LOrdCardShop.Infrastructure.Factories;

namespace LOrdCardShop.Infrastructure.Factories
{
    public class TransactionFactory : ITransactionFactory
    {
        public Transaction CreateTransaction(int userId, DateTime date)
        {
            return new Transaction
            {
                UserID = userId,
                Date = date,           
                Status = "Pending"     
            };
        }
    }
}