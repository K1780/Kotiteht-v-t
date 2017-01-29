using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava_6
{
   
    
        public class Xbox
        {
            public string Nimi { get; set; }
            public int Julkaisuvuosi { get; set; }
            public double MyytyMaara { get; set; }

            public Xbox(string nimi, int julkaisuvuosi, double myytymaara)
            {
                Nimi = nimi;
                Julkaisuvuosi = julkaisuvuosi;
                MyytyMaara = myytymaara;
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

