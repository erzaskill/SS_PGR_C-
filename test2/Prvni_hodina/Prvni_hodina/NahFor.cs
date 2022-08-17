using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class NahFor
    {
        // Program načte N desetinných čísel - program to zajistí.
        // Pokud bude zadané nečíslo, program na to upozorní.
        // Program čísla vypíše a zobrazí jejich součet.

        public static void ukol1()
        {

            Console.Write("počet?: ");
            int pocet = int.Parse(Console.ReadLine());
            string vypis = "";
            float soucet = 0;
            for (int i = 1; i <= pocet; i++)
            {
                float cislo;
                bool testC1;


                do
                {
                    Console.WriteLine("Zadej číslo: ");
                    testC1 = float.TryParse(Console.ReadLine(), out cislo);

                    if (testC1) break;
                    Console.WriteLine("Chyba ve vstupu");
                } while (true);

                vypis = vypis + cislo + "; ";
                soucet += cislo; //soucet = soucet + cislo

            }
            vypis = vypis.Substring(0, vypis.Length - 2); //Odstraní 2 znaky od konce.. (první číslo, kde má začít(od konce) a další číslo kolik znaků
            Console.WriteLine("Vypis hodnot je: {0}", vypis);
            Console.WriteLine("Součet: {0}", soucet);
            Console.ReadLine();
        }

        //program načte N čísel - ošetřete kontrolu datového typu
        //poté nejprve vypíše kladná čísla, pak záporná a potom 0
        //použijte cyklus for

        public static void ukol2()
        {
            string kladna = "", zaporna = "", nulova = "";
            Console.Write("počet?: ");
            int pocet = int.Parse(Console.ReadLine());
            for (int i = 1; i <= pocet; i++)
            {
                float cislo;
                bool testC1;


                do
                {
                    Console.WriteLine("Zadej číslo: ");
                    testC1 = float.TryParse(Console.ReadLine(), out cislo);

                    if (testC1) break;
                    Console.WriteLine("Chyba ve vstupu");
                } while (true);

                if (cislo > 0)
                {
                    kladna = kladna + cislo + "; ";
                }

                else if (cislo < 0)
                {
                    zaporna = zaporna + cislo + "; ";
                }
                else
                {
                    nulova = nulova + cislo + "; ";
                }

            }
            Console.WriteLine("Kladná: {0}\nZáporná: {1}\nNulové: {2}", kladna, zaporna, nulova);
            Console.ReadLine();
        }

        // Program se zeptá na počet, a poté výpiše "pyramidu" znaku (*)
        public static void ukol3()
        {

            Console.Write("počet?: ");
            int pocet = int.Parse(Console.ReadLine());
            for (int i = 1; i <= pocet; i++)
            {
                for (int i2 = 1; i2 <= i; i2++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = pocet - 1; i > 0; i--)
            {
                for (int i2 = 1; i2 <= i; i2++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            



        }

        //Program udělá 20 řádku s náhodným počtem * na každém řádku
        public static void ukol4()
        {
            Random nahodC = new Random();
            for (int pocet = 1; pocet <= 20; pocet++)
            {
                int nahC = nahodC.Next(1, 10);
                for (int i2 = 1; i2 <= nahC; i2++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadLine();
         }
        
        //Zadejte N čísel, program vrátí maximální aminimální hodnotu
        //1 varianta s for, 2 varianta s do

        public static void ukol5_1()
        {
            Console.Write("počet?: ");
            int pocet = int.Parse(Console.ReadLine());

            float max = -6546546565; //float.MaxValue;
            float min = 654654654; //float.MinValue;

            for (int i = 1; i <= pocet; i++)
            {
                Console.Write("Zadej číslo: ");
                float cislo = float.Parse(Console.ReadLine());

                if (max < cislo)
                {
                    max = cislo; 
                }

                if (min > cislo)
                {
                    min = cislo;
                }

            }
            Console.WriteLine("Maximální hodnota: {0}\nMinimální hodnota: {1}",max, min);
            Console.ReadLine();


        }

        public static void ukol5_2()
        {
            Console.Write("počet?: ");
            int pocet = int.Parse(Console.ReadLine());
            int pocet2 = 0;

            float max = -6546546565; //float.MaxValue;
            float min = 654654654; //float.MinValue;

            do
            {
                Console.Write("Zadej číslo: ");
                float cislo = float.Parse(Console.ReadLine());

                if (max < cislo)
                {
                    max = cislo; 
                }

                if (min > cislo)
                {
                    min = cislo;
                }

                pocet2 = pocet2+1;

            }while(pocet > pocet2 );
            Console.WriteLine("Maximální hodnota: {0}\nMinimální hodnota: {1}",max, min);
            Console.ReadLine();
        }
        public static void ukol6()
        {
            Random generovaniCisla = new Random();

            int cislo = generovaniCisla.Next(1, 101);

            do
            {

                Console.WriteLine("Jaký je tvůj tip na tajné číslo od 1 do 100: ");
                float tip = float.Parse(Console.ReadLine());

                if (tip > cislo)
                {
                    Console.WriteLine("Tvůj tip je větší než tajné číslo!! Zkus menší!");
                    Console.ReadLine();
                }

                else if (tip < cislo)
                {
                    Console.WriteLine("Tvůj tip je menší než tajné číslo!! Zkus větší!");
                    Console.ReadLine();
                }

                else if (tip == cislo)
                {
                    Console.WriteLine("Gratuluji, uhádnul si číslo!");
                    Console.ReadLine();
                    break;
                }

                else
                {
                    Console.WriteLine("Chyba!! Asi špatná hodnota tvého tipu.. Napiš číslo!");
                    Console.ReadLine();
                }
               

                

            } while (true);
            Console.ReadLine();
        }
        //Program bude načítat název zboží a jeho cenu
        // Nejprve se zeptá na počet položek
        //Probram vypíše zadané hodnoty, každý záznam na novém řádku
        //Dále vypíše počet položek a průměrnou cenu

        public static void ukol7()
        {
            Console.Write("počet?: ");
            int pocet = int.Parse(Console.ReadLine());

            string tisk = "";
            float prum = 0;
            float soucet = 0;

            for (int i = 1; i <= pocet; i++)

            {
                Console.Write("\nZadej název zboží č.{0}: ",i);
                string nazev = Console.ReadLine();
                Console.WriteLine("Jeho cena: ");
                float cena = float.Parse(Console.ReadLine());

                tisk = tisk + nazev + " " + cena + "\n";
                

                soucet= soucet + cena;
                prum= soucet / pocet;

            }
            Console.WriteLine("\n\n**********Výpis*********");
            Console.WriteLine(tisk);
            Console.WriteLine("Počet záznamů: {0}\nPrůměrná cena: {1}", pocet, prum);
            Console.ReadLine();


        }

    }
}

