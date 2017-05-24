using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_week_5_opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Opgave1:
    Ontwerp een consoletoepassing waarmee je aan de gebruiker 3 getallen opvraagt. 
    De getallen bewaar je in een array. 
    Na invoer de getallen bereken de som van deze getallen en geef de uitkomst weer in de console.
*/
            int[] numbers = new int[3];
            Console.WriteLine("Vul 3 getallen in om de som te berekenen");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt16(Console.ReadLine());
            }
            // blijf getallen optellen tot de array bij de max waarde is.
            int sum = 0;
            for (int i =0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Het antwoord is:" + sum);
            Console.ReadLine();
        }
    }
}
