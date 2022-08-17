using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class uvod2
    {
        public static void scitani()
        {
            double c1;
            Console.WriteLine(" Zadej a: ");
            bool testC1 = double.TryParse(Console.ReadLine(),out c1);

            double c2;
            Console.WriteLine(" Zadej b: ");
            bool testC2 = double.TryParse(Console.ReadLine(),out c2);

            if(testC1==true && testC2 == true) Console.WriteLine(c1 + c2);
            else Console.WriteLine("chyba ve vstupu");
            Console.ReadLine();


        }

        //vytvořte variantu, pokud zadáte nečíselnou hodnotu, oznámí chybu a znovu zeptá

        public static void priklad()
        {
            double c1;
            double c2;
            bool testC1;
            bool testC2;

            do
            {

                Console.WriteLine(" Zadej a: ");
                testC1 = double.TryParse(Console.ReadLine(), out c1);

            
                Console.WriteLine(" Zadej b: ");
                testC2 = double.TryParse(Console.ReadLine(), out c2);

                if (testC1 && testC2) break;
                Console.WriteLine("Chyba ve vstupu");
            } while (true);

            Console.WriteLine(c1 + c2);
            Console.ReadLine();
        

        
        }

        public static double priklad2()
        {
            double c1;
            double c2;
            bool testC1;
            bool testC2;

            do
            {

                Console.WriteLine("\nZadej a: ");
                testC1 = double.TryParse(Console.ReadLine(), out c1);


                Console.WriteLine("\nZadej b: ");
                testC2 = double.TryParse(Console.ReadLine(), out c2);

                if (testC1 && testC2) break;
                Console.WriteLine("Chyba ve vstupu");
            } while (true);

            return(c1 + c2);
        }

        public static void pocitani()
        {
            do
            {
                Console.WriteLine("\n"+ priklad2());
                
                Console.WriteLine("pokračovat - a");
            }while(Console.ReadKey().KeyChar == 'a');

        }



        //********************************************metoda s parametry, vracející hodnotu**********************************************

        public static double souc(double c1, double c2)
        { return c1 + c2; }
        public static double dele(double c1, double c2)
        { return c1 / c2; }
        public static double nas(double c1, double c2)
        { return c1 * c2; }
        public static double min(double c1, double c2)
        { return c1 - c2; }

        public static void kalkulacka()
        {
            double c1;
            double c2;
            bool testC1;
            bool testC2;

            do
            {

                Console.WriteLine("\nZadej a: ");
                testC1 = double.TryParse(Console.ReadLine(), out c1);


                Console.WriteLine("\nZadej b: ");
                testC2 = double.TryParse(Console.ReadLine(), out c2);

                if (testC1 && testC2) break;
                Console.WriteLine("Chyba ve vstupu");

                char volba = Console.ReadKey().KeyChar;
                if (volba == '+')
                    Console.WriteLine(souc(c1, c2));
                else if (volba == '-')
                    Console.WriteLine(min(c1, c2));
                else if (volba == '*')
                    Console.WriteLine(nas(c1, c2));
                else if (volba == '/')
                    Console.WriteLine(dele(c1, c2));
                else
                    Console.WriteLine("špatná volba");
            } while (true);

            Console.ReadLine();
        }

        //program načte hodnotu, poté hodnotu zobrazí a vypíše
        //zda se jedná o číslo nebo text
        //zeptá se jestli má pokračovat
        public static void pejsek()
        {
            int pocetC = 0;
            int pocetT = 0;
            double cislo;
            do{
                Console.Write("\nZadej hodnotu");
                string hodnota = Console.ReadLine();
                if (double.TryParse(hodnota, out cislo))
                {
                    pocetC++;
                    Console.WriteLine("{0} je to číslo",hodnota);
                }
                else
                {
                    pocetT++;
                    Console.WriteLine("{0} je to text",hodnota);
                }
                Console.WriteLine("\na - pokračovat v načítání?");
            } while (Console.ReadKey().KeyChar == 'a');
            Console.WriteLine("Čísel: {0}", pocetC);
            Console.WriteLine("Text {0}", pocetT);
            Console.ReadLine();
        
        }

        //program načítá čísla, program testuje zda se jedná o číslo, pokud nebylo zadáno číslo, program se opět zeptá
        //po zadání číslo 0 se načítání ukončí, poté program zobrazí kladné hodnoty a jejich průměr
        //následně program zo´brazí zadané záporné hodnoty a jejich průměr

        public static void kocicka()
        {
            string tiskK = "";
            string tiskZ = "";
            int pocetK = 0;
            int pocetZ = 0;
            double soucetK = 0;
            double soucetZ = 0;
            double cislo = 0;
            do
            {
                while (true)
                {
                    Console.WriteLine("Zadej číslo");
                    if (double.TryParse(Console.ReadLine(), out cislo)) break;
                    Console.WriteLine("\nNezadal jsi číslo!!!");
                }

                if (cislo > 0)
                {
                    tiskK = tiskK + cislo + ";";
                    pocetK++;
                    soucetK = soucetK + cislo;
                }
                else if (cislo < 0)
                {
                    tiskZ = tiskZ + cislo + ";";
                    pocetZ++;
                    soucetZ = soucetZ + cislo;

                }
            } while (cislo != 0);
            Console.WriteLine("Výpis kladných čísel:\n{0}\nPrůměr:{1}", tiskK,soucetK /pocetK);
            Console.WriteLine("Výpis záporných čísel:\n{0}\nPrůměr:{1}", tiskK,soucetZ /pocetZ);
            Console.ReadLine();

       }
    }
}




        


    

