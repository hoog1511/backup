using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_week_3_opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            M: lichaamsgewicht in kg
            L: lengte in cm
            P: polsomtrek in cm
            */
            Console.WriteLine("Wat is uw lengte?");
            int lengte = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Bent u een man?");
                bool janee = Convert.ToBoolean(Console.ReadLine());
            if (janee == true)
            {
                Double ideaalman = (lengte - 100) * 0.9;
                ideaalman = System.Math.Round(ideaalman, 0);
                Console.WriteLine("U moet " + ideaalman + " kilo zwaar zijn.");
            }
            else
            {
                Console.WriteLine("Wat is uw polsomtrek?");
                int polsomtrek = Convert.ToInt16(Console.ReadLine());
                int som = lengte + 4 * polsomtrek - 100;
                Double ideaalvrouw = som / 2;
                ideaalvrouw = System.Math.Round(ideaalvrouw, 0);
                Console.WriteLine("U moet "+ideaalvrouw+" kilo zwaar zijn.");
            }

            Console.ReadLine();
        }
    }
}
