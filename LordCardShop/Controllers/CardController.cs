using LordCardShop.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace LordCardShop.Controllers
{
    public class CardController
    {
        CardHandler CardHandler = new CardHandler();
        public  string ValidateCard(string name, double price, string desc, string type, byte[] isFoil)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length < 5 || name.Length > 50 || !Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
                return "Card name must be 5-50 letters and spaces.";

            if (price < 10000)
                return "Price must be at least 10000.";

            if (string.IsNullOrWhiteSpace(desc))
                return "Description is required.";

            if (!(type == "Spell" || type == "Monster"))
                return "Type must be Spell or Monster.";

            if (!(isFoil.Length == 1 && (isFoil[0] == 0 || isFoil[0] == 1)))
                return "Foil must be yes (1) or no (0).";

            return "";
        }

        public  void AddCard(Card card)
        {
            CardHandler.addCard(card);
        }

        public void UpdateCard(Card card)
        {
            CardHandler.updateCard(card);
        }

        public  void DeleteCard(int id)
        {
            CardHandler.deleteCard(id);
        }

        public  List<Card> GetAllCards()
        {
            return CardHandler.GetAllCards();
        }

        public Card GetCard(int id)
        {
            return CardHandler.GetCardById(id);
        }

        public  List<Card> Search(string keyword)
        {
            return CardHandler.FilterCardsByName(keyword);
        }
    }

}