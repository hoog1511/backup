using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_8_Lars_Hoogma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vu 3 getallen omstebeurten in afgesloten met enter");
            float a = Convert.ToInt16(Console.ReadLine());
            float b = Convert.ToInt16(Console.ReadLine());
            float c = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("y= "+a*b/c);
        }
    }
}
