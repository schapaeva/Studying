using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();
            newDeck.PrintDeck();

            newDeck.TakeRandomCard().ToString();

            Console.ReadKey();
        }
    }
}
