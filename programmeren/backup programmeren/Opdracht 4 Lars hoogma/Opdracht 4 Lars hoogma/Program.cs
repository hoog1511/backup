using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4_Lars_hoogma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vul hoeveelheid graden in in celsius.");
            Double Celsius = Convert.ToInt16(Console.ReadLine());
            Double Fahrenheit = Celsius * 1.8 + 32;
            Console.WriteLine("Het is " + Celsius + " graden celsius");
            Console.WriteLine("Het is " + Fahrenheit + " graden Fahrenheit");

        }
    }
}
