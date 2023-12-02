using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace fajlkezeles
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string file = @"C:/Users/Student/Documents/msosy8/levelezo/asd.txt";
            string file2 = @"C:/Users/Student/Documents/msosy8/levelezo/asd2.txt";
            string file3 = @"C:/Users/Student/Documents/msosy8/levelezo/asd3.txt";

            /*
            int a, b, result;
            a = 5;
            b = 6;
            result = a + b;

            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Write("{0} és {1} összege az {2}", a, b, result);
            }
            Console.WriteLine("Saved");

            using (TextReader textreader = File.OpenText(file2))
            {
                Console.WriteLine(textreader.ReadLine());
            }

            using (TextReader tr4 = File.OpenText(file2))
            {
                char[] ch = new char[4];
                tr4.ReadBlock(ch, 0, 4);
                Console.WriteLine(ch);
            }

            using (TextReader trFull = File.OpenText(file2))
            {
                Console.WriteLine(trFull.ReadToEnd());
            }*/
            /*
            if (File.Exists(file2))
            {
                File.Delete(file2);
            }

            using (StreamWriter writer = new StreamWriter(file2))
            {
                writer.WriteLine("jegesmedve");
                writer.WriteLine("jegesmedve2");
                writer.WriteLine("jegesmedve3");
            }

            using (StreamReader reader = File.OpenText(file2))
            {
                string s = "";
                Console.WriteLine("A dokuemtnum tartalma: ");
                while((s = reader.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }*/

            if (File.Exists(file3))
            {
                File.Delete(file3);
            }

            string[] arrLines;
            string str;
            Console.Write("Mi legyen a tiltott szó: ");
            str = Console.ReadLine();
            Console.Write("Hány sort akar tárolni: ");
            int n = int.Parse(Console.ReadLine());
            arrLines = new string[n];

            Console.WriteLine("Írja be az {0}db sort: ", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}-ik sor: ", i);
                arrLines[i] = Console.ReadLine();
            }

            using (StreamWriter writer = new StreamWriter(file3))
            {
                foreach (string line in arrLines)
                {
                    if (!line.Contains(str))
                    {
                        writer.WriteLine(line);
                    }
                }
            }

            using (StreamReader reader = File.OpenText(file3))
            {
                string s = "";
                Console.WriteLine("Azok a sorok amelyek nem tartalmazzák a '{0}' szót", str);
                
                while ((s = reader.ReadLine()) != null)
                {
                    Console.WriteLine("{0} ", s);
                }
            }


            Console.ReadKey();
        }
    }
}
