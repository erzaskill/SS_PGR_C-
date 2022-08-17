using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Class1
    {
        public static void program4()
        {

            Console.WriteLine("Zadej znak, který chceš zadat: ");
            char a = Console.ReadKey().KeyChar;
            Console.WriteLine("Zadej počet, kolikrát chceš znak vytisknout: ");
            float b = float.Parse(Console.ReadLine());

            int cislo = 0;
            string v = "";
            while (cislo != b)
            {
                a++;
                v = v + a;
            }
            Console.WriteLine(v);
            Console.ReadLine();
        }
        //Vytvořte metodu, která bude načítat čísla, ukončení bude po zadání 0. S tou nebude dál pracovat.
        //Následně program zobrazí nabídku:
        //1.Výpis(1;2), 2.min, max, prum, 3.konec
        //dokud se nezadá 3, zobrazuje se výpis
        public static void program1()
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            int soucet = 0;
            int pocet = 0;
            v = v + a + " \n ";
            int a;
            string v = "";
            do
            {
                Console.WriteLine("Zadej hodnotu: ");
                a = int.Parse(Console.ReadLine());
            } while (a != 0);
            string vypis = "";
            while (true)
            {
                Console.WriteLine("1.vypis, 2. min, max, prum , 3. konec");
                vypis = Console.ReadLine();
                if (vypis == "1")
                {
                    Console.WriteLine("Výpis: " + v);
                    Console.ReadLine();
                }
                else if (vypis == "2")
                {
                    if (a > max)
                    else if (a < min)
                    soucet = soucet + a;
                    pocet = pocet + a;
                    Console.WriteLine("minimum:" + min);
                    Console.WriteLine("maximum:" + max);
                    Console.WriteLine("prumer:" + (soucet / pocet));

                    Console.ReadLine();
                }


            }

        }


    }
}
        
    
    
