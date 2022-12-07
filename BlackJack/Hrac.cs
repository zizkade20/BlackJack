using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Hrac
    {
        public string Jmeno;
        public int Penize;
        public int Sazka;

        internal Hrac() { }
        internal Hrac(string _jmeno, int _penize, int _sazka)
        {
            this.Jmeno = _jmeno;
            this.Penize = _penize;
            this.Sazka = _sazka;
        }

    }
}
