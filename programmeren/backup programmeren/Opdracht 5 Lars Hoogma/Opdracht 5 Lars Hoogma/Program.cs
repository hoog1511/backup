using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_5_Lars_Hoogma
{
    class Program
    {
        static void Main(string[] args)
        {//Zowel de precisie alswel het bereik van een double is groter dan van een float. 
            float berekening1 =1;
            float berekening2= berekening1 / 225;
            Double berekening3 =1;
            Double berekening4 = berekening3 / 225;
            Console.WriteLine(berekening2);
            Console.WriteLine(berekening4);
        }
    }
}
