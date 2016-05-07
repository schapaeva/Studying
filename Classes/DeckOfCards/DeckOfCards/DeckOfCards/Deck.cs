using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Deck
    {
        private Card[] deck;
        private const int NumberOfCards = 52;
        
        public Deck()
        {
            this.deck = new Card[NumberOfCards];
            int currentCard = 0;            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 2; j < 15; j++)
                {
                    this.deck[currentCard] = new Card(j, i);
                    currentCard++;
                }
            }
        }

        public Card TakeRandomCard()
        {
            Random rand = new Random();
            int index = rand.Next(0, 51);
            while(!this.deck[index].IsAvailable)
                index = rand.Next(0, 51);
            return this.deck[index];
        }

        public void PrintDeck()
        {
            foreach(Card card in this.deck)
                Console.WriteLine(card.ToString());
        }        

    }
}
