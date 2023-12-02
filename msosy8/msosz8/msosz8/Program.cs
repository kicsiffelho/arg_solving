using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace msosz8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Milyen típusú a gépjármű (cég, magán): ");
            string gepjarmu = Console.ReadLine();
            int ar = 0;
            int benzin = 0;
            int tankolt = 0;

            while (benzin != 95 && benzin != 100)
            {
                Console.WriteLine("Milyen típusú benzint tankolt (95, 100): ");
                int.TryParse(Console.ReadLine(), out benzin);
                if (gepjarmu == "cég")
                {
                    if (benzin == 95)
                    {
                        ar = 800;
                    }
                    else ar = 830;
                }
                else
                {
                    if (benzin == 95)
                    {
                        ar = 593;
                    }
                    else ar = 830;
                }
                while (tankolt < 1 || tankolt > 50)
                {
                    Console.WriteLine("Mennyit tankolt (1-50): ");
                    int.TryParse(Console.ReadLine(), out tankolt);
                    ar *= tankolt;
                }
            }
            
            Console.WriteLine("Fizetendő összeg: {0}", ar);

            Console.WriteLine("Van pontgyűjő kártyája (van, nincs): ");
            string vanpont = Console.ReadLine();
            int pont;

            if (vanpont == "nincs")
            {
                Console.WriteLine("Viszlát");
            }
            else if (vanpont == "van")
            {
                if (benzin == 95)
                {
                    pont = tankolt;
                }
                else pont = tankolt * 5;
                Console.WriteLine("Felírt hűségpontok: {0}", pont);
            }*/

            
            
            Console.WriteLine("Üdvözli Önt a MixAPizza pizzéria!");
            string[] kategoria1 = { "sonka", "kukorica", "gomba" };
            string[] kategoria2 = { "kolbász", "ananász", "jalapenho" };
            string[] kategoria3 = { "kagyló", "articsóka", "oliva" };

            string feltet = "";
            int feltetszama = 0;
            string[] rendeles = new string[5];
            int ar1 = 200;
            int ar2 = 250;
            int ar3 = 300;
            int osszar = 1350;
            while (feltetszama != 5)
            {
                Console.WriteLine("Milyen feltétet szeretne a pizzára: ");
                feltet = Console.ReadLine();
                if (feltet == "-")
                {
                    break;
                }
                feltetszama++;
                if (feltetszama == 5)
                {
                    for (int i = 0; i < kategoria1.Length; i++)
                    {
                        if (kategoria1[i] == feltet)
                        {
                            osszar += ar1;
                        }
                    }
                    for (int i = 0; i < kategoria2.Length; i++)
                    {
                        if (kategoria2[i] == feltet)
                        {
                            osszar += ar2;
                        }
                    }
                    for (int i = 0; i < kategoria3.Length; i++)
                    {
                        if (kategoria3[i] == feltet)
                        {
                            osszar += ar3;
                        }
                    }
                    break;
                }

                rendeles[feltetszama] = feltet;
                for (int i = 0; i < kategoria1.Length; i++)
                {
                    if (kategoria1[i] == feltet)
                    {
                        osszar += ar1;
                    }
                }
                for (int i = 0; i < kategoria2.Length; i++)
                {
                    if (kategoria2[i] == feltet)
                    {
                        osszar += ar2;
                    }
                }
                for (int i = 0; i < kategoria3.Length; i++)
                {
                    if (kategoria3[i] == feltet)
                    {
                        osszar += ar3;
                    }
                }

            }
            
            Console.WriteLine("Feltétek száma: {0}", feltetszama);
            Console.WriteLine("Fizetendő összeg: {0}", osszar);

            Console.ReadKey();
        }
    }
}
