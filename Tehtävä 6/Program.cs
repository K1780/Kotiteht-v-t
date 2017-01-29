using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tehtava_6;

namespace Tehtävä_6
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Xbox Xbox = new Xbox("Xbox", 2001, 24);
            Xbox Xbox360 = new Xbox("Xbox360", 2005, 77.2);
           Xbox Xboxone = new Xbox("Xbox one", 2013, 3.0);
            

            List<Xbox> Xboxlista = new List<Xbox>();
            Xboxlista.Add(Xbox);
            Xboxlista.Add(Xbox360);
            Xboxlista.Add(Xboxone);
           

            for (int i = 0; i < Xboxlista.Count; i++)
            {
                Console.WriteLine("Konsoli " + (i + 1));
                Console.WriteLine("    Konsolin nimi: " + Xboxlista[i].Nimi);
                Console.WriteLine("    Julkaisuvuosi : " + Xboxlista[i].Julkaisuvuosi);
                Console.WriteLine("    Myytyjä konsoleita " + Xboxlista[i].MyytyMaara + " miljoonaa kpl");
                Console.WriteLine();
            }
        }
    }
}
