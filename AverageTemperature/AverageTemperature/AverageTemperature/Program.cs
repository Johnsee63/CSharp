using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageTemperature
{
    class Program
    {
        static void Main(string[] args)
        {
            string sTitle = "Éves átlaghőmérséklet számítás";
            string sSubTitle = "Két dimenziós változó oszlopszámú (jagged) tömb segítségével.";
            Console.WriteLine(sTitle);
            Console.WriteLine(sSubTitle);
            Console.WriteLine();

            int iCycleVariableRow;
            int iCycleVariableColumn;
            int[][] jaMatrix = new int[12][];
            int iTempTemperature = 0;
            int iMinDayTemperature = 45;
            int iMaxDayTemperature = -30;
            int iMinMonthTemperature = 45;
            int iMaxMonthTemperature = -30;
            int iColdLine = 0;
            bool bColdLine = false;
            
            Random rNumber = new Random();

            for (iCycleVariableRow = 0; iCycleVariableRow < 12; ++iCycleVariableRow) //sorok feltöltése.
            {
                if (iCycleVariableRow == 0 || iCycleVariableRow == 2 || iCycleVariableRow==4 || iCycleVariableRow == 6 || iCycleVariableRow == 7 || iCycleVariableRow == 9 || iCycleVariableRow == 11 )
                {
                    jaMatrix[iCycleVariableRow] = new int[31];
                }
                else if (iCycleVariableRow == 3 || iCycleVariableRow == 5 || iCycleVariableRow == 8 || iCycleVariableRow == 10)
                {
                    jaMatrix[iCycleVariableRow] = new int[30];
                }
                else
                {
                    jaMatrix[iCycleVariableRow] = new int[28];
                }

                for (iCycleVariableColumn = 0; iCycleVariableColumn < jaMatrix[iCycleVariableRow].Length; ++iCycleVariableColumn) //oszlopok feltöltése.
                {
                    jaMatrix[iCycleVariableRow][iCycleVariableColumn] = rNumber.Next(-30, 45); //feltöltés véletlen számokkal.
                    Console.Write("{0}, ", jaMatrix[iCycleVariableRow][iCycleVariableColumn]); //a feltöltött hőmésrséklet adatok megjelenítése.
                }

                Console.WriteLine();

            }

            iCycleVariableRow = 0;
            iCycleVariableColumn = 0;

            while (iCycleVariableRow < 12)
            {

                while (iCycleVariableColumn < jaMatrix[iCycleVariableRow].Length)
                {
                    if (iMinDayTemperature > jaMatrix[iCycleVariableRow][iCycleVariableColumn])
                    {
                        iMinDayTemperature = jaMatrix[iCycleVariableRow][iCycleVariableColumn];
                    }
                    if (iMaxDayTemperature < jaMatrix[iCycleVariableRow][iCycleVariableColumn])
                    {
                        iMaxDayTemperature = jaMatrix[iCycleVariableRow][iCycleVariableColumn];
                    }
                    
                    iTempTemperature = iTempTemperature + jaMatrix[iCycleVariableRow][iCycleVariableColumn];

                    if (jaMatrix[iCycleVariableRow][iCycleVariableColumn] < 0)
                    {
                        ++iColdLine;
                    }
                    else
                    {
                        iColdLine = 0;
                    }

                    ++iCycleVariableColumn;
                }

                if (bColdLine == false && iColdLine>= 5)
                {
                    bColdLine = true;
                }

                iTempTemperature = iTempTemperature / (iCycleVariableColumn + 1);

                if (iTempTemperature < iMinMonthTemperature)
                {
                    iMinMonthTemperature = iTempTemperature;
                }

                if (iTempTemperature > iMaxMonthTemperature)
                {
                    iMaxMonthTemperature = iTempTemperature;
                }

                ++iCycleVariableRow;
            }

            Console.WriteLine("Az év leghidegebb napjának hőmérséklete:" + iMinDayTemperature);
            Console.WriteLine("Az év legmelegebb napjának hőmérséklete:" + iMaxDayTemperature);
            Console.WriteLine("Az év leghidegebb hónapjának átlaghőmérséklete:" + iMinMonthTemperature);
            Console.WriteLine("Az év legmelegebb hónapjának átlaghőmérséklete:" + iMaxMonthTemperature);
            Console.WriteLine("Az évben volt egymást követő fagypont alatti hőmérsékletű nap: " + bColdLine);

            Console.WriteLine();
            Console.WriteLine("A program futása tetszőleges billentyű leütésére leáll.");
            Console.ReadKey();
        }
    }
}
