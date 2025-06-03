using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LordCardShop.Handlers
{
    public class CardHandler
    {
        CardRepository cardRepository = new CardRepository();

        public List<Card> GetAllCards()
        {
            return cardRepository.GetAllCards();
        }

        public Card GetCardById(int id)
        {
            return cardRepository.GetCardById(id);
        }

        public void addCard(Card card)
        {
            cardRepository.AddCard(card);
        }

        public void updateCard(Card updatedCard)
        {
            cardRepository.UpdateCard(updatedCard);
        }

        public void deleteCard(int id)
        {
            cardRepository.DeleteCard(id);
        }

        public List<Card> FilterCardsByName(string keyword)
        {
            return cardRepository.FilterCardsByName(keyword);
        }
    }
}