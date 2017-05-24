using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_week_5_opdracht_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ontwerp een consoletoepassing waarmee je de namen van de leerlingen van je klas opvraagt. 
             * Bewaar de namen in een array. 
             * Je vraagt de gebruiker eerst hoeveel waarden hij wil ingeven en je voorziet dan voldoende ruimte in de array. 
             * Toon de namen in de console.*/
            Console.WriteLine("Hoeveel namen wilt u invullen?");
            int aantal = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Typ de naam uit, elk op een apparte regel:");
            string[] namen = new string[aantal];
            // vul namen in
            for (int i = 0; i < aantal; i++)
            { namen[i] = Console.ReadLine(); }

            // print namen uit
            Console.WriteLine("De namen zijn.");
            // sorteer namen op alfabetische volgorde
            Array.Sort(namen);
            for (int i =0; i < aantal; i++)
            { Console.Write((namen[i])+ " "); }
            Console.ReadLine();
        }
    }
}
