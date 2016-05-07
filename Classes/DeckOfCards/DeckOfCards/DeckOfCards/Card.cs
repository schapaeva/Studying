using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Card
    {
        private Face face;
        private Suit suit;
        private bool available;

        public Card(Face face, Suit suit)
        {
            this.face = face;
            this.suit = suit;
        }

        public Card(int face, int suit)
        {
            this.face = (Face)face;
            this.suit = (Suit)suit;
        }

        public Suit Suit
        {
            get { return this.suit; }
        }

        public bool IsAvailable
        {
            get { return this.available; }
        }

        public void MarkAvailable()
        {
            this.available = true;
        }

        public void MarkUnavailable()
        {
            this.available = false;
        }

        public override string ToString()
        {
            return face + " of " + suit.ToString();
        }
        
    }
}
