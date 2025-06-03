using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LordCardShop.Handlers
{
    public class CartRepository
    {
        LOrdCardShopDatabaseEntities db = new LOrdCardShopDatabaseEntities();

        public  Cart GetCartItem(int userId, int cardId)
        {
            
                return db.Carts.FirstOrDefault(c => c.UserID == userId && c.CardID == cardId);
            
        }

        public List<Cart> GetCartByUser(int userId)
        {
            
                return db.Carts.Where(c => c.UserID == userId).ToList();

        }

        public  void InsertCart(Cart cart)
        {
            
            
                db.Carts.Add(cart);
                db.SaveChanges();
            
        }

        public void UpdateCart(Cart cart)
        {
            
            
                var c = db.Carts.Find(cart.CartID);
                if (c != null)
                {
                    c.Quantity = cart.Quantity;
                    db.SaveChanges();
                
                }
        }

        public void RemoveCartItem(int userId, int cardId)
        {
            
            
                var cart = db.Carts.FirstOrDefault(c => c.UserID == userId && c.CardID == cardId);
                if (cart != null)
                {
                    db.Carts.Remove(cart);
                    db.SaveChanges();
                }
            
        }

        public void ClearCart(int userId)
        {
            
            
                var carts = db.Carts.Where(c => c.UserID == userId).ToList();
                db.Carts.RemoveRange(carts);
                db.SaveChanges();
            
        }


    }
}