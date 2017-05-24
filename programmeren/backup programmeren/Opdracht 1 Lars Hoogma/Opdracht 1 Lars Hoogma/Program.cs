using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Fiona Sariedine";
            char letter = 'C';
            int number1 = 123;
            double number2 = 1.5;
            bool waarnietwaar = false;
            int age = 35;
            double rest = number1 / number2;

            Console.WriteLine(name + " " + letter);
            Console.WriteLine(number1 + " " + number2);
            Console.WriteLine(waarnietwaar + " " + age);
            Console.WriteLine("rest = " + rest);
        }
    }
}