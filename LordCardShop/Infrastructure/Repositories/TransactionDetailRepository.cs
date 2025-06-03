using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LOrdCardShop.Core.Repositories;
using LOrdCardShop.Infrastructure.Repositories;
using LOrdCardShop.Model;

namespace LOrdCardShop.Infrastructure.Repositories
{
    public class TransactionDetailRepository : ITransactionDetailRepository
    {
        private readonly LOrdCardShopDBEntities1 db = new LOrdCardShopDBEntities1();

        public List<TransactionDetail> GetDetailsByTransactionId(int transactionId)
        {
            return db.TransactionDetails.Where(d => d.TransactionID == transactionId).ToList();
        }

        public void InsertDetail(TransactionDetail detail)
        {
            db.TransactionDetails.Add(detail);
            db.SaveChanges();
        }
    }
}