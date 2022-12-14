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

        internal Balicek()
        {
            Deck = new List<Karta>()
            {
                
            };

        }

        
        internal void VytvoritBalicek()
        {
            List<Karta> Deck = new List<Karta>();

            List<string> symboly = new List<string>()
            {
                "SRDCE", "KARY", "PIKY", "LISTY"
            };
            List<int> hodnoty = new List<int>()
            {
                1,2,3, 4, 5, 6, 7,8,9,10,11,12,13
            };
            foreach (string i in symboly)
            {
                foreach (int j in hodnoty)
                {
                    Deck.Add(new Karta(hodnoty, symboly));
                }
            }

        }

        internal void VypisBalicek()
        {
            foreach(Karta karta in Deck)
            {
                Console.Write(karta + " ");
            }
        }

        /*
        internal Balicek() { }
        internal Balicek(List<Karta> _deck)
        {
            this.Deck = _deck;
                
        }
        */
        internal void Shuffle()
        {

        }


    }
        

        

        

    
}
