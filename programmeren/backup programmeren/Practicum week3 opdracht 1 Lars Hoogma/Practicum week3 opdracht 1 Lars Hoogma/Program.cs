using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_week3_opdracht_1_Lars_Hoogma
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Om toegang te krijgen tot de discotheek Versus moet je minimaal 16 jaar oud zijn. 
            Ontwerp een consoletoepassing waarmee je de leeftijd van de gebruiker opvraagt. 
            Als de ingevoerde leeftijd 16 jaar of meer bedraagt, krijgt de gebruiker toegang tot de discotheek en verschijnt de tekst: “Je bent x jaar oud. 
            Veel plezier in de Versus.”. Indien niet voldaan is aan deze voorwaarde verschijnt de tekst: “Helaas! Je moet minimaal 16 jaar zijn om toegang te krijgen tot de Versus.”.
            Uitbreiding probleemstelling toegang Versus: VIP - lounge
            Indien de gebruiker 21 jaar of ouder is, krijgt hij/ zij toegang tot de VIP-lounge van de Versus.
            De volgende tekst verschijnt: “Je krijgt toegang tot onze exclusieve VIP - lounge!”.*/
    Console.WriteLine("wat is uw leeftijd?");
    int leeftijd = Convert.ToInt16(Console.ReadLine());

            if (leeftijd >= 16)
            { Console.WriteLine("Je bent" + " " + leeftijd + " " + "jaar oud. Veel plezier in de Versus.");
                if (leeftijd >= 21) { Console.WriteLine("Je krijgt toegang tot onze exclusieve VIP - lounge!"); }
            }
            else
            { Console.WriteLine("Helaas! Je moet minimaal 16 jaar zijn om toegang te krijgen tot de Versus."); }
            Console.ReadLine();

        }
    }
}
