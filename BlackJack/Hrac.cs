using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Hrac
    {
        public string Jmeno { get; set; }
        //public List<Karta> Ruka { get; set; }
        public int Skore { get; set; }
        public int Penize;

        internal Hrac() { }
        internal Hrac(string _jmeno, int _skore, int _penize, int _sazka)
        {
            this.Jmeno = _jmeno;
            this.Skore = _skore;
            this.Penize = _penize;
        }

        internal void SetName()
        {
            Console.WriteLine("Zadejte přezdívku:");
            Console.Write("->");
            string username = Console.ReadLine();
            Console.WriteLine("\nVítej " + username);
        }
        /*internal void DisplayName()
        {
            Console.WriteLine(username);
        }
        */
    }

}
