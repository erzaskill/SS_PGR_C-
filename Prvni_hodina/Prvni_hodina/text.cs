using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class text
    {
        public static void string1()
        {

            Console.Write("Zadej text: ");

            string text = Console.ReadLine();
            do
            {
                int i;
                Console.Write("Číslo znaku: ");
                if (!int.TryParse(Console.ReadLine(), out i)) break;
                if (i > 0 && i <= text.Length)
                Console.WriteLine(text[i-1]);
            } while (true);

        }


        // VYPIŠTE NAOPAK POUŽITÉ FOR
        public static void opacnyvypis()
        {

            Console.Write("Zadej text: ");

            string text = Console.ReadLine();


            for (int i = text.Length; i > 0; i--)
                Console.Write(text[i - 1]);
            Console.ReadLine();
        }
        public static void opacnyvypisv2()
        {

            Console.Write("Zadej text: ");

            string text = Console.ReadLine();
            string text2 = "";
            for (int i = 0; i < text.Length; i++)
                text2 = text[i] + text2;
            Console.Write(text2);
            Console.ReadLine();

        }


        public static void zapis()
        {
            string t = "Dobrý den";
//**********************
            //Vrací True/False
   
            Console.WriteLine(t.StartsWith("Do")); //Začíná na Do
            Console.WriteLine(t.EndsWith("n")); //Končí n
            Console.WriteLine(t.Contains("a")); //Zda obsahuje daný znak/text
            Console.ReadLine();

//**************************************

            Console.WriteLine(t[0]); //Vypíše první znak

            Console.WriteLine(t.Length); //Délka
            Console.WriteLine(t[t.Length - 1]); //Vypíše poslední znak

            Console.WriteLine(t.ToUpper()); //Převede na velké písmo
            Console.WriteLine(t.ToLower()); //Převede na malé písmo
        }




        //Program načte jméno a příjmení, potom vrátí iniciály.
        //vstup: petr novak vystup: P.N.

        public static void inicialy()
        {
            Console.Write("Zadej jmeno: ");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadej příjmení: ");
            string prijmeni = Console.ReadLine();

            string inic = jmeno[0].ToString().ToUpper() + ".";
            inic = inic + prijmeni[0].ToString().ToUpper() + ".";

            Console.WriteLine(inic);
            Console.ReadLine();

        }

        //metoda která vrátí hodnotu

        public static string inicialyv2()
        {
            Console.Write("Zadej jmeno: ");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadej příjmení: ");
            string prijmeni = Console.ReadLine();

            string inic = jmeno[0].ToString().ToUpper() + ".";
            inic = inic + prijmeni[0].ToString().ToUpper() + ".";

            return (inic);

        }
        //Write = píše na jeden řádek, WriteLine = píše na řádek zvlášť


        public static void znakmezera()
        {
            Console.WriteLine("Zadej text: ");
            string text = Console.ReadLine();
            string text2 = "";

            foreach (char a in text)
                text2 = text2 + a + " ";
            Console.WriteLine(text2);
            Console.ReadLine();
        }


        //Je zadaný text mailovou adresou?
        // Podmínka: obsahuje @ a zároveň jim nezačíná ani nekončí.

        public static void hledanitextu()
        {
            Console.WriteLine("Zdar kámo, zadej prosím svůj mail: ");
            string text = Console.ReadLine();

            Console.WriteLine(text.Contains("@"));
            if (text.Contains("@"))
            {
                if (text.StartsWith("@") && (text.EndsWith("@")))
                {
                    Console.WriteLine("Tohle není EMAIL ZMRDE!");
                }
                else
                {
                    Console.WriteLine("Jedná se o email!");
                }
            }
            else
            {
                Console.WriteLine("Nejedná se o email, není tam zavinač = @");
            }



        }

       


            



    }
}
