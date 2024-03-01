using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Diákok
{
    internal class Diak
    {
        private static Random rnd = new Random();
        private static List<string> generaltNeptunkodok = new List<string>();
        private static int ID = 1;
        public Diak(string nev, string szulDatum) :this(nev, szulDatum, Gender.Egyeb, 1.0)
        {
            // this.neptunkod = neptunkod;
            // this.Nev = nev;
            // this.szulDatum = DateTime.Parse(szulDatum);
            // this.SetAtlag(1.0);

        }

        public Diak(string nev, string szulDatum, Gender gender, double atlag)
        {
            this.id = ID; ID++;
            this.neptunkod = GetEgyediNeptunkod();
            generaltNeptunkodok.Add(neptunkod);
            this.Nev = nev;
            this.szulDatum = DateTime.Parse(szulDatum);
            this.gender = gender;
            this.SetAtlag(atlag);

        }

        private int id;
        public string neptunkod; // Max 6 karakter, nem tartalmazhat speciális karaktert, nem kezdődhet számmal,
                                  // akárhogyan adták meg, mindig csupa nagybetővel kell elmenteni
        private string nev; // Legalább egy space, minden rész szöveg legalább 2 karakter hosszú
        public DateTime szulDatum; // 18 évnél fiatalabb hallgatót nem regisztrálhatunk,
                                   // az életkort maximalizáljuk 140 évben
        private Gender gender;
        private double atlag;
        private string becenev;
        
        // Egyszerű property
        public Gender Gender { set; get; }

        // A propertyk lehetőséget biztosítanak az osztály mezőinek elérésére és módosítására anélkül, hogy közvetlenül hozzáférnénk azokhoz.
        private bool becenevMegadva = false;
        public string Becenev
        {
            set
            {
                if (becenevMegadva)
                {
                    throw new Exception("A becenevet csak egyszer lehet megadni");
                }
                becenev = value;
                becenevMegadva = true;
            }
            get
            {
                return becenev;
            }
        }

        private int nevMegadva = 0;
        public string Nev // string value
        {
            set // private set
            {
                if (nevMegadva >= 5)
                    throw new Exception("Csak 5-ször lehet megadni a nevet");
                if (!value.Contains(' '))
                {
                    throw new Exception("A névnek legalább egy szóközt tartalmaznia kell");
                }
                string[] darabok = value.Split(' ');
                foreach (string darab in darabok)
                {
                    if (darab.Length < 2)
                    {
                        throw new Exception($"A név egyes része nem lehet 2 karakternél rövidebb. Input: {value}");
                    }
                }
                nev = value;
                nevMegadva++;
            }

            get
            {
                return nev;
            }
        }

        // Property metódus
        public void SetAtlag(double value)
        {
            if (value < 1.0)
            {
                // Console.WriteLine("Hiba: Az átlag nem lehet 1-nél kisebb");
                // Console.Beep(3000, 2000);
                throw new Exception($"Az átlag nem lehet kisebb, mint 1! A diák neve: {nev} kapott érték: {value}");
            }
            if (value > 5.0)
            {
                throw new Exception($"Az átlag nem lehet nagyobb, mint 5! A diák neve: {nev} kapott érték: {value}");
            }
            atlag = value;
        }

        public double GetAtlag()
        {
            return atlag;
        }

        private static string GetEgyediNeptunkod()
        {
            string nk;
            do
            {
                nk = GetNeptunkod();
            } while (generaltNeptunkodok.Contains(nk));
            return nk;
        }

        // Osztályszintű metódus
        public static string GetNeptunkod()
        {
            string abc = "QWERTZUIOPASDFGHJKLYXCVBNM";
            string nk = string.Empty; // neptunkod
            for (int i = 0; i < 6; i++)
            {
                nk += abc[rnd.Next(abc.Length)];
            }
            return nk;
        }


        // Példányszintű metódus
        public void Kiir()
        {
            Console.WriteLine($"Név: {nev}");
            Console.WriteLine($"Neptunkód: {neptunkod}");
            Console.WriteLine($"Születési dátum: {szulDatum.ToString("yyyy.MM.dd")}");
            Console.WriteLine($"Neme: {gender}");
            Console.WriteLine($"Átlag: {atlag}");
            Console.WriteLine();
        }

        public override string ToString()
        {
            string szoveg = string.Empty;
            szoveg += $"Név: {nev}\n";
            szoveg += $"Neptunkód: {neptunkod}\n";
            szoveg += $"Születési dátum: {szulDatum.ToString("yyyy.MM.dd")}\n";
            szoveg += $"Neme: {gender}\n";
            szoveg += $"Átlag: {atlag}\n";
            szoveg += $"Becenév: {becenev}\n";
            szoveg += $"ID: {id}\n";
            return szoveg;
        }
    }
}
