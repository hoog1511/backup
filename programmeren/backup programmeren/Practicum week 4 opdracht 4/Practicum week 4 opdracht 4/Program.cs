using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_week_4_opdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ontwerp een consoletoepassing waarmee je het gemiddelde verbruik van een wagen kan berekenen per 100 km. 
             * Bij elke tankbeurt noteert de gebruiker hoeveel kilometer hij gereden heeft sinds de vorige tankbeurt en 
             * hoeveel liter hij getankt heeft. 
             * Wanneer de gebruiker de waarde 0 ingeeft voor het aantal liter dan berekent het programma het gemiddelde verbruik.*/
            double km;
            double liters;
            double totkm = 0;
            double totliters = 0;
            double verbruik = 0;

            do
            {
                Console.WriteLine("Hoeveel Liters heeft u getankt?");
                liters = Convert.ToDouble(Console.ReadLine());
                // als 0 wordt ingevuld dan berekent hij het gemiddelde.
                    if (liters != 0)
                    {
                        Console.WriteLine("Hoeveel Kilometers heeft u gereden?");
                        km = Convert.ToDouble(Console.ReadLine());

                        //berekening
                        totkm = totkm + km;
                        totliters = totliters + liters;
                        verbruik = (totliters / totkm) * 100;
                    }
                // als 0 wordt ingevuld dan berekent hij het gemiddelde.
            } while (liters != 0);
            Console.WriteLine("Het totaal aantal liters = "+ totliters.ToString());
            Console.WriteLine("het totaal aantal Kilometers = "+ totkm.ToString());
            Console.WriteLine("Het verbruik van je auto = " + Math.Round(verbruik, 1) + " liter per 100 km");
            Console.ReadLine();
        }
    }
}
