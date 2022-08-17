using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21._03._2018
{
    class opakovani
    {
        // Vytvořte program který se zeptá na počet čísel
        // Čísla načte a zobrazí jejich průměr, dále první zadané číslo a
        // Poslední zadané číslo
        public static void cyklus()
        {

            Console.WriteLine("Kolik čísel mám vypsat? ");
            int pocet = int.Parse(Console.ReadLine());

            float soucet = 0;
            float prvni = 0;
            float posledni = 0;
            int i = 1; //pocet opakovani


            while (i <= pocet)
            {
                Console.WriteLine("Zadej číslo");
                float cislo = float.Parse(Console.ReadLine());
                soucet = soucet + cislo;
                if (i == 1)
                    prvni = cislo;
                if (i == pocet)
                    posledni = cislo;
                i++;
            }
            Console.WriteLine("Průměrná hodnota {0}", soucet / pocet);
            Console.WriteLine("První č. {0}, poslední č. {1}", prvni, posledni);
            Console.ReadLine();
        }
        // Vytvořte program který se zeptá na počet čísel
        // Čísla načte a zobrazí jejich průměr, dále první zadané číslo a
        // Poslední zadané číslo
        public static void cyklus1()
        {

            Console.WriteLine("Kolik čísel mám vypsat? ");
            int pocet = int.Parse(Console.ReadLine());
            Random nahodne = new Random(); //vytvoříme objekt nahodne, který umí generovat náhodné čísla..

            float soucet = 0;
            string tisk = " ";
            int radek = 0;
            int i = 1; //pocet opakovani
            string kladne = " ";
            float max = float.MinValue;

            while (i <= pocet)
            {

                float cislo = nahodne.Next(-100, 101);
                soucet = soucet + cislo;


                radek++; // tohle je nejdůležitější
                tisk = tisk + cislo + "; ";
                if (radek == 10)
                {
                    tisk = tisk + "\n";
                    radek = 0;
                }
                if (cislo > 0)
                    kladne = kladne + cislo + "; ";
                if (cislo > max)
                    max = cislo;
                i++;

            }
            Console.WriteLine("Hodnoty: {0}", tisk);
            Console.WriteLine("Průměrná hodnota {0}", soucet / pocet);
            Console.WriteLine("Výpis kladných hodnot: {0}", kladne);
            Console.WriteLine("Maximální číslo: {0}", max);
            Console.ReadLine();
        }
        //Vytvořte program, který nabídne volby: 1. Obvod čtverce,
        //2. obvod obdelníku, 3. konec
        //Po zvolení 1 , nebo 2 se zeptá na strany, či stranu a
        //zobrazí výsledek, potom opět zobrazí volby..

        public static void Volba1()
        {
            string volba = "";
            float a = 0;
            float b = 0;
          
           
            do
            {
                Console.WriteLine("Možnosti volby: 1.Obvod čtverce, 2.Obvod obdelníku, 3.konec");
                volba = Console.ReadLine();
                if (volba == "1")
                {    Console.WriteLine("Strana a: ");
                     a = float.Parse(Console.ReadLine());
                
                Console.WriteLine("Obvod čtverce = {0}", 4*a);
                }

                else if (volba == "2")
                {
                    Console.WriteLine("Strana a: ");
                    a = float.Parse(Console.ReadLine());

                    Console.WriteLine("Strana b: ");
                    b = float.Parse(Console.ReadLine());

                    Console.WriteLine("Obvod obdelniku = {0}", 2*(a+b));
                }


                else if (volba == "3")
                    Console.WriteLine("Konec!!");

                else
                    Console.WriteLine("Napsal si špatně svou volbu");



            } while (volba != "3");
            Console.ReadLine();
        }
    }
}
