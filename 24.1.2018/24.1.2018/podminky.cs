using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _24._1._2018
{
    class podminky
    {
        public static void kladne()
        {
            Console.WriteLine("Zadej číslo: ");
            float x = float.Parse(Console.ReadLine());

            if (x > 0) //musí tu být závorky!!
            {//V Pythonu se odsazovalo, tady stačí závorky
                Console.WriteLine("Kladné číslo");
                Console.ReadLine();
            
            }
            else if (x == 0)
            {//V Pythonu se odsazovalo, tady stačí závorky
                Console.WriteLine("Nula!");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Záporné číslo");
                Console.ReadLine();

            }

        }
        //program načte 2 čísla
        //následně zobrazí: 1. součet, 2.rozdíl,3.součin, 4.podíl


        public static void kalkulacka()
        {
            Console.WriteLine("Zadej první číslo: ");
            float x1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Zadej druhý číslo: ");
            float x2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Zadej svou volbu: 1=součet, 2=rozdíl,3=součin, 4=podíl");
            string volba = Console.ReadLine();
            
            if (volba=="1")
            {
                Console.WriteLine(x1+x2);
                Console.ReadLine();

            }
            else if (volba=="2")
            {
                Console.WriteLine(x1-x2);
                Console.ReadLine();

            }
            else if (volba=="3")
            {
                Console.WriteLine(x1*x2);
                Console.ReadLine();

            }
            else if (volba == "4")
            {
                if (x2 !=0)
                Console.WriteLine(x1 / x2);
               
                else
                Console.WriteLine("Nulou dělit nelze!!!");
                Console.ReadLine();


            }
            else
            {
                Console.WriteLine("Napsal si špatně svou volbu!!!");
                Console.ReadLine();
            }

        }
    }
}
