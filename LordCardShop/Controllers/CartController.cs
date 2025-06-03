using LordCardShop.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LordCardShop.Controllers
{
    public class CartController
    {
        CartHandler CartHandler = new CartHandler();
        public  void AddToCart(int userId, int cardId, int quantity)
        {
            CartHandler.AddtoCart(userId, cardId, quantity);
        }

        public  List<Cart> GetCart(int userId)
        {
            return CartHandler.GetCartItems(userId);
        }

        public void RemoveItem(int userId, int cardId)
        {
            CartHandler.RemoveItem(userId, cardId);
        }

        public  void ClearCart(int userId)
        {
            CartHandler.ClearCart(userId);
        }

        public decimal GetTotal(int userId)
        {
            return CartHandler.GetCartTotal(userId);
        }
    }

}