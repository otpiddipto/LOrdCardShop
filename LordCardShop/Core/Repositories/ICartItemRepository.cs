using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Core.Repositories
{
    public interface ICartItemRepository
    {
        List<CartItem> GetCartItemsByUserId(int userId);
        CartItem GetCartItem(int userId, int cardId);
        void AddCartItem(CartItem cartItem);
        void UpdateCartItem(CartItem cartItem);
        void DeleteCartItem(int cartItemId);
        void ClearCart(int userId);
    }
}