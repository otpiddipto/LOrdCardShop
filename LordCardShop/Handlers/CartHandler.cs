using LordCardShop.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LordCardShop.Handlers
{
    public class CartHandler
    {

        CartRepository cartRepository = new CartRepository();
       

        public void AddtoCart(int userId, int cardId, int quantity)
        {
            var existing = cartRepository.GetCartItem(userId, cardId);
            if (existing != null)
            {
                existing.Quantity += quantity;
                cartRepository.UpdateCart(existing);
            }
            else
            {
                var newCart = CartFactory.CreateCart(userId, cardId, quantity);
                cartRepository.InsertCart(newCart);
            }
        }

        public  List<Cart> GetCartItems(int userId)
        {
            return cartRepository.GetCartByUser(userId);
        }

        public  void RemoveItem(int userId, int cardId)
        {
            cartRepository.RemoveCartItem(userId, cardId);
        }

        public  void ClearCart(int userId)
        {
            cartRepository.ClearCart(userId);
        }

        public  decimal GetCartTotal(int userId)
        {
            var cart = cartRepository.GetCartByUser(userId);
            return cart.Sum(c => (decimal)(c.Card.CardPrice * c.Quantity));
        }
    }
}