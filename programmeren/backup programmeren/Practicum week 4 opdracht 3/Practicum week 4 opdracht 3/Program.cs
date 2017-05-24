using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_week_4_opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int intteller;
            int intfibo1;
            int intfibo2;
            int intfibo3;


            intfibo1 = 0;
            intfibo2 = 1;

            Console.Write(intfibo1.ToString() + " " + intfibo2.ToString() + " ");

            for (intteller = 3; intteller <= 10; intteller++)
            {
                intfibo3 = intfibo1 + intfibo2;
                intfibo1 = intfibo2;
                intfibo2 = intfibo3;

                Console.Write(intfibo3.ToString() + " ");
            }
            Console.ReadLine();
        }
    }
}
