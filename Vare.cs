using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBestillingsSystem
{
    class Vare
    {
        public string Navn {get;}
        public string Mærke { get; }

        public double Mængde { get; }

        public double Pris { get; }

        public Vare(string navn, string mærke, double mængde, double pris)
        {
            Navn = navn;
            Mærke = mærke;
            Mængde = mængde;
            Pris = pris;
        }


    }
}
