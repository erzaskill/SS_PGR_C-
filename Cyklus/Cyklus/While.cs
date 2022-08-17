using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cyklus
{
    class While
    {
        // Program se zeptá na věk a vypíše cenu vstupenky.
        //vstupné 30 věk do 6
        //vstupné 80 věk od 7 do 18
        //vstupné 200 věk nad 18 do 70
        //vstupné 80 věk nad 70
        //pokud je věk mimo reálný interval pak to program oznámí

        //Python AND C# && Python or c# ||

        //Dej to do cyklu
        public static void vstupenky()
        
            
            

            {

                


                string volba="";
                while (volba != "1")
                {
                    int a;
                    Console.WriteLine("Kolik ti je?");
                    a = int.Parse(Console.ReadLine());


                    if (a > 0 && a < 7)

                        Console.WriteLine("Zaplať 30Kč!");

                    else if (a > 6 && a < 18)

                        Console.WriteLine("Zaplať 80Kč");

                    else if (a > 17 && a < 71)

                        Console.WriteLine("Zaplať 200Kč");

                    else if (a > 70 && a < 100)
                        Console.WriteLine("Zaplať 80Kč");

                    else
                        Console.WriteLine("Takový věk není reálný!");
                    Console.ReadLine();



                    Console.Write("1. konec");
                    volba = Console.ReadLine();
                }
    
        }
   
        
        // Program se zeptá na věk a vypíše cenu vstupenky.
        //vstupné 30 věk do 6
        //vstupné 80 věk od 7 do 18
        //vstupné 200 věk nad 18 do 70
        //vstupné 80 věk nad 70
        //pokud je věk mimo reálný interval pak to program oznámí

        //Python AND C# && Python or c# ||

        //Dej to do cyklu
        public static void vstupnky2()
        
            {

                string volba;
                
                do
                {
                    int a;
                    Console.WriteLine("Kolik ti je?");
                    a = int.Parse(Console.ReadLine());


                    if (a > 0 && a < 7)

                        Console.WriteLine("Zaplať 30Kč!");

                    else if (a > 6 && a < 18)

                        Console.WriteLine("Zaplať 80Kč");

                    else if (a > 17 && a < 71)

                        Console.WriteLine("Zaplať 200Kč");

                    else if (a > 70 && a < 100)
                        Console.WriteLine("Zaplať 80Kč");

                    else
                        Console.WriteLine("Takový věk není reálný!");
                    Console.ReadLine();



                    Console.Write("1. konec");
                    volba = Console.ReadLine();
                }while (volba != "1");
        }
        
    } 
    
}


