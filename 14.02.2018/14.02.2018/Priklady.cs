using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14._02._2018
{
    class Priklady
    //Metoda načte dvě čísla. Pro danouu dvojici čísel x,y spočítá hodnotu výrazu 1/(x.y).
    // Ošetřete nepovolené kombinace čísel (jmenovatel nesmí být nula).
    {
        public static void matVyraz()
        {
            Console.WriteLine("Zadej první číslo: ");
            float x= float.Parse(Console.ReadLine());

            Console.WriteLine("Zadej první číslo: ");
            float y= float.Parse(Console.ReadLine());

            if (x * y == 0)
            {
                Console.WriteLine("Jmenovatel nesmí být nula");
            }
            else
            {
                Console.WriteLine(1 / (x * y));
                Console.ReadLine();
            }

        }
    //Metoda načte x. Následně zjístí, zda číslo x leží uvnitř, před nebo za hranicí
    //intervalu <1,100>.
        public static void interval()
        {
            Console.WriteLine("Zadej číslo: ");
            float x = float.Parse(Console.ReadLine());

            if (x > 100)
                Console.WriteLine("x leží za hranici");

            else if (x < 1)
                Console.WriteLine("x leží před hranicí");
            else
                Console.WriteLine("x leží uvnitř hranice");

            

        }
    }
}
