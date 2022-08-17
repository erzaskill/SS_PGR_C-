using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opakovani_7._09._2018
{
    class NoveFunkce
    {
        public static void scitaniTryParse()
        {
            float a;
            Console.WriteLine("Zadej první číslo: ");
            bool testA = float.TryParse(Console.ReadLine(), out a);

            float b;
            Console.WriteLine("Zadej druhé číslo: ");
            bool testB = float.TryParse(Console.ReadLine(), out b);

            if (testA == true && testB == true) Console.WriteLine("Sečtení těchto dvou čísel: " + (a + b)); //Stačí to napsat jako TestA && TestB - protože u boolenu je proměnná ze startu hned true
            else Console.WriteLine("Chyba ve vstupu..");


            Console.ReadLine();

        }

        //vytvořte variantu, pokud zadáte nečíselnou hodnotu, oznámí chybu a znovu se zeptá
        public static void KontrolaHodnoty()
        {
            float a;
            float b;
            bool testA;
            bool testB;

            do
            {

                Console.WriteLine("Zadej první číslo: ");
                testA = float.TryParse(Console.ReadLine(), out a);

                Console.WriteLine("Zadej druhé číslo: ");
                testB = float.TryParse(Console.ReadLine(), out b);

                if (testA == true && testB == true) break;
 
                    Console.WriteLine("Chybně zadaná hodnota! ");

            } while (true); //Může se to napsat jako: while (!(testA && testB));

            Console.WriteLine(a + b);
            Console.ReadLine();
        }
        // DALSI PRIKLAD
        public static double soucet()
        {
            float a;
            float b;
            bool testA;
            bool testB;

            do
            {

                Console.WriteLine("\nZadej první číslo: ");
                testA = float.TryParse(Console.ReadLine(), out a);

                Console.WriteLine("\nZadej druhé číslo: ");
                testB = float.TryParse(Console.ReadLine(), out b);

                if (testA == true && testB == true) break;
 
                    Console.WriteLine("Chybně zadaná hodnota! ");

            } while (true);
            return (a + b);
            //Nic nám neukáže vždycky potřebujeme program který je void (public static VOID)
      
        }
        public static void pocitani()
        {
            char pokracovat;
            do
            {
                Console.WriteLine("\n" + soucet());
                Console.ReadLine(); // program který si vyvolá metodu..

                Console.Write("pokračovat - a: ");
                pokracovat = Console.ReadKey().KeyChar;
            } while (pokracovat == 'a');
        }
        //DALSI PRIKLAD
        public static float souc(float a, float b)
        { return a + b; }
        public static float rozdil(float a, float b)
        { return a - b; }
        public static float soucin(float a, float b)
        { return a * b; }
        public static float podil(float a, float b)
        { return a / b; }

        public static void kalkulacka()
        {
            float a;
            float b;
            bool testA;
            bool testB;

            do
            {

                Console.WriteLine("Zadej první číslo: ");
                testA = float.TryParse(Console.ReadLine(), out a);

                Console.WriteLine("Zadej druhé číslo: ");
                testB = float.TryParse(Console.ReadLine(), out b);

                if (testA == true && testB == true) break;

                Console.WriteLine("Chybně zadaná hodnota! ");

                

            } while (true);

            do
            {



                Console.Write("\nZadej matematickou operaci (+, -, *, /): ");
                char volba = Console.ReadKey().KeyChar;
                if (volba == '+')
                {
                    Console.WriteLine("\n" + souc(a, b));
                    Console.ReadLine();

                }
                else if (volba == '-')
                {
                    Console.WriteLine("\n" + rozdil(a, b));
                    Console.ReadLine();

                }
                else if (volba == '*')
                {
                    Console.WriteLine("\n" + soucin(a, b));
                    Console.ReadLine();

                }
                else if (volba == '/')
                {
                    if (b != 0)
                        Console.WriteLine("\n" + podil(a, b));


                    else
                        Console.WriteLine("\nNulou dělit nelze!!!");
                    Console.ReadLine();
                }
            } while (true);

            //program po načtení hodnot zobrazí (+,-,*,/,k)
        }

        




        public static void necozkousim()
        {
            float a;
            float b;
            bool testA;
            bool testB;

            do
            {

                Console.WriteLine("Zadej první číslo: ");
                testA = float.TryParse(Console.ReadLine(), out a);

                Console.WriteLine("Zadej druhé číslo: ");
                testB = float.TryParse(Console.ReadLine(), out b);

                if (testA == false || testB == false) Console.WriteLine("Chybně zadaná hodnota! ");




            } while (testA == false && testB == false); //Může se to napsat jako: while (!(testA && testB));

            Console.WriteLine(a + b);
            Console.ReadLine();
        }
            
    }
        
}
