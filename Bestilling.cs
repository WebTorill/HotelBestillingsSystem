using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBestillingsSystem
{
    class Bestilling
    {
        private DateTime Dato { get; }
        public List<BestillingsLinje> Bestillingslinjer { get; set; }
        public bool Betalt { get; set; }

        public Gaest Gæst { get;  }



        public Bestilling(DateTime bestillingsdato, Gaest gaest)
        {
            Dato = bestillingsdato;
            Betalt = false;
            Gæst = gaest;
            Bestillingslinjer = new List<BestillingsLinje>();
            Gæst.Bestillinger.Add(this);
        }

        public void addVarer(int antal, Vare vare)
        {
            BestillingsLinje linje = new BestillingsLinje(antal, vare, this);
            Bestillingslinjer.Add(linje);
        }

        public double pris()
        {
            double samletpris = 0;
            foreach(BestillingsLinje linje in Bestillingslinjer)
            {
                samletpris = samletpris + linje.pris();
            }
            return samletpris;
        }
    }
}
