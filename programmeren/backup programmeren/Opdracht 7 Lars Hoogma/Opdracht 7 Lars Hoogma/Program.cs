using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_7_Lars_Hoogma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef je voornaam");
            String naam = Console.ReadLine();
            Console.WriteLine("Familienaam");
            String Familienaam = Console.ReadLine();
            Console.WriteLine("Straat");
            String Straat = Console.ReadLine();
            Console.WriteLine("Huisnummer");
            String Huisnummer = Console.ReadLine();
            Console.WriteLine("Postcode");
            String Postcode = Console.ReadLine();
            Console.WriteLine("Gemeente");
            String Gemeente = Console.ReadLine();

            Console.WriteLine("Voornaam: "+naam);
            Console.WriteLine("Familienaam: "+Familienaam);
            Console.WriteLine("Straat: "+Straat);
            Console.WriteLine("Huisnummer: "+Huisnummer);
            Console.WriteLine("Postcode: "+Postcode);
            Console.WriteLine("Gemeente: "+Gemeente);
        }
    }
}
