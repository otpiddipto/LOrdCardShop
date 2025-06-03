using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Core.Factories
{
    public interface ITransactionDetailFactory
    {
        TransactionDetail CreateDetail(int transactionId, int cardId, int quantity);
    }
}