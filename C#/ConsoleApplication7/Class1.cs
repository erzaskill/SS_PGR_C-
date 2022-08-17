using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Class1
    {
        public static void program()
        {
            Console.WriteLine("Zadej počet čísel:");
            int pocet = int.Parse(Console.ReadLine());
            Random nahodneC = new Random();
            string tisk = "";
            double soucet = 0;
            int novyradek = 0;
            string cislo2 = "";
            double max = double.MinValue;


            int i = 1;
            while (i <= pocet)
            {
                novyradek++;
                double cislo = nahodneC.Next(-100, 100);
                if (cislo > 0)
                {
                    cislo2 += cislo + "; ";
                }
                tisk += cislo + ";";
                if (novyradek == 10)
                {
                    tisk += "\n";
                    novyradek = 0;
                }
                if (cislo > max)
                {
                    max = cislo;
                }
                soucet += cislo;
                i++;



            }
            Console.WriteLine("Výpis: {0} ", tisk);
            Console.WriteLine("maximální hodnota: {0}", max);
            Console.WriteLine("Průměrná hodnota {0}", soucet / pocet);
            Console.WriteLine("Kladná čísla: {0}", cislo2);
            Console.ReadLine();
        }




        public static void program2()
        {
        int volba=0;
        double obvodctv =0;
        double obvodobd=0;
        while(volba!=3)
        int a;
        int b;
        {
        Console.WriteLine("1.obvod čtverce, 2.obvod obdelníku, 3.konec");
        volba=int.Parse(Console.ReadLine());
        }
         
        if (volba==1)
        {
        Console.WriteLine("Zadej a: ");
        a = int.Parse(Console.ReadLine());
        obvodctv = 4*a;
        }

        if (volba==2)
        {
        Console.WriteLine("Zadej a: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Zadej b: ");
        b = int.Parse(Console.ReadLine());
        obvodobd=2*(a+b);



        }



        

        
        }
    }
}