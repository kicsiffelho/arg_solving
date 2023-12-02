using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _20231202_1155
{
    internal class Program
    {
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static void Hello()
        {
            Console.WriteLine("Hello world");
        }

        static void Greet(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        static void NameAndAge(string name, int age)
        {
            Console.WriteLine(name + " " + age + " éves");
        }
        static void Country(string country = "Hungary")
        {
            Console.WriteLine(country);
        }

        static bool Prime(int n)
        {
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        static int Fact(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return(n*Fact(n-1));

        }
        static void Main(string[] args)
        {
            /*
            int x = 3;
            int y = 8;
            Console.WriteLine(Sum(x,y));*/
            Hello();
            Greet("Béla"); ;
            NameAndAge("Béla", 12);
            Country("Germany");
            Country();
            Console.WriteLine("Adjon meg egy számot: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Prime(num));
            Console.WriteLine(Fact(5));

            Console.ReadKey();
        }
    }
}
