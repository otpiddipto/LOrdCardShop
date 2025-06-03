using LOrdCardShop.Core.Repositories;
using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Infrastructure.Repositories
{
    public class CartItemRepository : ICartItemRepository
    {
        private readonly LOrdCardShopDBEntities1 db = new LOrdCardShopDBEntities1();

        public List<CartItem> GetCartItemsByUserId(int userId)
        {
            return db.CartItems.Where(c => c.UserID == userId).ToList();
        }

        public CartItem GetCartItem(int userId, int cardId)
        {
            return db.CartItems.FirstOrDefault(c => c.UserID == userId && c.CardID == cardId);
        }

        public void AddCartItem(CartItem cartItem)
        {
            db.CartItems.Add(cartItem);
            db.SaveChanges();
        }

        public void UpdateCartItem(CartItem cartItem)
        {
            var existing = db.CartItems.FirstOrDefault(c => c.CartItemID == cartItem.CartItemID);
            if (existing != null)
            {
                existing.Quantity = cartItem.Quantity;
                db.SaveChanges();
            }
        }

        public void DeleteCartItem(int cartItemId)
        {
            var item = db.CartItems.FirstOrDefault(c => c.CartItemID == cartItemId);
            if (item != null)
            {
                db.CartItems.Remove(item);
                db.SaveChanges();
            }
        }

        public void ClearCart(int userId)
        {
            var items = db.CartItems.Where(c => c.UserID == userId);
            db.CartItems.RemoveRange(items);
            db.SaveChanges();
        }
    }
}