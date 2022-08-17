using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12._02._2018
{
    class doucko
    {
        // Zeptá se na teplotu.. Zádáme ji, když je menší teplota než 0 mrzne, jinak nemrzne..
        public static void teplota()
        {
            Console.WriteLine("Zadej teplotu: ");
            float teplota = float.Parse(Console.ReadLine());
            if (teplota < 0)
                Console.WriteLine("Teplota je: {0}, nemrzne", teplota);


        }
        //metoda bude mít v parametru 2 čísla, vrátí maximální hodnotu
        public static float maximum(float a1, float a2)
        {
            if (a1 > a2)
            {
                return (a1);
            }
            else
            {
                return (a2);
            }

        }
        public static float prumer(float a1, float a2, float a3)
        {
            return ((a1 + a2 + a3) / 3);

        }
        //metoda pololetí
        //metoda bude mít parametr - číslo měsíce
        //metoda vrátí zda se jedná o první, nebo druhé pololetí
        //&& - znamená "A zárověň"
        public static string pololeti(float mesic)
        {
            if (mesic < 7 && mesic > 0)
            {
                return ("První pololetí");
            }
            else if (mesic < 13 && mesic >0)
            {
                return("Druhé pololetí");
            }
            else
            {
                return("Napsal si chybný měsíc(>12 nebo <0)");
            }
        }



    }
}
