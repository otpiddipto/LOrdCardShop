using LordCardShop.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LordCardShop.Handlers
{
    public class TransactionRepository
    {
        LOrdCardShopDatabaseEntities db = new LOrdCardShopDatabaseEntities();

        public  void InsertTransaction(TransactionHeader header, List<TransactionDetail> details)
        {
            
            
                db.TransactionHeaders.Add(header);
                db.SaveChanges();

                foreach (var detail in details)
                {
                    detail.TransactionID = header.TransactionID;
                    db.TransactionDetails.Add(detail);
                }

                db.SaveChanges();
            
        }

        public  void SetHandled(int transactionId)
        {
            
            
                var t = db.TransactionHeaders.Find(transactionId);
                if (t != null)
                {
                    t.Status = "Handled";
                    db.SaveChanges();
                }
            
        }

        public  List<TransactionHeader> GetTransactionsByCustomer(int customerId)
        {
            
            
                return db.TransactionHeaders
                         .Where(t => t.CustomerID == customerId)
                         .OrderByDescending(t => t.TransactionDate)
                         .ToList();
            
        }

        // ✅ Tambahan #2: get all transactions (for admin)
        public  List<TransactionHeader> GetAllTransactions()
        {
            
            
                return db.TransactionHeaders
                         .OrderByDescending(t => t.TransactionDate)
                         .ToList();
            
        }

        // ✅ Tambahan #3: get transaction by id (with details)
        public  TransactionHeader GetTransactionById(int transactionId)
        {
            
                return db.TransactionHeaders
                         .Include("TransactionDetails")
                         .FirstOrDefault(t => t.TransactionID == transactionId);
            
        }

    }
}