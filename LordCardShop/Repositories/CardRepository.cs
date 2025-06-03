using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LordCardShop.Handlers
{
    public class CardRepository
    {
        LOrdCardShopDatabaseEntities db = new LOrdCardShopDatabaseEntities();
        public List<Card> GetAllCards()
        {
            return db.Cards.ToList();
        }
        public Card GetCardById(int id)
        {
            return db.Cards.FirstOrDefault(c => c.CardID == id);
        }
        public void AddCard(Card card)
        {
            db.Cards.Add(card);
            db.SaveChanges();
        }
        public void UpdateCard(Card updatedCard)
        {
            Card card = db.Cards.Find(updatedCard.CardID);

            if(card != null)
            {
                card.CardName = updatedCard.CardName;
                card.CardDesc = updatedCard.CardDesc;
                card.CardPrice = updatedCard.CardPrice;
                card.isFoil = updatedCard.isFoil;
                card.CardType = updatedCard.CardType;
                
                db.SaveChanges();
            }
        }
        public void DeleteCard(int id)
        {
            var card = db.Cards.Find(id);
            if (card != null)
            {
                db.Cards.Remove(card);
                db.SaveChanges();
            }
        }

        public List<Card> FilterCardsByName(string keyword)
        {
            return db.Cards.Where(c => c.CardName.Contains(keyword)).ToList();
        }
    }
}