using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class priprava_na_test_text
    {
        ///Program načte text
        ///Nejprve zobrazí číslice(char.IsNumber),
        ///Pak písmena (char.IsLetter)
        ///a poté ostatní znaky
        ///
        public static void priprava1()
        {

            string cislice = "";
            string pismeno = "";
            string ostatni = "";


            Console.WriteLine("Napiš nějaký text: ");
            string text = Console.ReadLine();

            foreach (char znak in text)
            {
                if (char.IsNumber(znak))
                {
                    cislice += znak.ToString();
                    
                }
                else if (char.IsLetter(znak))
                {
                    pismeno += znak.ToString();
                }

                else 
                {
                    ostatni += znak.ToString();

                }
                
            }
            Console.WriteLine(cislice);
            Console.WriteLine(pismeno);
            Console.WriteLine(ostatni);
            Console.ReadLine();

        }
        ///Načte text
        ///odstraní případné mezery před a za slovem -Trim
        ///pokud slovo začíná číslicí odstraní jí.
        ///takto upravené slovo zobrazí.
        ///" 1ss " "1ss"
        ///

        public static void priprava2()
        {
            Console.WriteLine("Zadej nějaký text: ");
            string text = Console.ReadLine().Trim();

            if (char.IsNumber(text[0]))
            {
                text = text.Substring(1);
            }
            Console.WriteLine(text);
            Console.ReadLine();
        }
        public static void priprava2v2()
        {
            Console.WriteLine("Zadej nějaký text: ");
            string text = Console.ReadLine().Trim();



            while (0 < text.Length && char.IsNumber(text[0]))
            {
                text = text.Substring(1);
            }
            Console.WriteLine(text);
            Console.WriteLine();
        }

        ///Program načte text
        ///vypíše znaky abecedně seřazené
        ///"".ToCharArray();
        ///Array.Sort(pole)
        ///"cba" "abc"

        public static void priprava3()
        {
            Console.WriteLine("Zadej text: ");
            string text = Console.ReadLine();

            char[] pole = text.ToCharArray();
            Array.Sort(pole);

            foreach (char znak in pole)
            {
                Console.WriteLine(znak);
            }
            //Console.WriteLine(pole);
            Console.ReadLine();



        }
    }
}
