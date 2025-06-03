using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LOrdCardShop.Core.Factories;
using LOrdCardShop.Model;
using LOrdCardShop.Infrastructure.Factories;

namespace LOrdCardShop.Infrastructure.Factories
{
    public class CartItemFactory : ICartItemFactory
    {
        public CartItem CreateCartItem(int userId, int cardId, int quantity)
        {
            return new CartItem
            {
                UserID = userId,
                CardID = cardId,
                Quantity = quantity
            };
        }
    }
}