using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class seznamy
    {
        public static void pole0()
        {
            int[] cislaPole = { 1, 2, 3, 4, 555 };

            for (int i = 0; i < cislaPole.Length; i++)
                Console.WriteLine(cislaPole[i]); //zobrazí obsah pole
            Console.ReadLine();

        }
        public static void pole1()
        {
            int[] cislaPole = new int[5]; //deklarace pole
            // načtení do pole
            for (int i = 0; i < cislaPole.Length; i++) 
            {
                Console.WriteLine("Zadej číslo: ");
                cislaPole[i] = int.Parse(Console.ReadLine());
            }
            //Průchod polem
            for (int i = 0; i < cislaPole.Length; i++)
                Console.WriteLine(cislaPole[i]); //vypis hodnot pole

            //Cyklus foreach - je pouze pro čtení, hodnoty se nemůžou měnit
            //foreach (int cislo in cislaPole)
                //Console.WriteLine(cislo);

            Console.WriteLine("Maximum: " + cislaPole.Max()); //zobrazí maximum
            Console.WriteLine("Minimum: " + cislaPole.Min()); //zobrazí minimum
            Console.WriteLine("Průměrná hodnota: " + cislaPole.Average()); //zobrazí průměr
            Console.ReadLine();
//Opačný výpis
        }

            //vygenerujte n čísel do pole
            //čísla vypište, dále zobrazte součet čísel


            public static void pr1()
            {
                int[] pole = new int[20];
                Random generovani = new Random();
                for (int i =0; i< pole.Length; i++)
                    pole[i] = generovani.Next(-1000, 1000);
                foreach (int c in pole) Console.WriteLine(c);
                Console.WriteLine("součet: {0}", pole.Sum());
                Console.ReadLine();
            }

            public static void povel2()
            {
                string[] dnyPole = { "po", "ut", "st", "čt", "pá", "so", "ne" };

                Random nahoda = new Random();

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(dnyPole[nahoda.Next(0, 7)]);
                }
            }

            public static void povel3()
            {
                Random nahoda = new Random();
                string[] den = { "po", "ut", "st", "čt", "pá", "so", "ne" };
                string[] mesic = { "leden", "unor", "březen", "duben", "květen", "červen", "červenec", "srpen", "září", "říjen", "listopad", "prosinec" };

                for (int i = 1; i < 10; i++)
                {
                    int cislo = nahoda.Next(0, 12);
                    int cislo2 = nahoda.Next(0, 7);
                    if (cislo2 >= 5 && cislo2 <= 6)
                        Console.WriteLine("!!! {0} {1} !!!", mesic[cislo], den[cislo2]);
                    else
                        Console.WriteLine("{0} {1}", mesic[cislo], den[cislo2]);

                }
                Console.ReadLine();
            }
            public static void neco()
            {
                int dolniHranice = 1;
                int horniHranice = 100;
                Random generovaniCisla = new Random();//Vytvoření generátoru
                Console.WriteLine("Zadej počet čísel");
                int pocet = int.Parse(Console.ReadLine());

                int[] pole = new int[pocet]; //Vytvoření pole

                for (int i = 0; i < pocet; i++) //Načtení do pole
                {
                    pole[i] = generovaniCisla.Next(dolniHranice, horniHranice + 1); // generovani čisel do pole
                }
                Console.WriteLine("Výpis: ");//Výpis hodnot prvků pole
                for (int i = 0; i < pole.Length; i++)
                    Console.WriteLine(pole[i]);
                Console.WriteLine("Průměrná hodnota: " + pole.Average());
                Console.WriteLine("Min: " + pole.Min());
                Array.Sort(pole);//Řazení pole vzestupně
                Console.WriteLine("\n\nSeřazené pole vzestupně: ");
                for (int i = 0; i < pole.Length; i++)
                    Console.WriteLine(pole[i]);

                Console.WriteLine("\n\nSeřazené pole sestupně: ");
                Array.Reverse(pole); //prvky pole se seřadí opačně
                for (int i = 0; i < pole.Length; i++)
                    Console.WriteLine(pole[i]);
                Console.ReadLine();
                
            }
        // Array.Copy(pole_povodní, pole_kopie, pocet_prvků_Z_původního pole);

        //Vytvořte program, který vygeneruje n čísel
        //Dále nabídne možnosti
        //1.Vypsat v původním pořadí 2.Seřazeno vzestupně 3.Sestupně
        //4.konec.

            public static void kopie()
            {
                int dolniHranice = 1;
                int horniHranice = 100;
                Random generovaniCisla = new Random();//Vytvoření generátoru

                Console.WriteLine("Počet čísel v poli");
                int n = int.Parse(Console.ReadLine());
                int[] cislaPole = new int[n];

                for (int i = 0; i < cislaPole.Length; i++) //naplnění pole hodnotami
                    cislaPole[i] = generovaniCisla.Next(dolniHranice, horniHranice + 1);
 
                int[] cislaPoleSerazene = new int[n];
                Array.Copy(cislaPole, cislaPoleSerazene, n); //vytvoření kopie

                string volba = "";

                do
                {
                    Console.WriteLine("1.Původní, 2.Vzestupně, 3.Sestupně, 4.Konec");
                    volba = Console.ReadLine();
                    Console.Clear(); //vymaže obrazovku
                    if (volba == "1") // vypis neseřazeného pole
                    {
                        foreach (int a in cislaPole)
                            Console.Write(a + "; ");
                    }
                    else if (volba == "2") // výpis seřazený vzestupně
                    {
                        Array.Sort(cislaPoleSerazene);
                        foreach (int a in cislaPoleSerazene)
                            Console.Write(a + "; ");

                    }
                    else if (volba == "3") //výpis seřazený sestupně
                    {
                        Array.Sort(cislaPoleSerazene);
                        Array.Reverse(cislaPoleSerazene);
                        foreach (int a in cislaPoleSerazene)
                            Console.Write(a + "; ");

                    }
                    Console.WriteLine("\n\n");

                } while (volba != "4");


            }
            public static void naleziMnozineCisel()
            // metoda pole.Contains(hledany prvek)
            //vrátí True pokud pole obsahuje hledaný prvek


            {
                double[] mnozina = { 1, 356, 35.1, 36.2, 3, 7 };

                Console.WriteLine("Zadej číslo: ");
                double cislo = double.Parse(Console.ReadLine());

                if (mnozina.Contains(cislo))
                    Console.WriteLine("Cislo patří do zvolené množiny! ");
                else
                    Console.WriteLine("Cislo nepatří do zvolené množiny! ");
                Console.ReadLine();
            }


        //Firma má pobočky v osmi městech (Určete sami - hodnoty pole).
        //Vytvořte metodu, která se zeptá na město a vypíše
        //zda v daném městě je pobočka.
        //Města zadejte do pole a použijte metodu Contains

            public static void pobocky()

            {
                string[] mnozina = { "Praha", "Ostrava", "Brno", "Odry" };

                string volba = "";
                do
                {
                    


                    Console.WriteLine("Zadej město pobočky: ");
                    string mesto = Console.ReadLine().ToLower(); //ToLower() převede na malé písmeno

                    if (mnozina.Contains(mesto))
                        Console.WriteLine("V tomhle městě je naše pobočka! ");
                    else
                        Console.WriteLine("V tomhle městě není naše pobočka! ");
                    Console.ReadLine();

                    Console.WriteLine("konec = 1, Pokračuj");
                    volba = Console.ReadLine();

                    

                } while (volba != "1");
                
            }


        //Porgram se zeptá zda chcete pobočky vypsat, pokud ano vypíše je a to seřazeně vzestupně
            public static void pobocky2()
            {
                string[] mnozina = { "Praha", "Ostrava", "Brno", "Odry" };

                string volba = "";
                do
                {



                    Console.WriteLine("Zadej město pobočky: ");
                    string mesto = Console.ReadLine().ToLower(); //ToLower() převede na malé písmeno

                    if (mnozina.Contains(mesto))
                        Console.WriteLine("V tomhle městě je naše pobočka! ");
                    else
                        Console.WriteLine("V tomhle městě není naše pobočka! ");
                    Console.ReadLine();

                    Console.WriteLine("konec = 1, 2= výpis poboček, Pokračuj");
                    volba = Console.ReadLine();

                    if (volba == "2")
                    {
                        Array.Sort(mnozina);
                        foreach (string a in mnozina)
                            Console.Write(a + "; ");
                        Console.WriteLine("\n\n");

                        break;
                    }



                } while (volba != "1");

            }
        //Podle názvu měsíce zjistí zda jde o první, nebo druhé pololetí
        //metoda pole.Contains("Hledaná hodnota") vratí True pokud obsahuje



        }
    }


