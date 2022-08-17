using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Metody
    {
        public static void soucetM()
        {
            Console.Write("a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine(a + b);
            Console.ReadLine();

        }
        public static double soucetM1()
        {
            Console.Write("a: ");
            double a = float.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = float.Parse(Console.ReadLine());
            return a + b;

        }

        public static double soucetM1v2(double a, double b)
        {
            return a + b;

        }

        public static double odecetM1(double a, double b)
        {
            return a - b;

        }
        public static void scitanOdecitani()
        {
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("součet: " + soucetM1v2(a, b));
            Console.WriteLine("odečet: " + odecetM1(a, b));
            Console.ReadLine();

        }

        public static string maximum(double a, double b)
        {
            if (a > b)
                return ("Maximum: " + a);
            else
                return ("Maximum: " + b);



        }
        public static string minimum(double a, double b)
        {
            if (a > b)
                return ("Minimum: " + b);
            else
                return("Minimum: " + a);



        }
        public static string porovnani(double a, double b)
        {
            if (a > b)
                return (a + ">" + b);
            else if (a < b)
                return (a + "<" + b);
            else
                return (a + "=" + b);

        }
        public static string konec()
        {
            return ("Konec! ");

        }
        public static void vyber()
        {
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());

            string volba = "";

            do
            {
                Console.WriteLine("1.Maximum, 2.Minimum, 3.Porovnání, 4.konec");
                volba = Console.ReadLine();

                if (volba == "1")
                { 
                    Console.WriteLine(maximum(a, b));
                    Console.ReadLine();
                }
                else if (volba == "2")
                {
                    Console.WriteLine(minimum(a, b));
                    Console.ReadLine();
                }
                else if (volba == "3")
                {
                    Console.WriteLine(porovnani(a, b));
                    Console.ReadLine();
                }
                else if (volba == "4")
                {
                    Console.WriteLine(konec());
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Zadej číslo od 1-4!!!");
                    Console.ReadLine();
                }
            }while(volba != "4");
            
        }
        public static double vstupDouble()
        {
            double cislo;
            while (true)
            {
                Console.WriteLine("Zadej číselnou hodnotu: ");
                if (double.TryParse(Console.ReadLine(), out cislo)) break;
                Console.WriteLine("NEZADAL JSI ČÍSELNOU HODNOTU!!!!\n");
            }
            return cislo;
        }
        public static void vyberV2()
        {
            double a = vstupDouble();
            double b = vstupDouble();

            string volba = "";

            do
            {
                Console.WriteLine("1.Maximum, 2.Minimum, 3.Porovnání, 4.konec");
                volba = Console.ReadLine();

                if (volba == "1")
                {
                    Console.WriteLine(maximum(a, b));
                    Console.ReadLine();
                }
                else if (volba == "2")
                {
                    Console.WriteLine(minimum(a, b));
                    Console.ReadLine();
                }
                else if (volba == "3")
                {
                    Console.WriteLine(porovnani(a, b));
                    Console.ReadLine();
                }
                else if (volba == "4")
                {
                    Console.WriteLine(konec());
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Zadej číslo od 1-4!!!");
                    Console.ReadLine();
                }
            } while (volba != "4");

        }

    }
    
}
