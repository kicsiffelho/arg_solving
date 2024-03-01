using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Orkok
{
    internal class Harcos : Ork
    {
        public Harcos(Fegyver fegyver) : this(null, fegyver)
        {
        }

        public Harcos(string nev, Fegyver fegyver) : base(nev)
        {
            this.Eletero = 80;
            this.Sebzes = 30;
            this.Fegyver = fegyver;
            this.Pajzs = 10;
        }

        public Fegyver Fegyver { get; set; }
        
        public int Pajzs { get; set; }

        public new void Sebesul(int sebzes)
        {

        }

        public override string ToString()
        {
            string szoveg = base.ToString().Replace('}',' ');
            szoveg += "pajzs: " + Pajzs + ", ";
            szoveg += Fegyver;
            return szoveg;
        }
    }
}
