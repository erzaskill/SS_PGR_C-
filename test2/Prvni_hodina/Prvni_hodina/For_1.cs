using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class For_1
    {
        //for(úvodná hodnota podmínka, úprava hodnoty)
        public static void ForVypisI()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 1; i <= 100; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        //program se zeptá na počet čísel a na to zda je chceme vypsat
        //vzestupně, nebo sestupně, poté vypíše
        public static void ukol2()
        {
            Console.Write("počet?: ");
            int pocet = int.Parse(Console.ReadLine());
            Console.Write("Sestupne 1, jinak vzestupne: ");
            string volba = Console.ReadLine();

            if (volba == "1")
                for (int i = pocet; i >= 1; i--)
                    Console.WriteLine(i);
            else
                for (int i = 1; i <= pocet; i++)
                    Console.WriteLine(i);
            Console.ReadLine();      
        }

    //program se zeptá, kolik čísel chceme načíst, následně je načte
    //poté zobrazí jejich průměr

        public static void ukol3()
        {
            Console.Write("počet?: ");
            int pocet = int.Parse(Console.ReadLine());
            double soucet = 0;
            for (int i = 1; i <= pocet; i++)
            {
                Console.Write("Zadej číslo: ");
                double cislo = double.Parse(Console.ReadLine());
                soucet = soucet + cislo;

            }
            Console.WriteLine("průměr: {0}: ",soucet/pocet);
            Console.ReadLine(); 
    
        }

        public static void ukol4()
        {
            int pocet = 0;
            while (true)
            {   

                Console.WriteLine("Zadej počet: ");
                if (int.TryParse(Console.ReadLine(), out pocet)) break;
                Console.WriteLine("Nezadl jsi číslo!!!!!\n");
            }
            double soucet = 0;
            for (int i = 1; i <= pocet; i++)
            {
                Console.Write("Zadej číslo: ");
                double cislo = double.Parse(Console.ReadLine());
                soucet = soucet + cislo;

            }
            Console.WriteLine("průměr: {0}: ", soucet / pocet);
            Console.ReadLine();
        
        }

        public static void ukol5()
        {
            Random generovaniCisla = new Random();
            int pocet = 0;
            while (true)
            {

                Console.WriteLine("Zadej počet: ");
                if (int.TryParse(Console.ReadLine(), out pocet)) break;
                Console.WriteLine("Nezadl jsi číslo!!!!!\n");
            }
            double soucet = 0, min= double.MaxValue, max = double.MinValue;
            string tisk = "";
            int p = 0;
            for (int i = 1; i <= pocet; i++)
            {
                //generuje čísla od 1 do 100
                double cislo = generovaniCisla.Next(1, 101);
                //
                p++;
                tisk = tisk + cislo + "; ";
                if (p == 10)
                {
                    tisk = tisk + "\n";
                    p = 0;
                }
                soucet = soucet + cislo;
                if (cislo > max) max = cislo;
                if (cislo < min) min = cislo;

            }
            Console.WriteLine(tisk);
            Console.WriteLine("průměr: {0}: ", soucet / pocet);
            Console.WriteLine("max: {0}, min: {1}", max,min);
            Console.ReadLine();
         
        }
        //Zadat 3 čísla,průměr, vypsat průměr a počet čísel, výpis

        public static void test1()
        {
            int pocet = 0;
            float soucet = 0;
            float prumer = 0;

            do
            {

                Console.WriteLine("Zadej první číslo: ");
                float a = float.Parse(Console.ReadLine());
                pocet = pocet + 1;

                Console.WriteLine("Zadej druhé číslo: ");
                float b = float.Parse(Console.ReadLine());
                pocet = pocet + 1;

                Console.WriteLine("Zadej třetí číslo: ");
                float c = float.Parse(Console.ReadLine());

                pocet = pocet + 1;
                soucet = a + b + c;
                prumer = soucet / pocet;

            } while (pocet != 3);

            Console.WriteLine("Průměr: {0}\nPočet čísel: {1}", prumer, pocet);
            Console.ReadLine();
        }
        //Zadej počet čísel, volba: 1 výpis,2 Max, min,3Konec
        public static void test2()
        {

            float min = float.MaxValue;
            float max = float.MinValue;
            string vypis = "";
            string volba = "";

            Console.WriteLine("Zadej kolik čísel chceš zadat: ");
            int pocet = int.Parse(Console.ReadLine());


            for (int i = 0; i <= pocet; i++)
            {
                Console.WriteLine("Zadej {0}. číslo: ", i + 1);
                float a = float.Parse(Console.ReadLine());

                if (a > max)
                { max = a; }

                if (a < min)
                { min = a; }

                vypis = vypis  + a + "; ";
            }

            do
            {
                Console.WriteLine("Zadej svou volbu: 1.Výpis, 2.Maximální a minimální hodnota, 3.Konec");
                volba = Console.ReadLine();

                if (volba == "1")
                {
                    Console.WriteLine("Vypís hodnot: {0}", vypis);
                }
                else if (volba == "2")
                {
                    Console.WriteLine("Maximální hodnota: {0}\nMinimální hodnota: {1}", max, min);
                }
                else if (volba == "3")
                { break; }

                else
                {Console.WriteLine("Zadal si špatně svou volbu.. vyber číslo od 1 do 3!!"); }


            } while (true);

        }

    }
}
