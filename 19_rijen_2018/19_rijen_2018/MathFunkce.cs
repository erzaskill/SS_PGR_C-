using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19_rijen_2018
{
    class MathFunkce
    {
        public static void matFunkce()
        {
            // NOVÉ MATEMATICKÉ FUNKCE!!!
            Console.WriteLine("Absolutní hodnota 10: " + Math.Abs(-10));
            Console.WriteLine("Max z 10 a 2: " + Math.Max(10, 2));
            Console.WriteLine("Třetí mocnina dvou: " + Math.Pow(2, 3));
            Console.WriteLine("Zaokrouhlení 1.2365 na 1 des. místo: " + Math.Round(1.2365, 1));
            Console.WriteLine("Druhá odmocnina z 9: " + Math.Sqrt(9));

        }

        //Vytvořte metodu, která načte 3 čísla a zjistí max. hodnotu
        public static void max3Cisel()
        {
            Console.WriteLine("Zadej 3 cisla: ");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            Console.WriteLine("Max: {0}", Math.Max(a, Math.Max(b, c)));
            Console.ReadLine();
        }
        //Pythagorova věta!!
        public static void pythagorovka()
        {
            Console.WriteLine("Zadej velikost odvěsen: ");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Přepona: " + Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
            Console.ReadLine();
            
        }

        public static void vzorecek()
        {
            Console.WriteLine("Zadej velikost hodnoty a: ");
            float a = float.Parse(Console.ReadLine());


            Console.WriteLine("b= " + Math.Abs(a) / a);
            Console.ReadLine();
        }
    }
}
