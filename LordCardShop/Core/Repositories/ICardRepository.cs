using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Core.Repositories
{
    public interface ICardRepository
    {
        List<Card> GetAllCards();
        Card GetCardById(int id);
        void InsertCard(Card card);
        void UpdateCard(Card card);
        void DeleteCard(int id);
    }
}