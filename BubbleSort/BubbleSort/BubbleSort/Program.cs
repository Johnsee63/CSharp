using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string sTitle = "Buborék rendezés";
            //string sSubTitle = "'A' megoldás.";
            string sSubTitle = "'B' megoldás.";
            Console.WriteLine(sTitle);
            Console.WriteLine(sSubTitle);
            Console.WriteLine();

            int[] aArray = new int[20];
            int iFirstCycleVariable = 0;
            int iSecondCycleVariable = 0;
            int iTempNumber = 0;
            Random rNumber = new Random();

            for (iFirstCycleVariable = 0; iFirstCycleVariable < aArray.Length; ++iFirstCycleVariable)
            {
                aArray[iFirstCycleVariable] = rNumber.Next(1, 50); //a tömb elemeinek feltöltése véletlen számokkal.
                Console.Write("{0}, ", aArray[iFirstCycleVariable]); //a feltöltött adatok megjelenítése.
            }

            /*for (iFirstCycleVariable = 0; iFirstCycleVariable < aArray.Length; ++iFirstCycleVariable)
            {
                for(iSecondCycleVariable=aArray.Length - 1; iSecondCycleVariable>iFirstCycleVariable; --iSecondCycleVariable)
                {
                    if (aArray[iSecondCycleVariable -1] > aArray[iSecondCycleVariable])
                    {
                        iTempNumber = aArray[iSecondCycleVariable];
                        aArray[iSecondCycleVariable] = aArray[iSecondCycleVariable - 1];
                        aArray[iSecondCycleVariable - 1] = iTempNumber;
                    }
                }
            }*/

            for (iFirstCycleVariable = 1; iFirstCycleVariable < aArray.Length; ++iFirstCycleVariable)
            {

                iTempNumber = aArray[iFirstCycleVariable];
                iSecondCycleVariable = iFirstCycleVariable - 1;

                while (iSecondCycleVariable > -1 && iTempNumber < aArray[iSecondCycleVariable])
                {
                    aArray[iSecondCycleVariable + 1] = aArray[iSecondCycleVariable];
                    --iSecondCycleVariable;
                }

                aArray[iSecondCycleVariable + 1] = iTempNumber;
            }

            Console.WriteLine();

            for (iFirstCycleVariable = 0; iFirstCycleVariable < aArray.Length; ++iFirstCycleVariable)
            {
                Console.Write("{0}, ", aArray[iFirstCycleVariable]); //a sorba rendezett adatok megjelenítése.
            }

            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("A program futása tetszőleges billentyű leütésére leáll.");
            Console.ReadKey();
        }
    }
}
