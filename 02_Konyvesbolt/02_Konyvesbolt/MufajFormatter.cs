using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Konyvesbolt
{
    internal class MufajFormatter
    {
        public static string Format(Mufaj mufaj)
        {
            switch (mufaj)
            {
                case Mufaj.NemDefinialt:
                    return "Nem definiált";
                case Mufaj.SciFi:
                    return "Sci-fi";
                case Mufaj.Drama:
                    return "Dráma";
                case Mufaj.Romantikus:
                    return "Romantikus";
                case Mufaj.Tortenelmi:
                    return "Történelmi";
                case Mufaj.Fantasy:
                    return "Fantázia";
                case Mufaj.Horror:
                    return "Horror";
                default:
                    throw new Exception("Nem definiálit műfaj");
            }
        }
    }
}
