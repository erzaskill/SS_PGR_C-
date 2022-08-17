using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej c: ");
            int c = int.Parse(Console.ReadLine());
            int o= a + b + c;
            Console.WriteLine ("a:{0}\nb:{1}\nc:{2}\nobvod:{3} ",a,b,c,o);
            Console.ReadKey();
       }
    }
}
