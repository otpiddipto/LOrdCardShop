using LOrdCardShop.Core.Repositories;
using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Infrastructure.Repositories
{
    public class CardRepository : ICardRepository
    {
        private readonly LOrdCardShopDBEntities1 db = new LOrdCardShopDBEntities1();

        public List<Card> GetAllCards()
        {
            return db.Cards.ToList();
        }

        public Card GetCardById(int id)
        {
            return db.Cards.FirstOrDefault(c => c.CardID == id);
        }

        public void InsertCard(Card card)
        {
            db.Cards.Add(card);
            db.SaveChanges();
        }

        public void UpdateCard(Card card)
        {
            var existing = db.Cards.FirstOrDefault(c => c.CardID == card.CardID);
            if (existing != null)
            {
                existing.Name = card.Name;
                existing.Price = card.Price;
                existing.Description = card.Description;
                existing.Type = card.Type;
                existing.Foil = card.Foil;
                db.SaveChanges();
            }
        }

        public void DeleteCard(int id)
        {
            var card = db.Cards.FirstOrDefault(c => c.CardID == id);
            if (card != null)
            {
                db.Cards.Remove(card);
                db.SaveChanges();
            }
        }
    }
}