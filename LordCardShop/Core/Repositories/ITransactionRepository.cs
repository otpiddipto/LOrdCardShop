using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Core.Repositories
{
    public interface ITransactionRepository
    {
        List<Transaction> GetTransactionsByUserId(int userId);
        Transaction GetTransactionById(int id);
        void InsertTransaction(Transaction transaction);
    }
}