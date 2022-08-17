using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nevjem
{
    class trida
    {
        public static void program()
        {
            string volba = "";
            do
            {
                Console.WriteLine("Zadej věk: ");
                int a = int.Parse(Console.ReadLine());
                if (a <= 0 || a > 100)
                {
                    Console.WriteLine("Zadal jsi špatný věk.");
                    Console.ReadKey();

                }
                if (a <= 6 && a > 0)
                {
                    Console.WriteLine("Vstupné 30 Kč.");
                    Console.ReadKey();
                }
                else if (a >= 7 && a <= 18)
                {
                    Console.WriteLine("Vstupné 80 Kč.");
                    Console.ReadKey();
                }
                else if (a > 18 && a <= 70)
                {
                    Console.WriteLine("Vstupné 200 Kč.");
                    Console.ReadKey();
                }
                else if (a > 70 && a <= 100)
                {
                    Console.WriteLine("Vstupné 80 Kč.");
                    Console.ReadKey();
                }


                Console.WriteLine("1.konec");
                volba = Console.ReadLine();
            } while (volba != "1");
        }

        public static void program2()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 100);
            Console.ReadLine();


        }
        public static void program3()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 100) ;
            Console.ReadLine();


        }
        public static void program4()
        {
            int i = 1;
            while (true)
            {
                Console.WriteLine(i);
                if (i == 100)
                    break;
                i++;
            }
            Console.ReadLine();


        }
        public static void program5()
        {
            Console.WriteLine("Zadej číslo: ");
            int a = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine(a);
                if (a == 1)
                    break;
                a--;
            }
            Console.ReadLine();


        }
        public static void program6()
        {
            int max = -1;
            while(true)
            {
            Console.WriteLine("Zadej číslo: ");
            int a = int.Parse(Console.ReadLine());
            if (a<0) 
            break;

            v = v + a + "\n ";
            if (a>max)
                max = a;
            }
            Console.WriteLine("Zadané hodnoty: "+ "\n" + v);
            Console.WriteLine("Maximální hodnota: " + max);
            Console.ReadLine();
           

        
    
    
        }

    }
}



