using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LordCardShop.Factories
{
    public class CartFactory
    {
        public  static Cart CreateCart(int userId, int cardId, int quantity)
        {
            return new Cart
            {
                UserID = userId,
                CardID = cardId,
                Quantity = quantity,
            };
        }
    }
}