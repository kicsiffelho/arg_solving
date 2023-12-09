using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2zh
{
    internal class Program
    {
        static string ALegyen2(string vers)
        {
            foreach (char ch in vers)
            {
                if (ch == 'a' || ch == 'A')
                {
                    vers = vers.Replace(ch, '2');
                }
            }
            return vers;
        }

        static void Main(string[] args)
        {

            StreamReader reader = new StreamReader(@"C:/Users/user/Documents/msosy8/2zh/vers.txt");
            string vers = reader.ReadToEnd();
            string newVers = ALegyen2(vers);
            Console.Write(vers);
            
            StreamWriter writer = new StreamWriter(@"C:/Users/user/Documents/msosy8/2zh/vers_copy.txt");
            writer.Write(newVers);
            writer.Close();

            StreamReader readVers = new StreamReader(@"C:/Users/user/Documents/msosy8/2zh/vers_copy.txt");
            Console.Write(readVers.ReadToEnd());

            Console.ReadKey();
        }

    }
}
