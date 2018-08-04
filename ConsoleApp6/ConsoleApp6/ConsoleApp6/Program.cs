using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "Vezérlési szerkezetek használata";
            Console.WriteLine(title);
            Console.WriteLine();
            Console.WriteLine("Elágazások");
            Console.WriteLine();

            int x = 10;
            if (x == 10)   //ha az xegyenlő tízzel...
            {
                Console.WriteLine("Az x értéke 10.");
                Console.WriteLine();
            }
            x += 1;
            if (x == 10)   //ha az xegyenlő tízzel...
            {
                Console.WriteLine("Az x értéke 10.");
                Console.WriteLine();
            }
            else //ha az x nem egyenlő tízzel.
            {
                Console.WriteLine("Az x értéke nem 10.");
                Console.WriteLine();
            }
            x += 2;
            if (x == 10)   //ha az x egyenlő tízzel...
            {
                Console.WriteLine("Az x értéke 10.");
                Console.WriteLine();
            }
            else if (x == 12) //vagy egyenlő tizenkettővel...
            {
                Console.WriteLine("Az x értéke 12.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Az x értéke nem 10 vagy 12.");
                Console.WriteLine();
            }
            x -= 2;
            switch (x)   //ha az x több lehetséges állapotát vizsgáljuk...
            {
                case 10:    //ha az x értéke 10
                    Console.WriteLine("Az x értéke 10.");
                    Console.WriteLine();
                    break;
                case 11:    //ha az x értéke 11.
                    Console.WriteLine("Az x értéke 11.");
                    Console.WriteLine();
                    break;
                case 12:    //ha az x értéke 12.
                    goto default;
                default:
                    Console.WriteLine("Az x értéke nem 10 és nem 11.");
                    Console.WriteLine();
                    break;
            }
            Console.WriteLine("Ciklusok");
            Console.WriteLine();
            for (int i=0; i<10 && i != 6; i += 2)
            {
                Console.WriteLine("Számlálós (for) ciklus - i értéke: " + i);
            }

            /*for (; ;)   //végtelen ciklus csak CTRL+C-vel állítható le.
            {
                Console.WriteLine("Végtelen ciklus...");    
            }*/

            int j = 0;  //ciklusváltozó deklarálás.
            while(j<10) //elöl tesztelő ciklus, fut amíg j kisebb mint 10.
            {
                Console.WriteLine("Elöl tesztelő ciklus. j értéke: {0} ", j);
                ++j;    //ciklusváltozó növelése.
            }

            j = 0;  //ciklusváltozó beállítás.
            do //hátul tesztelő ciklus, fut amíg j kisebb mint 10.
            {
                Console.WriteLine("Hátul tesztelő ciklus. j értéke: {0} ", j);
                ++j;    //ciklusváltozó növelése.
            } while (j < 10);   //ciklusváltozó értékének vizsgálata.

            string str = "foreach ciklus";
            foreach (char ch in str) //elöl tesztelő ciklus, fut amíg az str változó végére nem ér
            {
                Console.WriteLine(ch);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
