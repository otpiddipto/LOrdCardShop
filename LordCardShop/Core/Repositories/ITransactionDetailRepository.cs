using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Core.Repositories
{
    public interface ITransactionDetailRepository
    {
        List<TransactionDetail> GetDetailsByTransactionId(int transactionId);
        void InsertDetail(TransactionDetail detail);
    }
}