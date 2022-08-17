using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class soubory
    {
        public static void cteniZeSouboru()//načte celý soubor do stringu


            //string cesta = "C:\\Users\\jiri.arnost\\Documents\\text.txt";

        {
            string cesta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\text.txt"; //není to závislé na účtu na kterem jsme
            string t = File.ReadAllText(cesta);
            Console.WriteLine(t);
            Console.ReadLine();

        }

        //program vrátí počet znaků v textu, ale bez mezer.



        public static void cteniZeSouboruV1()
        {
            string cesta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\text.txt"; //není to závislé na účtu na kterem jsme
            string t = File.ReadAllText(cesta);
            Console.WriteLine(t);
            int pocetMezer = 0;
            foreach (char z in t)
                if (z == ' ') pocetMezer++;
            int pocet = t.Length - pocetMezer;
            Console.WriteLine("Počet znaků - bez mezer: " + pocet);
            Console.ReadLine();

        }

        //Program načte textový soubor, soubor zjístí pošet výskytů znaků "@"

        public static void cteniZeSouboru2()
        {
            string cesta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\text.txt"; //není to závislé na účtu na kterem jsme
            string t = File.ReadAllText(cesta);
            int pocet = 0;
            foreach (char znak in t)
            {
                if (znak == '@')
                {
                    pocet++;
                }
                Console.WriteLine(pocet);
                Console.ReadLine();
            }
        }



        //soubor hodím do pole a pole vytisknu = basicly - vypíše to ten soubor v poli
        public static void cteniZeSouboruDoPole()
        {
            string cesta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\text.txt";
            //načte a rozdělí soubor do pole soubor
            string[] soubor = File.ReadAllLines(cesta);

            foreach (string radek in soubor)
            {
                Console.WriteLine(radek);
            }
            Console.ReadLine();
        }
        //načte data ze souboru, a vypíše min. max. hodnotu

        public static void cteniZeSouboru3()
        {
            string cesta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\text2.txt";
            //ReadAllLines = když jde o pole
            string[] soubor = File.ReadAllLines(cesta);
            double[] cisla = new Double[soubor.Length];
            double cislo;
            int i = 0;



                foreach (string radek in soubor)
                {
                    if(double.TryParse(radek, out cislo) && string.IsNullOrWhiteSpace(radek))
                    {
                    cisla[i] = cislo;
                    i++;
                    }
                }



            //Výpis:
                Console.WriteLine("součet: {0}", cisla.Sum());
                Console.WriteLine("průměr: {0}", cisla.Average());
                Console.WriteLine("minimum: {0}", cisla.Min());
                Console.WriteLine("maximum: {0}", cisla.Max());
                Console.ReadLine();
            
        }



        public static void cteniZeSouboru4()
        {
            string cesta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\text3.txt";
            //ReadAllLines = když jde o pole
            string[] soubor = File.ReadAllLines(cesta);
            Console.Write("Zadej hledaný text: ");
            string hledany = Console.ReadLine();
            foreach (string radek in soubor)
                if (radek.Contains(hledany))
                { Console.WriteLine(radek); }
            Console.ReadLine();
 
        }
        
        public static void vypiscisel()                
        {
            string cesta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\cislicka.txt";
            string[] cislicka = File.ReadAllLines(cesta);
            long[] cisla = new long[cislicka.Length];
            int i = 0;
            long cislo;
            string nadprum = "";

            foreach (string radek in cislicka)
            {
                if (long.TryParse(radek, out cislo))   //pokud se jedná o císlo -> nacte se do double[]cisla; pokud ne, tak ne
                {
                    cisla[i] = long.Parse(radek);
                    i++;
                }
                else
                { i++; }
            }
            while (true)
            {
                long x;
                Console.Write("1 - výpis; 2 - výpis císel vzestupne; 3 - výpis nadprumerných hodnot; 4 - konec; je to na Tobe: ");
                if (!long.TryParse(Console.ReadLine(), out x))
                { break; }
                if (x == 1)
                {
                    for (int y = 0; y < cisla.Length; y++)
                    { Console.WriteLine(cisla[y]); }
                }
                else if (x == 2)
                {
                    long[] vzestupne = new long[cisla.Length];
                    Array.Copy(cisla, vzestupne, cisla.Length);
                    Array.Sort(vzestupne);
                    for (int y = 0; y < vzestupne.Length; y++)
                    { Console.WriteLine(vzestupne[y]); }
                }
                else if (x == 3)
                {
                    foreach (long lane in cisla)
                    {
                        if (lane > cisla.Average())
                        {
                            nadprum += lane + "\n";
                        }
                    }
                    Console.WriteLine(nadprum);
                }
                else if (x == 4)
                { break; }
                else
                { Console.WriteLine("Bacha!"); }
            }
            Console.ReadLine();
          }
        public static void pracesesouboryosetreni()
        {
            string cesta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\text.txt";
            double soucet = 0;
            string[] soubor = { };
            try
            {
                soubor = File.ReadAllLines(cesta);
            }
            catch
            {
                Console.WriteLine("Nenačetl se soubor");
                Console.ReadLine();
                return;//skok do Mainu
                //Environment.Exit(0);//Ukončení programu
            }
            foreach (string radek in soubor)
            {
                try
                {
                    soucet = soucet + double.Parse(radek);
                    Console.WriteLine(radek);

                }
                catch//pokud nastane chyba, program ji ignoruje
                { }
            }
            Console.WriteLine("Soucet: " + soucet);
            Console.ReadLine();
        }
        


    }


}
