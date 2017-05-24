using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_6_Lars_hoogma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vul hoeveelheid Euro in.");
            Double Euro = Convert.ToInt16(Console.ReadLine());
            Double Dollar = Euro *1.2231;
            Console.WriteLine("Het is " + Euro + " Euro");
            Console.WriteLine("Het is " + Dollar + " Dollar");
            Console.ReadLine();
        }
    }
}
