using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBestillingsSystem
{
    class Gaest
    {
        public List<Bestilling> Bestillinger { get; set; }
        private string navn;

        public string Navn
        {
            get { return navn; }
        }

        private int værelsesnummer;

        public int Værelsesnummer
        {
            get { return værelsesnummer; }
        }


        public Gaest(string navn, int rum)
        {
            this.navn = navn;
            værelsesnummer = rum;
            Bestillinger = new List<Bestilling>();
        }

        public double pris()
        {
            double samletpris = 0;
            foreach (Bestilling bestilling in Bestillinger)
            {
                samletpris = samletpris + bestilling.pris();
            }
            return samletpris;
        }

        public bool harBestilt(Vare vare)
        {
            bool retur = false;
            foreach(Bestilling bestilling in Bestillinger)
            {
                foreach(BestillingsLinje linje in bestilling.Bestillingslinjer)
                {
                    if (vare.Mærke == linje.Vare.Mærke)
                    {
                        retur = true;
                    }
                }
            }
            return retur;
        }

        public List<Bestilling> ikkeBetalteBestillinger()
        {
            List<Bestilling> ikkebetalte = new List<Bestilling>();
            foreach(Bestilling b in Bestillinger)
            {
                if (!b.Betalt)
                {
                    ikkebetalte.Add(b);
                }
            }
            return ikkebetalte;
        }
    }
}
