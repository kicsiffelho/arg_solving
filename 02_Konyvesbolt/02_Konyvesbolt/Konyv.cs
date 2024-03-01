﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _02_Konyvesbolt
{
    internal class Konyv
    {
        private static int ID = 1;
        public Konyv(string szerzo, string cim, int ar) : this(szerzo, cim, ar, Mufaj.NemDefinialt)
        {
        }
        public Konyv(string szerzo, string cim, int ar, Mufaj mufaj)
        {
            this.Id = Konyv.ID++;
            this.Szerzo = szerzo;
            this.Cim = cim;
            this.Ar = ar;
            this.Mufaj = mufaj;
        }

        public int Id { get; set; }
        public string Szerzo { get; set; }
        public string Cim { get; set; }
        public int Ar { get; set; }
        public Mufaj Mufaj { get; set; }

        public override string ToString()
        {
            return $"{Szerzo} - {Cim} ({MufajFormatter.Format(Mufaj)}), {Ar} Ft";
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (this == obj) return true;
            if (!(obj is Konyv)) return false;

            Konyv masik = obj as Konyv;
            return this.Szerzo == masik.Szerzo && this.Cim == masik.Cim;
        }
    }
}
