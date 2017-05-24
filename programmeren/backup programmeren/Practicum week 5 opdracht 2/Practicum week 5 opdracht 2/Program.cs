using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_week_5_opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*     Ontwerp een consoletoepassing waarmee je aan de gebruiker 9 getallen opvraagt. 
             *     Bewaar de getallen in een array. 
             *     Vervolgens vraag je aan de gebruiker het hoeveelste getal hij wil zien. 
             *     Het resultaat geef je weer in de console.*/
            int[] numbers = new int[9];
            Console.WriteLine("Vul 9 getallen in");
            for (int i = 0; i<9; i++)
            { numbers[i] = Convert.ToInt16(Console.ReadLine()); }

            Console.WriteLine("Vul het hoeveelste getal dat jij uit de array wil halen.");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" getal "+ number + " = " + numbers[number -1]);
            Console.ReadLine();
        }
    }
}
