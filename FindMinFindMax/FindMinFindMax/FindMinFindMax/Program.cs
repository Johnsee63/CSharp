using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMinFindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            string sTitle = "Minimum és maximum keresése";
            string sSubTitle = "Vektor felhasználásval.";
            Console.WriteLine(sTitle);
            Console.WriteLine(sSubTitle);
            Console.WriteLine();

            int[] aTeszt = new int[1000];
            int iCycleVariable = 0;
            int iMax = 1;
            int iMin = 1000;
            int iMinIndex = 0;
            int iMaxIndex = 0;
            Random rNumber = new Random();

            for (iCycleVariable = 0; iCycleVariable < aTeszt.Length; ++iCycleVariable)
            {
                aTeszt[iCycleVariable] = rNumber.Next(1, 1000); //a tömb elemeinek feltöltése véletlen számokkal.
            }

            for (iCycleVariable=0; iCycleVariable<aTeszt.Length; ++iCycleVariable)
            {
                if (aTeszt[iCycleVariable] < iMin)
                {
                    iMin = aTeszt[iCycleVariable];
                    iMinIndex = iCycleVariable;
                }
                else if (iMin == 1)
                {
                    break;
                }

                if (aTeszt[iCycleVariable] > iMax)
                {
                    iMax = aTeszt[iCycleVariable];
                    iMaxIndex = iCycleVariable;
                }
                else if (iMax == 1000)
                {
                    break;
                }
            }

            Console.WriteLine("A legkisebb érték a " + iMinIndex + "., az értéke: " + iMin);
            Console.WriteLine("A legnagyobb érték a " + iMaxIndex + "., az értéke: " + iMax);

            Console.WriteLine();
            Console.WriteLine("A program futása tetszőleges billentyű leütésére leáll.");
            Console.ReadKey();
        }
    }
}
