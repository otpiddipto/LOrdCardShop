using LOrdCardShop.Core.Repositories;
using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LOrdCardShop.Infrastructure.Repositories;

namespace LOrdCardShop.Infrastructure.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly LOrdCardShopDBEntities1 db = new LOrdCardShopDBEntities1();

        public List<Transaction> GetTransactionsByUserId(int userId)
        {
            return db.Transactions.Where(t => t.UserID == userId).ToList();
        }

        public Transaction GetTransactionById(int id)
        {
            return db.Transactions.FirstOrDefault(t => t.TransactionID == id);
        }

        public void InsertTransaction(Transaction transaction)
        {
            db.Transactions.Add(transaction);
            db.SaveChanges();
        }
    }
}