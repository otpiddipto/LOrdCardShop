using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Core.Factories
{
	public interface ICardFactory
	{
        Card CreateCard(string name, decimal price, string description, string type, string foil);
    }
}