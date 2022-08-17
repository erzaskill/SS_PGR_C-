using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class testt
    {
        public static void test1()
        {




            do
            {


                Console.Write("počet?: ");
                int pocet = int.Parse(Console.ReadLine());

                int[] cislaPole = new int[pocet];

                int dolniHranice = -100;
                int horniHranice = 100;

                Random generovaniCisla = new Random();

                for (int i = 0; i < cislaPole.Length; i++)
                    cislaPole[i] = generovaniCisla.Next(dolniHranice, horniHranice + 1);

                int[] cislaPoleSerazene = new int[pocet];
                Array.Copy(cislaPole, cislaPoleSerazene, pocet);

                int[] cislaPoleNove = new int[pocet];
                for (int i = 0; i < cislaPoleNove.Length; i++)
                    cislaPoleNove[i] = generovaniCisla.Next(dolniHranice, horniHranice + 1);




                string volba = "";

                do
                {
                    Console.WriteLine("vyber svou volbu: 1= výpis čísel(neseřazených, 2=výpis nadprůměrných hodnot seřazených sestupně, 3=výpis max,min ,průměr, 4=Vygenerování nových hodnot, 5=konec");
                    volba = Console.ReadLine();

                    if (volba == "1")
                    {
                        foreach (int x in cislaPole)
                            Console.WriteLine(x);
                    }



                    else if (volba == "2")
                    {
                        Array.Sort(cislaPoleSerazene);
                        Array.Reverse(cislaPoleSerazene);
                        for (int i = 0; i < cislaPoleSerazene.Lenght; i++)
                        {
                            if (cislaPoleSerazene[i] > cislaPoleSerazene.Average()) { Console.WriteLine(cislaPoleSerazene[i]); }
                        }
                    }
                    else if (volba == "3")
                    {
                        Console.WriteLine("Průměrná hodnota: " + cislaPole.Average());
                        Console.WriteLine("Min: " + cislaPole.Min());
                        Console.WriteLine("Max: " + cislaPole.Max());

                    }
                    else if (volba == "4")
                    {
                        break;
                    }
                    else if (volba == "5")
                    {
                        Console.WriteLine("konec");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Nevybral sis z volby!");
                    }



                } while (true);

                if (volba == "5")
                {
                    break;
                }

            } while (true);







        }
        
        
    }

}
