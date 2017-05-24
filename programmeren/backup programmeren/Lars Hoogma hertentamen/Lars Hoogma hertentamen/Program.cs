using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hertentamenprogrammeren1
{
    class Program
    {
        /*Vraag 1   (2punten )                                                                                              2 punten
         Declareer een array voor zeven float getallen, geef deze array de naam Cijfers.
         a)Vul de array Cijfers interactief met getallen.
         b)Print de inhoud van even indices van de array Cijfers.
         c)Print de inhoud van de array Cijfers van achter naar voren.
           Het laatste element van de array Cijfers moet dus als eerste afgedrukt worden.
         d)Bereken het gemiddelde van de array Cijfers.
         */
        public static void Vraag1()
        {
            float[] cijfers = new float[7];
            for (int i = 0; i < cijfers.Length; i++)
            {
                cijfers[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("De getallen in het array zijn:");
            for (int i = 0; i < cijfers.Length; i++)
            {
                Console.Write(cijfers[i]+",");
            }
            Console.WriteLine();

            Console.WriteLine("De getallen in het array achterstevoren zijn:");
            for (int i = cijfers.Length - 1; i >= 0; i--)
            {
                Console.Write(cijfers[i] + ",");
            }
            Console.WriteLine();

            float gem = 0;
            for (int i = 0; i < cijfers.Length; i++)
            {
                gem += cijfers[i];
            }
            gem = gem / cijfers.Length;
            Console.WriteLine("Het gemiddelde van de getallen in de array is:");
            Console.WriteLine(gem);

            Console.ReadLine();
        }
        /* Vraag 2	 (1.5 punt)
                  Schrijf een console applicatie waarmee je de eerste 10 getallen van de rij 
                  van Fibonacci toont.
              f_0 = 0
              f_1 = 1
              f_n = f_{n-1} +f_{n-2}
              voor n > 1 
              dus f_2 = f_1 + f - 0 = 1 + 0 = 1
         */
        public static void Vraag2()
        {
            int antwoord = 0;
            for (int teller = 0; teller < 10; teller++)
            {
                antwoord = teller-1 + teller-2;



                if (antwoord >= 1 )
                {
                    Console.Write(antwoord + ",");
                }
            }

            Console.ReadLine();
        }
        /* Vraag 3 (1.5 punt)                                                                                              1.5 punt
          De array Namen bevat namen van leraren. 
          De inhoud van de array Namen is de volgende: {"Fiona", "Joris", "Job", "Albert", "Nynke", "Wouter"};
          Print op het scherm de namen van de leraren die zich op de oneven indices bevinden. Begin dus met “Joris” vervolgens “Albert”, etc. 
          Opmerking: je moet de array en een lus gebruiken.

        */
        public static void Vraag3()
        {
            string[] namen = new string[] { "Fiona", "Joris", "Job", "Albert", "Nynke", "Wouter" };
            for (int i = 0; i < namen.Length; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(namen[i] + ",");
                }
            }
            Console.ReadLine();
        }
        /*  Vraag 4   (2punten)                                                                                            2 punten
        Schrijf een programma om het volgende probleem op te lossen:
        Declareer twee arrays, de ene array heet “SocialMedia”, de andere krijgt de naam “Uren”. In de eerste array wordt de naam van een social media omgeving genoemd (bv “Instagram”, “LinkedIn”, “Facebook” of “Twitter”). In de tweede array wordt steeds het aantal uren per omgeving per dag vermeld dat de gebruiker er mee bezig is.
        De twee arrays hebben gelijke lengte, beide size 3.
        Definieer de arrays en laat in je programma de twee arrays interactief vullen.
        Vervolgens toont het programma  de  SocialMedia met ieder het aantal  uren dat je er aan hebt besteed .
        Voorbeeld: 

                  SocialMedia	Uren
                  Facebook	     3 
                  Twitter	     1 
                  Instagram 	 6 

                        * 
        * */
        public static void Vraag4()
        {
            string[] socialmedia = new string[3];
            int[] uren = new int[3];
            Console.WriteLine("Vul de soort Socialmedia in waar u bezig mee was afgesloten met ENTER");
            for (int i = 0; i < socialmedia.Length; i++)
            {
                socialmedia[i] = Console.ReadLine();
            }
            Console.WriteLine("Vul het aantal uren in dat u er bezig bent geweest vandaag afgesloten met ENTER");
            for (int i = 0; i < uren.Length; i++)
            {
                uren[i] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("Socialmedia:" + " " + "Uren");
            for (int i = 0; i < uren.Length; i++)
            {
                Console.WriteLine(socialmedia[i] + " " +":"+ uren[i] + "uren");
            }
            Console.ReadLine();


        }
        /* Vraag 5  (2 punten)                                                                                             2 punten
           Schrijf een programma, waarbij je een array declareert met 
           de volgende getallen: {1, 4, 2, 7, 35, 86, 7, 87, 8, 20, 6, 23, 23, 65}.
           Druk de getallen af die kleiner zijn dan het gemiddelde van de array.
           Bereken dus eerst het gemiddelde. 
           Opmerking: je moet een lus gebruiken!
                       * 
        * */
        public static void Vraag5()
        {
            int[] getallen = new int[] { 4, 2, 7, 35, 86, 7, 87, 8, 20, 6, 23, 23, 65 };
            int gem = 0;
            for (int i = 0; i < getallen.Length; i++)
            {
                gem += getallen[i];
            }
            gem = gem / getallen.Length;
            Console.WriteLine("het gemiddelde is: " + gem);
            for (int i = 0; i < getallen.Length; i++)
            {
                if (getallen[i] < gem)
                {
                    Console.Write(getallen[i] + ",");
                }
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //Vraag1();
            Vraag2();
            //Vraag3();
            //Vraag4();
            //Vraag5();

        }
    }
}
