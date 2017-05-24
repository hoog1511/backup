using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_week_5_opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ontwerp een consoletoepassing waarmee je aan de gebruiker 10 getallen opvraagt. 
             * Je toont als resultaat in de console enkel de even opgevraagde getallen.*/
            //declareren van de variabellen
            int counter;
            int[] numbers = new int[10];
            int number = numbers[0];
            
            // opvragen van getallen tot dat er 10 getallen zijn
            Console.WriteLine("Vul 10 getallen in");
            for (counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(" geef getal " + (counter + 1) + ": ");
                numbers[counter] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Dit zijn de even getallen.");
            // alleen even getallen laten zien.
            for (counter = 0; counter < 10; counter++)
            { if ((counter % 2) == 0) // Hier wordt gekeken of het getal door 2 kan worden gedeeld.
                {
                    Console.WriteLine("getal " + (counter + 2) + " = " + numbers[counter + 1]);
                }
            }
            Console.ReadLine();
        }
    }
}
