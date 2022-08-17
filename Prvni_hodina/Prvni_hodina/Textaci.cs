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
                    Console.WriteLine(text[i - 1]);
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
                if (text.StartsWith("@") || (text.EndsWith("@")))
                {
                    Console.WriteLine("Tohle není EMAIL!");
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


        
            //upravte předchozí metodu tak,
            //aby vracela hodnotu, a text dostala parametru


        }
        public static bool hledanitextuv2(string text)
        {
            if (!text.Contains("@") || text.StartsWith("@") || text.EndsWith("@"))
                return false;
            else
                return true;
            
 
        }

        //Zadejte text, metoda vypíše text následovně
        // Na každém řádku 1 znak
        //abcd
        //a
        //b
        //c

        public static void podsebou()
        {
            Console.WriteLine("Zdar kámo, zadej prosím nějaký text: ");
            string text = Console.ReadLine();

            Console.WriteLine(text + "\n");

            //vypíše pod sebe v původním pořadí:
            for (int i = 0; i < text.Length; i++)
                Console.WriteLine(text[i]);
            Console.WriteLine();

            //vypíše pod sebe v opačném pořadí:
            for (int i = text.Length - 1; i >= 0; i--)
                Console.WriteLine(text[i]);
            Console.ReadLine();
 
        }


        //Vytvořte metodu s parametrem typu String
        //Metoda vrátí počet velkých písmen v textu (parametr metody)

        public static long pocetVelkychPismen(string text)
    {
        long pocet = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == text.ToUpper()[i])
                    // if (text[i] == text[i].ToString().ToUpper())
                    pocet++;
            }
            return pocet;
    }
        public static void hlavniProgram()
        {
            Console.WriteLine("Zadej text: ");
            string text = Console.ReadLine();
            long pocet = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == text.ToUpper()[i])
                    pocet++;
            }
            Console.WriteLine(pocet);
            Console.ReadLine();
        }


        //metoda, řekne jestli první a poslední písmo je velké.
        public static void PrvniNeboPosledni()
        {
            Console.WriteLine("Zadej text: ");
            string text = Console.ReadLine();

            if (text[0] == text.ToUpper()[0])
                Console.WriteLine("Záčíná velkým písmenem");
            else
                Console.WriteLine("Nezačíná na velké písmeno");

            if(text[text.Length - 1] == text.ToUpper()[text.Length-1])
                Console.WriteLine("Končí velkým písmenem");
            else
                Console.WriteLine("Končí velkým písmenem");
            Console.Read();

            



 
        }

        //metoda, která testuje zda obsahuje text číselné znáky

        public static void testCiselneZnaky()
        {

            //"a" string
            //'a' char

            Console.WriteLine("Zadej text");
            string text = Console.ReadLine();

            foreach (char c in text)
                if (Char.IsNumber(c))
                {
                    Console.WriteLine("Obsahuje číselné znaky");
                    Console.ReadLine();
                    return;//ukončení programu
                }
            Console.WriteLine("Neobsahuje číselné znaky");
            Console.ReadLine();
        }


        //Vytvořte metodu, která načte slovo
        //Metoda slovo upraví a vypíše na obrazovku
        //uprava: První znak velkym, ostatní znaky nahrazeny "*"
        //Např. vstup= leden - výstup: L****


        public static void upravaTextu()
        {
            Console.WriteLine("Zadej text");
            string text = Console.ReadLine();
            string uprava = "";


            for (int i = 0; i < text.Length - 1; i++)
                uprava = uprava + "*";
            uprava = text.ToUpper()[0] + uprava;
            Console.WriteLine(uprava);
            Console.ReadLine();

        }

        /// Máme udaje v tomto formátu: jmeno + mezera + prijmeni např. "Marek Novák"
        /// program načte tento údaj a vrátí příjmení
        /// První znak bude velký, další budou malé


        public static void ukol5()
        {
            Console.WriteLine("Napiš jméno a příjmení: ");
            string t = Console.ReadLine();

            string prijmeni;
            prijmeni =  (t.Substring(t.IndexOf(" ") + 1));
            prijmeni = prijmeni.Substring(0, 1).ToUpper() + prijmeni.Substring(1).ToLower();


            Console.WriteLine(prijmeni);
            Console.ReadLine();

        }
        ///program načte slovo
        ///poté zobrazí první a poslední znak, ostatní znaky nahradí *
        ///vstup: abcd výstup a**d
        ///
        public static void ukol6()
        {
            Console.WriteLine("Napiš nějaké slovo: ");
            string t = Console.ReadLine();


            string hvezdy = "";
            for (int i = 1; i < t.Length - 1; i++)
 
            hvezdy = hvezdy + "*";

            Console.WriteLine(t[0] + hvezdy + t[t.Length - 1]);
            Console.ReadLine();
        }
        ///Načte slovo
        ///odstraní případné mezery před a za slovem
        ///pokud slovo začíná čísly odstraní také je.
        ///takto upravené slovo zobrazí.
        /// "111ss" "ss"
        /// 
        public static void ukol7()
        {
            Console.WriteLine("Napiš text: ");
            string t = Console.ReadLine();


            while (0 < t.Length && char.IsNumber(t[0]))
                t = t.Substring(1);
            Console.WriteLine(t);
            Console.ReadLine();
        }


        ///program odstraní z textu všechny číslice
        ///


        public static void ukol7v2()
        {
            Console.WriteLine("Napiš text: ");
            string t = Console.ReadLine();
            string t2 = "";

            foreach (char z in t)
                if (!char.IsNumber(z)) t2 += z; //text2=text2+z



            Console.WriteLine(t2);
            Console.ReadLine();
        }



        //napište text, program vypíše počet samohlásek, souhlásek, jiných znaků
        public static void ukol8()
        {
            Console.WriteLine("Napiš text: ");
            string t = Console.ReadLine();

            // převede text na malé písmo
            t = t.ToLower();

            //inicializace počitadel
            int pocetSamohlasek = 0;
            int pocetSouhlasek = 0;

            //definice typů znaků
            string samohlasky = "aeiouy";
            string souhlasky = "qwrtpsdfghjklzxcvbnm";

            //hlavní cyklus
            foreach (char c in t)
            {
                if (samohlasky.Contains(c))
                    pocetSamohlasek++;
                else if (souhlasky.Contains(c))
                    pocetSouhlasek++;
            }
            Console.WriteLine("Samohlásky: {0}", pocetSamohlasek);
            Console.WriteLine("Souhlásky: {0}", pocetSouhlasek);
            Console.WriteLine("Jiné znaky: {0}", t.Length - (pocetSamohlasek + pocetSouhlasek));
            Console.ReadLine();

        }





























    }
}
