using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class TEST
	{

		public static void test()
			/// Program načte číslo, zobrazí volbu (1. Výpis, 2.Nejmenší číslo, soičet, průměr kladných hodnot. 3. konec), program bude probíhat pořád dokola, dokud nenapíšete 3
			/// Program  se ještě zeptá jestli chcete pokračovat.. pokud ne, program se ukončí
		{
			string volba = "";
			string vypis = "";
			float minimum = 78947456464;
			float soucet = 0;
			float pocet = 0;
			float prumer = 0;
			float a = 1;
			string volba2 = "";

			while (true)
			{
				Console.WriteLine("Napiš číslo: ");
				a = float.Parse(Console.ReadLine());
				
				vypis = vypis + a +"; ";
				


				

				if (a == 0)
				{
					break; 
				}

				if (a > 0)
				{
					pocet = pocet + 1;
					soucet = soucet + a;
					prumer = soucet / pocet;
				}

				if (a < minimum)
				{
					a = minimum;
				}

				Console.WriteLine("Vyber si: 1. Výpis, 2.Statistika, 3.konec: ");
				volba = Console.ReadLine();
				if (volba == "1")
				{
					Console.WriteLine("Výpis hodnot: {0}", vypis);
				}
				if (volba == "2")
				{
					Console.WriteLine("Nejmenší číslo: {0}\nsoučet: {1}\nprůměr kladných hodnot: {2}", minimum, soucet, prumer);
					
				}
				if (volba == "3")
				{
					break;
				}

				Console.WriteLine("Chcete pokračovat? ano/ne: ");
				volba2 = Console.ReadLine();
				if (volba2 == "ne")
				{
					break;
				}

				
			}

		}

	}
}
