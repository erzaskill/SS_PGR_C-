using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nove_metody
{
    class metodycs
    {
        public static void nove()
        {
            string t = "dobry den";
            string t2 = t.Replace("dobry", "krasny");

            Console.WriteLine("     asd    ".Trim());

            Console.WriteLine("      a".TrimStart());

            Console.WriteLine("a     ".TrimEnd());


        }

        //Načte text
        //Odstraní mezery před a
        public static void ukol1()
        {
            string t = "a b c";
            string t2 = t.Replace(" ", "_");

            Console.WriteLine(t2.TrimStart());

            Console.WriteLine(t2.TrimEnd());

            Console.ReadLine();

            //string t2 = text.Trim().Replace(" ","_");





        }

        // uprava predchozi

        //metoda vraci hodnotu, text dostava parametrem



        public static string ukol1_v2(string t)
        {
            string t2 = t.Trim().Replace(" ","_");
            return t2;
            
        }
        

        public static void nove2()
        {
            string t = "CHLEBICEK";
            //substring
            //Vrátí všechny znaky od druhé pozice
            Console.WriteLine(t.Substring(1));

            //vrátí 3 znaky od pozice druhé pozice
            //"abcdefg".Substring(1, 3) ="bcd"
            Console.WriteLine(t.Substring(1, 3));
            


            //IndexOf
            //na které pozici řetězce t
            //se vyskytuje "D", rozeznává velká a malá písmena
            Console.WriteLine(t.IndexOf("D"));
            //"abcdefg".IndexOf("d")=3
        }



        //zadaní:
        //zadej text s mezerou, vypíše to dvě slovo zvlášť
        public static void ukol2()
        {
            Console.WriteLine("Dvě slova oddělena mezerou"); //začíná
            string text = Console.ReadLine();

            if (text.Contains(" "))
            {
                Console.WriteLine(text.Substring(0, text.IndexOf(" ")));//před mezerou
                Console.Write(text.Substring(text.IndexOf(" ") + 1));//za mezerou
            }
            else 
            {
                Console.WriteLine("Text neobsahuje mezeru.");
            }
            Console.Read();
 
        }


        //prvbá písmeno velké ostatní malé
        //vLasta  Vlasta

        public static void ukol3()
        {
            Console.WriteLine("Zadej text:");
            string text = Console.ReadLine();

            text = text[0].ToString().ToUpper() + text.Substring(1).ToLower();

            Console.WriteLine(text);
            Console.ReadLine();
           
        }


        //"Petr.Novak@Cez.cz"
        //Vemte z toho jmeno a na další řádek příjmení

        public static void ukol4()
        {
            Console.WriteLine("Zadejte svůj email: ");
            string t = Console.ReadLine();

            string jmeno;
            jmeno = "jmeno: " + (t.Substring(0, t.IndexOf(".")));//před mezerou

            int pocetZnaku =  t.IndexOf("@") - t.IndexOf(".");

            string prijmeni;
            prijmeni = "příjmení: " + t.Substring(t.IndexOf(".") + 1, pocetZnaku - 1);

            Console.WriteLine(jmeno);
            Console.WriteLine(prijmeni);
            



            Console.ReadLine();




        }
        /// Máme udaje v tomto formátu: jmeno + mezera + prijmeni např. "Marek Novák"
        /// program načte tento údaj a vrátí příjmení


        public static void ukol5()
        {
            Console.WriteLine("Napiš jméno a příjmení: ");
            string t = Console.ReadLine();

            string prijmeni;
            prijmeni = "Příjmení: " + (t.Substring( t.IndexOf(" ") + 1));

            Console.WriteLine(prijmeni);
            Console.ReadLine();

        }


        
    }
}
