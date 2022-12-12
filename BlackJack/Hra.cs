using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Hra
    {
        internal bool Game;

        internal Hra()
        {
            Game = true;
        }

        public void Loop()
        {
            Console.WriteLine("Zadejte přezdívku:");
            Console.Write("->");
            string username = Console.ReadLine();
            while (Game)
            {   
                Console.WriteLine("\nVítej " + username + "\n\n(P)LAY\n(Z)EBRICEK\n(P)RAVIDLA\n(O) HRE\n(E)XIT");
                Console.ReadLine();

                

            }
        }
    }
}
