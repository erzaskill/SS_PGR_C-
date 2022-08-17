using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opakovani_7._09._2018
{
    class Zacatek
    {
        public static void matOperace()
        {
            Console.WriteLine("Zadej první číslo: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej druhé číslo: ");
            float b = float.Parse(Console.ReadLine());


            Console.WriteLine("Zadej matematickou operaci (+, -, *, /): ");
            string volba = Console.ReadLine();

            if (volba == "+")
            {
                Console.WriteLine("Vybral si si sčítání: " + (a + b));
                Console.ReadLine();

            }
            else if (volba == "-")
            {
                Console.WriteLine("Vybral si si odčítání: " + (a - b));
                Console.ReadLine();

            }
            else if (volba == "*")
            {
                Console.WriteLine("Vybral si si násobení: " + (a * b));
                Console.ReadLine();

            }
            else if (volba == "/")
            {
                if (b != 0)
                    Console.WriteLine("Vybral si si dělení: " + (a / b));

                else
                    Console.WriteLine("Nulou dělit nelze!!!");
                Console.ReadLine();
            }


            else
            {
                Console.WriteLine("Napsal si špatně svou volbu!!!");
                Console.ReadLine();
            }

            // Tady tohle to mohu využívat na komentáře
            // Console.WriteLine("Řešení: {0} + {1}= {2}", a,b,a+b)
            // Console.WriteLine("Součet: " + (a+b))

        }
        public static void charfunkce()
        {
            char NoveNacteni;
         
            do
            {


            Console.WriteLine("\nZadej první číslo: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("\nZadej druhé číslo: ");
            float b = float.Parse(Console.ReadLine());
            char pokracovat;

            do
            {
            
            

            Console.Write("\nZadej matematickou operaci (+, -, *, /): ");
            // char - datový typ obsahuje jeden znak, nefunguji uvozovky ale '
            char volba = Console.ReadKey().KeyChar;

            if (volba == '+')
            {
                Console.WriteLine("\nVybral si si sčítání: " + (a + b));
                Console.ReadLine();

            }
            else if (volba == '-')
            {
                Console.WriteLine("\nVybral si si odčítání: " + (a - b));
                Console.ReadLine();

            }
            else if (volba == '*')
            {
                Console.WriteLine("\nVybral si si násobení: " + (a * b));
                Console.ReadLine();

            }
            else if (volba == '/')
            {
                if (b != 0)
                    Console.WriteLine("\nVybral si si dělení: " + (a / b));

                else
                    Console.WriteLine("\nNulou dělit nelze!!!");
                Console.ReadLine();
            }


            else
            {
                Console.WriteLine("Napsal si špatně svou volbu!!!");
                Console.ReadLine();
            }
            Console.Write("pokračovat - a: ");
            pokracovat = Console.ReadKey().KeyChar;
                }while(pokracovat == 'a');
            Console.Write("Přeješ si zadat nově čísla? - a: ");
            NoveNacteni = Console.ReadKey().KeyChar;
        }while (NoveNacteni == 'a');
            
            
            







        }
    }
}
