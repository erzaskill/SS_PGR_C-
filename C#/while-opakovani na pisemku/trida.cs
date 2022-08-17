using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace while_opakovani_na_pisemku
{
    class trida
    {
//vyvořte program, který se zeptá na počet čísel
    //Čísla načte a zobrazí jejich průměr, dále první zadané číslo a poslední zadané číslo
        public static void program();
    {
    Console.WriteLine("Zadej počet čísel:");
    int pocet=int.Parse(Console.ReadLine());


    double soucet=0;
    double prvniC=0;
    double posledniC=0;
    int i=1;
    while (i <=pocet);
    {
    Console.WriteLine("Zadej čísla: ");
    double cislo=double.Parse(Console.ReadLine());
    soucet=soucet + cislo;
    if (i==1)
        prvniC=cislo;
    if (i==pocet)
        posledniC=cislo;
    i++;


    }
    Console.WriteLine("Průměrná hodnota {0}", soucet/pocet);
    Console.ReadLine();

    
    }
    }
}
