using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cyklus
{
    class Zkousim
    {
        public static void VypisCisel()
        {
            int a = 1;
            while (a <= 100)
            {
                Console.WriteLine(a);
                a++; // a = a + 1;//

            }
            Console.ReadLine();
        }
        public static void VypisCisel3()
        {
            int i = 1;
            while (true)
            {
                Console.WriteLine(i);
                if (i == 100)
                    break;//ukončí cyklus
                i++;
            }
            Console.ReadLine();
        }
        public static void VypisCisel2()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 100);
            Console.ReadLine();
        }
        public static void VzestupnyVypis()
        {
            int i = 100;
            while (true)
            {
                Console.WriteLine(i);
                if (i == 0)
                    break;
                i--; //odečte jedničku
            }
            Console.ReadLine();
        }
        //Program bude načítat čísla,
        //pokud zadáme záporné číslo, načítání se ukončí.
        //Záporné číslo program nenačte.
        //Program čísla vypíše, a zobrazí maximální hodnotu

        public static void MaxHodnota()
        {
            int a = 0;
            string v = "";
            int pocet = 0;
            float soucet = 0;
            int max = -1; // float max = float.MinValue; = vrátí minimální hodnotu!
            do
            {
                Console.WriteLine("Zadej hodnotu");
                a = int.Parse(Console.ReadLine());
                if (a < 0)
                    break;
                v = v + a + "\n";
                if (a > max)
                    max = a;
                pocet++; //pocet = pocet + 1
                soucet = soucet + a; // soucet +=pocet; = zkrácené


            } while (true);
            Console.WriteLine("\n" + "Zadané hodnoty: " + "\n" + v + "\n" + "\n" + "Maximální hodnota: " + max + "\n\n" + "Průměrná hodnota: " + soucet / pocet);
            Console.ReadLine();


        }


        //Zadej dvě čísla, program nabídne možnosti:
        //součet, 2. součin, 3. konec
        //dokud není 3, program se vrací na výpis.

        public static void Volba1()
        {
            string volba = "";
            Console.WriteLine("Zadej první číslo: ");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Zadej druhé číslo: ");
            float b = float.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Možnosti volby: 1.součet, 2.součin, 3.konec");
                volba = Console.ReadLine();
                if (volba == "1")
                    Console.WriteLine("Součet: " + (a + b));
                    
                else if (volba == "2")
                    Console.WriteLine("Součin: " + (a * b));
                    
                else if (volba == "3")
                    Console.WriteLine("Konec!!");
                  
                else
                    Console.WriteLine("Napsal si špatně svou volbu");
                    
                   

            } while (volba != "3");
            Console.ReadLine();



        }
        //Program bude načítat znaky z klávesnice
        //po zadání 'w' se program ukonci

        public static void ZadejZnak()
        {
           
            char znak;
            string tisk = "";
            do
            {
                Console.WriteLine("Zadej znak");
                znak = Console.ReadKey().KeyChar; //datový typ pro jeden znak
                tisk+=znak;

               
            } while (znak != 'w');

            Console.WriteLine("\nZadal jsi {0}


            

      
        }
    }
}