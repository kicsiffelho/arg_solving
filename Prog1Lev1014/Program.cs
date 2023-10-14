using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Prog1Lev1014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int szam1 = 3;
            int szam2 = 6;

            int osszeg = szam1 + szam2;
            Console.WriteLine("Két szám összege: " + osszeg);
            Console.WriteLine("A {0} és a {1} összege: {2}", szam1, szam2, osszeg);
            Console.WriteLine("Két szám összege: {0}", szam1 + szam2);

            double szam3 = 3.14;
            float szam4 = 4.2345f;
            */
            /*
            int h = 5;
            int l = 0;
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j < h ; j++)
                {
                    Console.Write(".");
                }
                for (int k = 0; k <= l; k++)
                {
                    Console.Write("/");
                }
                Console.Write(" ");
                for (int k2 = 0; k2 <= l; k2++)
                {
                    Console.Write("\\");
                }
                for (int j2 = 0; j2 < h; j2++)
                {
                    Console.Write(".");
                }
                h--;
                l++;
                Console.WriteLine();
            }
            h = 0;
            l = 5;
            for (int i = 0; i <= 5; i++)
            {
                for (int j2 = 0; j2 < h; j2++)
                {
                    Console.Write(".");
                }
                for (int k2 = 0; k2 <= l; k2++)
                {
                    Console.Write("\\");
                }
                Console.Write(" ");
                for (int k = 0; k <= l; k++)
                {
                    Console.Write("/");
                }
                for (int j = 0; j < h; j++)
                {
                    Console.Write(".");
                }
                h++;
                l--;
                Console.WriteLine();
            }*/
            /*
            Console.WriteLine("Adja meg a hónap sorszámát: ");
            int honap = int.Parse(Console.ReadLine());
            string[] honapok = { "Januar", "Februar", "Marcius", "Aprilis", "Majus", "Junius", "Julius", "Augusztus", "Szeptember", "Oktober", "November", "December"};
            switch (honap)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12: Console.WriteLine("Hónap neve: {0}", honapok[honap - 1]); break;
                default: Console.WriteLine("Nincs ilyen hónap"); break;
            }
            */
            /*
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars.Length);

            int[] szamok = { 3, 7, 2, 4, 6, 7, 3, 5, 6, 7, 8, 5 };
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine("{0}. indexen a {1} szám szerepel.", i, szamok[i]);
            }
            Console.WriteLine("A régi 0. elem: " + szamok[0]);
            szamok[0] = 112;
            Console.WriteLine("Az új 0. elem: " + szamok[0]);

            int sum = 0;
            for (int j = 0; j < szamok.Length; j++)
            {
                sum += szamok[j];
            }
            int atlag = sum / szamok.Length;
            Console.WriteLine("Átlag: " + atlag);
            *//*
            Console.Write("Adja meg az osztály létszámát: ");
            int letszam = int.Parse(Console.ReadLine());
            int[] jegyek = new int[letszam];
            int osszeg = 0;
            for (int i = 0; i < letszam; i++)
            {

                Console.Write("{0} hallgató jegye: ", i+1);
                jegyek[i] = int.Parse(Console.ReadLine());
                osszeg += jegyek[i];
            }
            double atlag = (double)osszeg / letszam;
            Console.WriteLine("Jegyek átlaga {0:0.00}", atlag);

            int jobbakAzAtlagnal = 0;
            for (int j = 0; j < jegyek.Length; j++)
            {
                if (jegyek[j] > atlag)
                {
                    jobbakAzAtlagnal++;
                }
            }
            Console.WriteLine("Jobbak az átlagnál: {0}", jobbakAzAtlagnal);
            */
            /*
            int[,] arr2d;
            int[,,] arr3d;
            int[,,,] arr4d;
            int[,,,,] arr5d;
            */
            /*
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            Console.WriteLine(numbers[0,0]);
            Console.WriteLine(numbers[0,2]);
            numbers[0, 0] = 5;
            Console.WriteLine(numbers[0,0]);

            int[,] arr2d = new int[3, 2] {
                {1, 2},
                {3, 4},
                {5, 6}};

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i,j]);
                }
            }
            */
            /*
            int k, l;
            int[,] matrix = new int[2, 2];
            Console.WriteLine("Töltsd fel a mátrixot elemekkel!"); ;
            for (k = 0; k < matrix.GetLength(0); k++)
            {
                for (l = 0; l < matrix.GetLength(1); l++)
                {
                    Console.Write("Írd be a [{0}, {1}] elemet: ", k, l);
                    matrix[k, l] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (k = 0; k < matrix.GetLength(0); k++)
            {
                Console.Write("\n");
                for (l = 0; l < matrix.GetLength(1); l++)
                {
                    Console.Write("{0}\t", matrix[k, l]);
                }
            }
            Console.WriteLine();
            */
            Console.Write("Hány elemet tároljunk? ");
            int n = int.Parse(Console.ReadLine());
            int[] tomb1 = new int[n];
            for (int h = 0; h < n; h++)
            {
                Console.Write("Adja meg az {0}. elemeket: ", h+1);
                tomb1[h] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("tömb1: ");
            for (int i = 0; i < tomb1.Length; i++)
            {
                Console.WriteLine(tomb1[i]);
            }
            int[] tomb2 = tomb1;
            Console.WriteLine("tömb2:");
            for (int j = 0; j < tomb2.Length; j++)
            {
                Console.WriteLine(tomb2[j]);
            }
 

            Console.ReadKey();
        }
    }
}