using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Konyvesbolt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Konyvesbolt bolt = new Konyvesbolt();

            bolt.Konyvek.Add(new Konyv("E.J. Noyes", "Alone", 500, Mufaj.Drama));

            //foreach (Konyv konyv in bolt.Konyvek)
            //{
            //    if (konyv.Szerzo == "Ken Liu" && konyv.Cim == "Az istenekkel nem lehet végezni")
            //    {
            //        konyv.Ar = 1000;
            //    }
            //}

            //bolt.AddKonyv("Cixin Liu", "A sötét erdő", 4299, Mufaj.SciFi);

            foreach (Konyv konyv in bolt.Konyvek)
            {
                Console.WriteLine(konyv);
            }

            Console.ReadKey();
        }
    }
}
