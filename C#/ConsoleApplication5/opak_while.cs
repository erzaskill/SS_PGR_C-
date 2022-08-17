using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class opak_while
    {
        public static void program()
        {
            int soucet = 0;
            int pocet = 0;
            string v = "";
            int max = -1; //int max = int.MinValue;
            while (true)
            {
                Console.WriteLine("Zadej číslo: ");
                int a = int.Parse(Console.ReadLine());
                if (a < 0)
                    break;

                v = v + a + "\n ";
                if (a > max)
                    max = a;
                
                pocet++; //pocet = pocet + 1;
                soucet = soucet + a; //soucet+= pocet;
                
                

            }
            Console.WriteLine("Zadané hodnoty: " + "\n" + v);
            Console.WriteLine("Maximální hodnota: " + max);
            Console.WriteLine("Průměr: " + (soucet / pocet));
            Console.ReadLine();
            }
        //Zadej dvě čísla, program nabídne možnosti:
        //1. součet 2.součin 3.konec
        //Dokud není 3, program se vrací na výpis
            public static void program2()
            {
            Console.WriteLine("Zadej a: ");
            int a= int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej b: ");
            int b= int.Parse(Console.ReadLine());
            string vypis="";
            do
            {
            Console.WriteLine("1. soucet, 2. pocet, 3. konec");
            vypis = Console.ReadLine();
            if (vypis=="1")
            {
            Console.WriteLine("součet: " + (a + b));
            Console.ReadLine();
            }
            else if (vypis=="2")
            {
            Console.WriteLine("součin: " + (a*b) );
            Console.ReadLine();
            }
            
            } while (vypis !="3");
            }


            public static void program3()
            {
                char a;
                string tisk = "";
                do
                {
                    Console.WriteLine("Zadej znak: ");
                    char a = Console.ReadKey().KeyChar;
                    tisk += a; //tisk=tisk + a

                } while (a != 'w');
                Console.WriteLine("Zadal jsi:" + tisk);
                Console.ReadLine();


            }
     
            
            
            


            }
    }

