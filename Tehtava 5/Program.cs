using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tehtävä_5;

namespace Tehtava_5
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Opiskelija Jesse = new Opiskelija("Jesse", 20, "TTV16S3");
            Opiskelija Aliisa = new Opiskelija("Aliisa", 22, "TTV16S1");
            Opiskelija Tero = new Opiskelija("Tero", 19, "TTV16S2");
            Opiskelija Anna = new Opiskelija("Anna", 20, "TTV16S4");
            Opiskelija Pekka = new Opiskelija("Pekka", 20, "TTV16S4");

            List<Opiskelija> OpiskelijaLista = new List<Opiskelija>(); 
            OpiskelijaLista.Add(Jesse);
            OpiskelijaLista.Add(Aliisa);
            OpiskelijaLista.Add(Tero);
            OpiskelijaLista.Add(Anna);
            OpiskelijaLista.Add(Pekka);

            for (int i = 0; i < OpiskelijaLista.Count; i++) 
            {
                Console.WriteLine("Opiskelija " + (i + 1));
                Console.WriteLine("   Nimi: " + OpiskelijaLista[i].Nimi);
                Console.WriteLine("   Ikä: " + OpiskelijaLista[i].Ika);
                Console.WriteLine("   Luokka: " + OpiskelijaLista[i].Luokka);
                Console.WriteLine();
            }
        }
    }
}
