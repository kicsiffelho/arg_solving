using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Diákok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diak ede = new Diak("Troll Ede", "1987.05.04");
            ede.Becenev = "A Troll";
            // ede.szulDatum = DateTime.Parse("1987.05.04");
            // ede.gender = Gender.Ferfi;
            // ede.SetAtlag(4.32);

            Diak gergely = new Diak("Kovásznai Gergely", "1977.05.10", Gender.Ferfi, 2.2);
            gergely.Becenev = "Kovi G";
            // gergely.Nev = "Kovács Ádám";
            // gergely.szulDatum = DateTime.Parse("1977.05.10");
            // gergely.gender = Gender.Ferfi;
            // gergely.SetAtlag(4.99);

            Diak virag = new Diak("Kiss Virág", "2001.05.20", Gender.No, 4.41);
            virag.Becenev = "sif";

            Console.WriteLine(ede);
            Console.WriteLine(gergely);
            Console.WriteLine(virag);

            Console.WriteLine($"Gergely átlaga: {gergely.GetAtlag()}");

            Console.ReadKey();
        }
    }
}
