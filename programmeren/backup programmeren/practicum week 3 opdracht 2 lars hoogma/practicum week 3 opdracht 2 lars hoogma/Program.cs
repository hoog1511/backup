using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicum_week_3_opdracht_2_lars_hoogma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welke taal?  Nederlands, English, Français, Frysk, Deutsch");
            string talen = Console.ReadLine();

            switch (talen)
            {
                case "nederlands":
                    Console.WriteLine("Tot ziens");
                    break;
                case "english":
                    Console.WriteLine("Goodbye");
                    break;
                case "français":
                    Console.WriteLine("Au revoir");
                    break;
                case "frysk":
                    Console.WriteLine("Oan´t Sjen");
                    break;
                case "deutsch":
                    Console.WriteLine("Auf Wiedersehen");
                    break;
         
                default:
                    Console.WriteLine(" ");
                    break;
            }

        }
    }
}
