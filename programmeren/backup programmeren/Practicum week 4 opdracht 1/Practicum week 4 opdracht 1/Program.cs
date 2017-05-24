using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_week_4_opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print het grootste getal van 5 ingevulde getallen.
            int grootste = 0;
            for (int a = 0; a < 5; a++ )
            {
                int getal = Convert.ToInt16(Console.ReadLine());
                if (getal > grootste)
                { grootste = getal; }
            }
            Console.WriteLine(grootste + " is het grootste getal.");
            Console.ReadLine();
        }
    }
}
