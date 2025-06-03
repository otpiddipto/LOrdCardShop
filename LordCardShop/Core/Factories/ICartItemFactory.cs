using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Core.Factories
{
    public interface ICartItemFactory
    {
        CartItem CreateCartItem(int userId, int cardId, int quantity);
    }
}