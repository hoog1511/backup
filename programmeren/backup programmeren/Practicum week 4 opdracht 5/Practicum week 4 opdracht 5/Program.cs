using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_week_4_opdracht_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ontwerp een consoletoepassing waarmee je 3 worpen met 2 dobbelstenen nabootst. 
             * Het resultaat in de console toont wat de deelnemer wint. De deelnemer kan zelf kiezen hoeveel hij inzet. 
             * Het minimum inzet is 5 EUR en het maximum inzet is 100 EUR. Het spel kan herhaald worden na de laatste worp.
            */
            string exit;
      do {
            Console.WriteLine("Hoeveel geld wilt u inzetten?");
            int inzet = Convert.ToInt16(Console.ReadLine());
                if (inzet < 5)
                { Console.WriteLine("Alleen meer dan 5 euro");}
                    else if (inzet > 100)
                    { Console.WriteLine("Alleen meer dan 5 euro");}
            else if (inzet >= 5 && inzet <= 100)
                        {
                        // Dobbelstenen gooien.
                        Random D1 = new Random();
                        int R1 = D1.Next(1, 6);
                        Console.WriteLine("Uw 1te worp is " + R1);
                        int R2 = D1.Next(1, 6);
                        Console.WriteLine("Uw 2de worp is " + R2);
                            Console.WriteLine("voor ronde 2 druk op enter");
                            Console.ReadLine();
                        int R3 = D1.Next(1, 6);
                        Console.WriteLine("Uw 3de worp is " + R3);
                        int R4 = D1.Next(1, 6);
                        Console.WriteLine("Uw 4de worp is " + R4);
                            Console.WriteLine("voor ronde 3 druk op enter");
                            Console.ReadLine();
                        int R5 = D1.Next(1, 6);
                        Console.WriteLine("Uw 5de worp is " + R5);
                        int R6 = D1.Next(1, 6);
                        Console.WriteLine("Uw 6de worp is " + R6);
                //manieren om te winnen.
                int winst1 = inzet * 50;//bij 1 van de 3 worpen is er 2 keer een 6 geworpen: winst = inzet x 50
                int winst2 = inzet * 10;//bij 1 van de 3 worpen is er 2 keer hetzelfde geworpen: winst = inzet x 10
                int winst3 = inzet * 2;//bij de 3 worpen is er 2 keer een zes geworpen: winst = inzet x 2
                int winsttot = winst1 + winst2 + winst3;// alle winsten bij elkaar opgeteld winst1+winst2+winst3=winsttot.
                
                //voorwaarde's om te winnen.
                if (R1 == 6 && R2 == 6 || R3 == 6 && R4 == 6 || R5 == 6 && R6 == 6)
                { Console.WriteLine("U heeft " + winst1 + " Euro gewonnen!"); }
                    else if (R1 == R2 || R3 == R4 || R5 == R6)
                    { Console.WriteLine("U heeft " + winst2 + " Euro gewonnen!"); }
                        else if (R1 == 6 && R2 == 6 || R1 == 6 && R3 == 6 || R1 == 6 && R4 == 6 || R1 == 6 && R5 == 6 || R1 == 6 && R6 == 6 ||
                                 R2 == 6 && R3 == 6 || R2 == 6 && R4 == 6 || R2 == 6 && R5 == 6 || R2 == 6 && R6 == 6 ||
                                 R3 == 6 && R4 == 6 || R3 == 6 && R5 == 6 || R3 == 6 && R6 == 6 ||
                                 R4 == 6 && R5 == 6 || R4 == 6 && R6 == 6 ||
                                 R5 == 6 && R6 == 6)
                        { Console.WriteLine("U heeft " + winst3 + " Euro gewonnen!"); }
                            else Console.WriteLine("Helaas u heeft niks gewonnen");
                         }
                           // vragen om te stoppen.
                          Console.WriteLine("wilt u doorspelen? type (exit) in om te stoppen, zo niet druk op enter");
                          exit = Console.ReadLine();
         }
      while (exit != "exit");
            Console.ReadLine();
        }
    }
}
