using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej první číslo: ");
            string s= Console.ReadLine();
            Console.WriteLine("Zadej druhé číslo: ");
            string c = Console.ReadLine();
            int a = int.Parse(s);
            int b = int.Parse(c);
            int d = a + b;
            Console.WriteLine("Průměr: " + d / 2);
            Console.ReadKey();


           
       
        
        
        
        
        
        }
    }
}
