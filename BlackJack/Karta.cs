using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlackJack
{
    internal class Karta
    {
        internal List<int> Hodnota;
        internal List<string> Barva;

        
        internal Karta(List<int> _hodnota, List<string> _barva)
        {
            this.Hodnota = _hodnota;
            this.Barva = _barva;
        }

        internal void NaplnitBalicek() 
        {
            

        }



    }
}

