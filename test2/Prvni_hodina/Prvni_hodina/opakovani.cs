using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class opakovani
    {
        public static void matOperace()
        {
            Console.WriteLine(" Zadej a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine(" Zadej b: ");
            double b = double.Parse(Console.ReadLine());
            char pokracovat;
            do
            {
                Console.Write("+,-,*,/"); //\n nový řádek

                //char - datový typ obsahuje jeden znak
 
                char volba = Console.ReadKey().KeyChar;
                if (volba == '+')
                    Console.WriteLine(a + b);
                else if (volba == '-')
                    Console.WriteLine(a - b);
                else if (volba == '*')
                    Console.WriteLine(a * b);
                else if (volba == '/')
                    if (b == 0) Console.WriteLine("Dělení nulou!! ");
                else Console.WriteLine(a / b);
                else
                    Console.WriteLine("špatná volba");
                Console.Write("\nPokračovat - a: ");
                pokracovat = Console.ReadKey().KeyChar;

            } while(pokracovat =='a');
            Console.Write("\nznovu načíst - a: ");
            pokracovat = Console.ReadKey().KeyChar;

            Console.ReadLine();





        }
    }
}
