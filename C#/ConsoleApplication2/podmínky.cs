using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class podmínky
    {

        public static void kladnezaporne()
        {
            Console.WriteLine("Zadej číslo: ");
            float a = float.Parse(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("Číslo je kladné ");
                Console.ReadKey();
            }

            else if (a == 0)
            {
                Console.WriteLine("Číslo je 0.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Číslo je menší než 0.");
                Console.ReadKey();
            }

       }


        public static void podminka()
        {
           
            {
                Console.WriteLine("Zadejte první číslo:");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("Zadejte druhé číslo:");
                float b = float.Parse(Console.ReadLine());
                Console.WriteLine("1.scitani, 2.odcitani, 3.nasobeni, 4.deleni");
                int volba = int.Parse(Console.ReadLine());
                float vysledek = 0;
                if (b == 0)
                    Console.WriteLine("Tuto operaci nelze uskutečnit.");
                if (volba == 1)
                    vysledek = a + b;
                else if (volba == 2)
                vysledek = a - b;   
                else if (volba == 3)        
                vysledek = a * b;    
                else if (volba == 4)        
                vysledek = a / b;           
                Console.WriteLine("Výsledek: {0}", vysledek);
                Console.ReadKey();       
                            
                                
                    

            }
        }
          
            
        







      
    }
}

