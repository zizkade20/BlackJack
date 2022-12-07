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
            while (Game)
            {
                Console.WriteLine("TOTO JE MENU:");
                Console.ReadLine();
            }
        }
    }
}
