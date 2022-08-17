using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Class1
    {
        //Metoda nate dvě čísla. Pro danou dvojici čísel x,y spočírá hodnotu výrazu 1/(x.y).
        //Ošetřete nepovolené kombinace čísel (jmenovatel nesmí být nula)-

        public static void vyraz()
        {
            Console.WriteLine("Zadej x: ");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej y: ");
            float y = float.Parse(Console.ReadLine());
            if (x == 0 || y == 0)
            {
                Console.WriteLine("Zadel jsi špatné číslo, nula nejde kámo");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Tvé číslo je: " + (x = (1 / (x * y))));
                Console.ReadKey();
            }
        }
        
       
            
            
        public static void vyraz2()
        {
        Console.WriteLine("Zadej x: ");
        float x=float.Parse(Console.ReadLine());
        if (x<0 && x>100)
        {
        Console.WriteLine("Hodnota x leží mimo interval");
        Console.ReadKey();
        }
        else 
        {
        Console.WriteLine("Číslo x leží v intervalu.");
        Console.ReadKey();
        }






        }
        
        
        
        
        
        }
            
        
    }

