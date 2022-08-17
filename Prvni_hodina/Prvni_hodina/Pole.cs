using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Pole
    {
        static int[] cislaPole = new int[10];

        public static void nacteni()
        {
            int dolniHranice = 1;
            int horniHranice = 100;
            Random generovaniCisla = new Random();

            for (int i = 0; i < cislaPole.Length; i++)
                cislaPole[i] = generovaniCisla.Next(dolniHranice, horniHranice + 1); //
        }
        public static void vypis1()
        {
            foreach (int x in cislaPole)
                Console.WriteLine(x);
        }


        public static void vypisVzestupne()
        {
            int[] cislaPole2 = new int[cislaPole.Length];
            Array.Copy(cislaPole, cislaPole2, cislaPole.Length);
            Array.Sort(cislaPole2);

            foreach (int x in cislaPole2)
                Console.WriteLine(x);

        }
        public static void vypisSestupne()
        {
            int[] cislaPole2 = new int[cislaPole.Length];
            Array.Copy(cislaPole, cislaPole2, cislaPole.Length);
            Array.Sort(cislaPole2);
            Array.Reverse(cislaPole2);

            foreach (int x in cislaPole2)
                Console.WriteLine(x);





        }
        public static void hlavniPole()
        {
            nacteni();
            vypis1();
            Console.WriteLine("\n\n");
            vypisVzestupne();
            Console.WriteLine("\n\n");
            vypisSestupne();
            Console.ReadLine();


        }

        
    }
}
