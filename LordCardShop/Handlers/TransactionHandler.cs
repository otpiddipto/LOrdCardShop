using LordCardShop.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LordCardShop.Handlers
{
    public class TransactionHandler
    {
        TransactionRepository transactionRepository = new TransactionRepository();
        CartRepository cartRepository = new CartRepository();

        public  void Checkout(int userId)
        {
            var cartItems = cartRepository.GetCartByUser(userId);
            if (cartItems == null || !cartItems.Any()) return;

            var header = TransactionFactory.CreateTransaction(userId);
            var details = cartItems.Select(item =>
                TransactionFactory.CreateTransactionDetail(0, item.CardID, item.Quantity)).ToList();

            transactionRepository.InsertTransaction(header, details);
            cartRepository.ClearCart(userId);
        }

        public  void HandleTransaction(int transactionId)
        {
            transactionRepository.SetHandled(transactionId);
        }

        public  List<TransactionHeader> GetTransactionsForUser(int userId)
        {
            return transactionRepository.GetTransactionsByCustomer(userId);
        }

        public  List<TransactionHeader> GetAllTransactions()
        {
            return transactionRepository.GetAllTransactions();
        }

        public TransactionHeader GetTransactionDetail(int transactionId)
        {
            return transactionRepository.GetTransactionById(transactionId);
        }


    }
}