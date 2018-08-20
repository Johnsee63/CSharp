using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindIslands
{
    class Program
    {
        static void Main(string[] args)
        {
            string sTitle = "Szigetek keresése és hosszmérése";
            string sSubTitle = "Nullák és egyesek ellenőrzésével (paraméterként átadva).";
            Console.WriteLine(sTitle);
            Console.WriteLine(sSubTitle);
            Console.WriteLine();

            string sText;
            int iIslandCount = 0;
            int iMaxIslandLenght = 0;
            int iFirstCycleCounter = 0;
            int iSecondCycleCounter = 0;
            int iTemp = 0;

            if (args.Length==0) //ha nincs paraméter
            {
                Console.WriteLine("Kérem adjon meg egy '0'-ból és '1'-ből álló tetszőleges hosszúságú karaktersorozatot.");
                sText = Console.ReadLine();
            }
            else
            {
                sText = args[0]; //ha van paraméter, betöltjük.
            }

            while (iFirstCycleCounter < sText.Length) //a kapott karaktersorozat végigolvasása.
            {
                if (sText[iFirstCycleCounter] == '1') //ha a beolvasott karakter 1.
                {
                    ++iIslandCount; //Növeljük a sziget számlálót 1-el.
                    iSecondCycleCounter = iFirstCycleCounter; //beállítjuk a ciklus számlálót.

                    while (iSecondCycleCounter < sText.Length && sText[iSecondCycleCounter] == '1') //számoljuk a sziget hosszát.
                    {
                        ++iSecondCycleCounter; //növeljük a belső ciklus számlálót 1-el.
                        ++iTemp; //növeljük a sziget hosszát 1-el.
                    }

                    iFirstCycleCounter = iSecondCycleCounter;

                    if (iTemp > iMaxIslandLenght)
                    {
                        iMaxIslandLenght = iTemp;
                    }
                }
                else
                {
                    ++iFirstCycleCounter; //növeljük a külső ciklusszámlálót 1-el.
                }

                iTemp = 0;

            }

            Console.WriteLine("A felmérés adatai:" + sText);
            Console.WriteLine();
            Console.WriteLine("A felmért szigetek száma: " + iIslandCount);
            Console.WriteLine("A felmért leghosszabb sziget hossza: " + iMaxIslandLenght);

            Console.WriteLine();
            Console.WriteLine("A program futása tetszőleges billentyű leütésére leáll.");
            Console.ReadKey();
        }

    }
}
