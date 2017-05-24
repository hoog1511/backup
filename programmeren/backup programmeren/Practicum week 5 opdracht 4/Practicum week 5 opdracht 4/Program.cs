using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_week_5_opdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Je declareert 3 arrays met telkens 5 waarden. 
             * De eerst 2 arrays vul je op met getallen tussen 0 en 9. 
             * De derde array vul je achteraf op met de som van de overeenkomstige velden uit array 1 en 2. 
             * Je toont in de console de 3 arrays in de vorm van een som.*/

            //delcareer variabellen.
            int[] array1 = new int[5];
            int[] array2 = new int[5];
            int[] arraysom = new int[5];

            // opvragen van getallenreeks 1.
            Console.WriteLine("Vul getallenreeks 1 in (tussen de 0 en de 9). ");
            for (int counter = 0; counter <5; counter++)
            {
                array1[counter] = Convert.ToInt16(Console.ReadLine());
            }
            // opvragen van getallenreeks 2.
            Console.WriteLine("Vul getallenreeks 2 in (tussen de 0 en de 9). ");
            for (int counter = 0; counter < 5; counter++)
            {
                array2[counter] = Convert.ToInt16(Console.ReadLine());
            }
            // de som
            for (int counter = 0; counter < 5; counter++)
            {
                arraysom[counter] = array1[counter] + array2[counter];
                Console.WriteLine(array1[counter] + " + " + array2[counter] + " = " + arraysom[counter]);
            }
            Console.ReadLine();
        } 
    }
}
