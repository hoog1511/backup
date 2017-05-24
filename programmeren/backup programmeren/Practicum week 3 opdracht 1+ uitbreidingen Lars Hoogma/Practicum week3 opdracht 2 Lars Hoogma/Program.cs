using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_week3_opdracht_2_Lars_Hoogma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uitbreiding deel 3
            Console.WriteLine("Bent u hier voor Ladies night?");
            bool janee = Convert.ToBoolean (Console.ReadLine());
            if (janee == true)
            {
                Console.WriteLine("Wat is uw leeftijd?");
                int vrouwleeftijd = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Bent u getrouwd?");
                bool getrouwd = Convert.ToBoolean(Console.ReadLine());
                if (vrouwleeftijd >= 30 && getrouwd == false)
                    Console.WriteLine("U bent "+vrouwleeftijd+" "+"jaar oud. Veel plezier op lady's night in de Versus.");

                else
                { Console.WriteLine("Helaas! u moet minimaal 30 jaar zijn en ongehuwd om toegang te krijgen tot lady's night bij de Versus."); }
            }
            else

            // deel 1
            {
                Console.WriteLine("Wat is uw leeftijd?");
                int leeftijd = Convert.ToInt16(Console.ReadLine());
                if (leeftijd >= 16)
                {
                    Console.WriteLine("Je bent" + " " + leeftijd + " " + "jaar oud. Veel plezier in de Versus.");
                    if (leeftijd >= 21) { Console.WriteLine("Je krijgt toegang tot onze exclusieve VIP - lounge!"); }
                }
                else
                { Console.WriteLine("Helaas! Je moet minimaal 16 jaar zijn om toegang te krijgen tot de Versus."); }

                //uitbreiding deel 2
                Console.WriteLine("Met hoeveel personen bent u ? Maximum aantal is 10 personen");
                int personen = Convert.ToInt16(Console.ReadLine());

                switch (personen)
                {
                    case 1:
                        Console.WriteLine("U krijgt geen korting");
                        break;
                    case 2:
                        Console.WriteLine("U krijgt geen korting");
                        break;
                    case 3:
                        Console.WriteLine("U krijgt 10% korting");
                        break;
                    case 4:
                        Console.WriteLine("U krijgt 20% korting");
                        break;
                    case 5:
                        Console.WriteLine("U krijgt 50% korting");
                        break;
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        Console.WriteLine("Gratis entree");
                        break;
                    default:
                        Console.WriteLine("Te veel personen");
                        break;
                }

                
            }
        Console.ReadLine();}
    }
}
