using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ♣♥♦
namespace BlackJack
{
     internal class Balicek
    {
        internal List<Karta> Deck;

        internal void VytvoritBalicek()
        {
            List<Karta> Deck = new List<Karta>();

            List<string> symboly = new List<string>()
            {
                "♥", "♦", "♣", "♠"
            };
            List<string> hodnoty = new List<string>()
            {
                "2", "3","4","5","6","7","8","9","10","J","Q","K","A",
            };
            foreach (string symbol in symboly)
            {
                foreach (string hodnota in hodnoty)
                {
                    Deck.Add(new Karta(hodnota, symbol));
                    
                }
            }

            /*
            foreach (var i in Deck)
            {
                Console.WriteLine(i.VratNazevKarty());
            }
            */
        }
        
        internal void VratKartu()
        {
            /*
            List<Karta> Deck = new List<Karta>();

            Deck.RemoveAt(0)
            */
        }
        
        
        internal void Shuffle()
        {

        }


    }
        

        

        

    
}
