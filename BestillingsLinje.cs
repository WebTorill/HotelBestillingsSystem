using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBestillingsSystem
{
    class BestillingsLinje
    {
        private int antal;

        private Bestilling bestilling;

        public Vare Vare { get; set; }

        public int Antal
        {
            get { return antal; }
        }

        public BestillingsLinje(int antal, Vare vare, Bestilling bestilling)
        {
            this.antal = antal;
            this.Vare = vare;
            this.bestilling = bestilling;
        }

        public double pris()
        {
            return Vare.Pris * antal;

        }
    }
}
