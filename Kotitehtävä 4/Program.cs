using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtävä_4
{
   public class Vehicle
    {
       public string Name { get; set; }
       public int Speed { get; set; }
       public  int Tyres { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Auton nimi :" + Name);
            Console.WriteLine("Auton nopeus :" + Speed);
            Console.WriteLine("Autossa renkaita :" + Tyres);
        }
        public string PalautaKaikki()
        {
            string PalautaKaikki;
            PalautaKaikki = Name + " " + Speed + " " + Tyres;
            return PalautaKaikki;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string PalautaKaikki;
            Vehicle Auto = new Vehicle();
            Auto.Name = "Toyota";
            Auto.Speed = 220;
            Auto.Tyres = 4;
            Auto.PrintData();

            PalautaKaikki = Auto.ToString();
            Console.WriteLine(PalautaKaikki);
            Console.ReadLine();
      
        }
       
    
        
        
    }
}
