using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LOrdCardShop.Core.Factories;
using LOrdCardShop.Model;

namespace LOrdCardShop.Infrastructure.Factories
{
    public class CardFactory : ICardFactory
    {
        public Card CreateCard(string name, decimal price, string description, string type, string foil)
        {
            return new Card
            {
                Name = name,
                Price = price,
                Description = description,
                Type = type,
                Foil = foil
            };
        }
    }
}