using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Orkok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Horda horda = new Horda();

            Ork ork1 = new Ork();
            Ork ork2 = new Ork("Gul'dan");            
            horda.AddOrk(ork1);
            horda.AddOrk(ork2);
            horda.AddOrk(new Ork());
            horda.AddOrk(new Ork("Dograh"));

            foreach (Ork ork in horda.Orkok)
            {
                Console.WriteLine(ork);
            }

            Harcos harcos1 = new Harcos(new Fegyver("balta",15));
            Harcos harcos2 = new Harcos("Deborah", new Fegyver("fejsze", 21));
            Console.WriteLine(harcos1);
            //Console.WriteLine(harcos2);

            Console.ReadLine();
        }
    }
}
