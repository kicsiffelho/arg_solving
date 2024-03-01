using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02_Konyvesbolt
{
    internal class Konyvesbolt
    {

        // ctor + Tab konstruktort generál
        public Konyvesbolt()
        {
            this.konyvek = new List<Konyv>();
            this.AddKonyv("Cixin Liu", "A háromtest probléma", 3499, Mufaj.SciFi);
            this.AddKonyv("Cixin Liu", "A sötét erdő", 4299, Mufaj.SciFi);
            this.AddKonyv("Cixin Liu", "A halál vége", 4299);
            this.AddKonyv("Arkagyij és Borisz Sztrugackij", "Egymilliárd évvel a világvége előtt", 2600, Mufaj.Drama);
            this.AddKonyv("Arkagyij és Borisz Sztrugackij", "STALKER", 2600);
            this.AddKonyv("Ken Liu", "Papírsárkányok", 3700);
            this.AddKonyv("Ken Liu", "Az istenekkel nem lehet végezni", 3550);
            this.AddKonyv("Dan Simmons", "Hyperion", 3700);
            this.AddKonyv("Dan Simmons", "Hyperion bukása", 3900);
            this.AddKonyv("Brandon Hackett", "Isten gépei", 3480);
        }
        private List<Konyv> konyvek;

        public List<Konyv> Konyvek
        {
            // Gyűjtermények védelme
            get
            {
                List<Konyv> temp = new List<Konyv>();
                foreach (Konyv konyv in this.konyvek)
                {
                    Konyv klon = new Konyv(konyv.Szerzo, konyv.Cim, konyv.Ar, konyv.Mufaj);
                    temp.Add(klon);
                }
                return temp;
                // return new List<Konyv>(this.konyvek);
            }
        }

        public void AddKonyv(string szerzo, string cim, int ar)
        {
            Konyv ujKonyv = new Konyv(szerzo, cim, ar);
            if (konyvek.Contains(ujKonyv))
                throw new Exception("Könyv már benne van az adatbázisban");
            this.konyvek.Add(ujKonyv);
        }
        public void AddKonyv(string szerzo, string cim, int ar, Mufaj mufaj)
        {
            Konyv ujKonyv = new Konyv(szerzo, cim, ar, mufaj);
            //foreach (Konyv konyv in this.konyvek)
            //{
            //    if (konyv.Szerzo == ujKonyv.Szerzo && konyv.Cim == ujKonyv.Cim)
            //    {
            //        throw new Exception($"Könyv már létezik: {konyv.Szerzo}, {konyv.Cim}");
            //    }
            //}
            if (konyvek.Contains(ujKonyv))
                throw new Exception("Könyv már benne van az adatbázisban");
            this.konyvek.Add(ujKonyv);
        }
        public void AddKonyv(Konyv konyv)
        {
            if (konyvek.Contains(konyv))
                throw new Exception("Könyv már benne van az adatbázisban");
            Konyv ujKonyv = new Konyv(konyv.Szerzo, konyv.Cim, konyv.Ar, konyv.Mufaj);
            this.konyvek.Add(ujKonyv);
        }
    }
}
