using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "Típus konverzió, típus lekérdezések használata";
            Console.WriteLine(title);
            Console.WriteLine();
            /*Console.WriteLine("Futásidejű típuslekérdezés 'is' használatával.");
            Console.WriteLine();

            int xNumber = 10;

            if (xNumber is int)
            {
                Console.WriteLine("A változó típsa integer.");
            }*/

            /*Console.WriteLine("Futásidejű típuslekérdezés és konverzió 'as' használatával.");
            Console.WriteLine();

            object a = "123";
            object b = "Hello";
            object c = 10;

            string aa = a as string;
            Console.WriteLine(aa == null ? "NULL" : aa); //értéke: 123

            string bb = b as string;
            Console.WriteLine(bb == null ? "NULL" : bb); //értéke: Hello

            string cc = c as string;
            Console.WriteLine(cc == null ? "NULL" : cc); //értéke: NULL */

            Console.WriteLine("Karakterkonverziók.");
            Console.WriteLine();

            for (char ch= 'a'; ch<='z'; ++ch)
            {
                Console.WriteLine((int)ch);
            }

            Console.ReadKey();
        }
    }
}
