using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _24._1._2018
{
    class uvod
    {

        public static void pozdrav()
        {
            Console.WriteLine("Ahoj");
            Console.ReadLine();        
        }

        public static void soucet1()
        {
            Console.Write("Zadej první číslo: ");
            float c1 = float.Parse(Console.ReadLine());

            Console.Write("Zadej druhé číslo: ");
            float c2 = float.Parse(Console.ReadLine());

            // Console.WriteLine("Součet: "+(c1 + c2));
            Console.WriteLine("{0}+{1}={2}", c1, c2, (c1 + c2) );
            Console.ReadLine();


       
        
        }
        // Udělej průměr dvou čísel
        public static void prumer()
        {
            Console.Write("Zadej první číslo: ");
            float c1 = float.Parse(Console.ReadLine());

            Console.Write("Zadej druhé číslo: ");
            float c2 = float.Parse(Console.ReadLine());
            

            
            Console.WriteLine((c1 + c2) / 2);
            Console.ReadLine();// Program čeká dokud není ENTER, pak se konzole ukončí




        }
        public static float prumer2()
        {
            Console.Write("Zadej první číslo: ");
            float c1 = float.Parse(Console.ReadLine());

            Console.Write("Zadej druhé číslo: ");
            float c2 = float.Parse(Console.ReadLine());



            return (c1 + c2) / 2;
            




        }
        public static float prumer3(float c1, float c2)
        {
            return (c1 + c2) / 2;


        }

        public static float trojuhelnik(float c1, float c2, float c3)
        {
            return (c1 + c2 + c3);



        }
        public static string trojuhelnik1(float c1, float c2, float c3)
        {
            return ("Obvod: " + (c1 + c2 + c3));



        }
        public static void trojuhelnik2()
        {
            Console.Write("Zadej první číslo: ");
            float c1 = float.Parse(Console.ReadLine());

            Console.Write("Zadej druhé číslo: ");
            float c2 = float.Parse(Console.ReadLine());

            Console.Write("Zadej třetí číslo: ");
            float c3 = float.Parse(Console.ReadLine());

            // Console.WriteLine("Součet: "+(c1 + c2));
            Console.WriteLine("Obvod trojúhelníku:\na:{0}cm\nb:{1}cm\nc:{2}cm\nObvod:{3}cm", c1, c2, c3, (c1 + c2 + c3));
            Console.ReadLine();




        }


















    }
}
