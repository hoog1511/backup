using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicumweek2_opdracht3__Lars_Hoogma_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a");
            float a= Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter b");
            float b = Convert.ToInt16(Console.ReadLine());
            
            float c;

            c = a;
            a = b;
            b = c;
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);

        }
    }
}
