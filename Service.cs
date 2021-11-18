using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBestillingsSystem
{
    class Service
    {
        public static List<Gaest> Gæster { get; set; }
        static void Main(string[] args)
        {
            Gæster = new List<Gaest>();
            createSomeObjects();
            
            foreach(Gaest g in Gæster)
            {
                Console.WriteLine(g.Navn);
            }
            Console.WriteLine("Nu kan du oprette en ny gæst. Indtast først gæstens navn:");
            string navn = Console.ReadLine();
            Console.WriteLine("Indtast nu værelsesnummer som gæsten skal bo på:");
            int rum = Int32.Parse(Console.ReadLine());
            Gaest gaest = new Gaest(navn, rum);
            Gæster.Add(gaest);
            foreach(Gaest g in Gæster)
            {
                List<Bestilling> bestillinger = g.ikkeBetalteBestillinger();
                
                foreach(Bestilling b in bestillinger)
                {
                    Console.WriteLine(g.Navn + " har bestillinger som ikke er betalte: " + b.pris());
                }
            }
        }
        public static void createSomeObjects() {
            Vare coca = new Vare("Cola", "Coca Cola", 0.5, 28);
            Vare pepsi = new Vare("Cola", "Pepsi", 0.5, 26);
            Vare tuborg = new Vare("Øl", "Tuborg", 0.33, 33);
            Vare carlsberg = new Vare("Øl", "Carlsberg", 0.57, 48);

            Gaest ib = new Gaest("Ib", 17);
            Gaest eva = new Gaest("Eva", 12);
            Gaest lene = new Gaest("Lene", 8);
            Gæster.Add(ib);
            Gæster.Add(eva);
            Gæster.Add(lene);

            Bestilling b1 = new Bestilling(new DateTime(2021, 6, 15), ib);
            b1.addVarer(3, tuborg);
            b1.addVarer(2, coca);
            b1.addVarer(2, pepsi);

            Bestilling b2 = new Bestilling(new DateTime(2021, 6, 16), ib);
            b2.addVarer(2, tuborg);
            b2.addVarer(3, pepsi);
            b2.addVarer(4, carlsberg);
        
        }
    }
}
