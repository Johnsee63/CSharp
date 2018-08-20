using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "Tömbök kezelése";
            Console.WriteLine(title);
            Console.WriteLine();
            /*Console.WriteLine("Vektor (egydimenziós tömb) elemek feltöltése és megjelenítése.");
            Console.WriteLine();

            int[] aTeszt = new int[10];
            Random rNumber = new Random();

            for (int iCycleVariable=0; iCycleVariable< aTeszt.Length; ++iCycleVariable)
            {
                aTeszt[iCycleVariable] = rNumber.Next(0, 100); //a tömb elemeinek feltöltése véletlen számokkal.
            }

            foreach (int iItem in aTeszt)
            {
                Console.WriteLine(iItem); //a tömb elemeinek megjelenítése.
            }*/

            /*Console.WriteLine("Két dimenziós tömb (mátrix) feltöltése és megjelenítése.");
            Console.WriteLine();

            int[,] aMatrix = new int[3,3];
            Random rNumber = new Random();

            for (int iCycleVariableRow=0; iCycleVariableRow< aMatrix.GetLength(0); ++iCycleVariableRow) //sorok feltöltése.
            {
                for (int iCycleVariableColumn=0; iCycleVariableColumn<aMatrix.GetLength(1); ++iCycleVariableColumn) //oszlopok feltöltése.
                {
                    aMatrix[iCycleVariableRow, iCycleVariableColumn] = rNumber.Next(0, 100); //a tömb elemeinek feltöltése véletlen számokkal.
                }
            }

            for (int iCycleVariableRow = 0; iCycleVariableRow < aMatrix.GetLength(0); ++iCycleVariableRow) //sorok indexelése.
            {
                for (int iCycleVariableColumn = 0; iCycleVariableColumn < aMatrix.GetLength(1); ++iCycleVariableColumn) //oszlopok indexelése.
                {
                    Console.Write(aMatrix[iCycleVariableRow, iCycleVariableColumn]+"; "); //a tömb elemeinek megjelenítése.
                }

                Console.WriteLine();

            }*/

            Console.WriteLine("Két dimenziós változó oszlopszámú (jagged) tömb feltöltése és megjelenítése.");
            Console.WriteLine();

            int[][] jaMatrix = new int[3][];
            Random rNumber = new Random();

            for (int iCycleVariableRow = 0; iCycleVariableRow < 3; ++iCycleVariableRow) //sorok feltöltése.
            {
                jaMatrix[iCycleVariableRow] = new int[rNumber.Next(1, 5)];

                for (int iCycleVariableColumn = 0; iCycleVariableColumn < jaMatrix[iCycleVariableRow].Length; ++iCycleVariableColumn) //oszlopok feltöltése.
                {
                    jaMatrix[iCycleVariableRow][iCycleVariableColumn] = iCycleVariableRow + iCycleVariableColumn;
                    Console.Write("{0}, ", jaMatrix[iCycleVariableRow][iCycleVariableColumn]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("A program futása tetszőleges billentyű leütésére leáll.");
            Console.ReadKey();
        }
    }
}
