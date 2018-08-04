using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string title = "Matematikai operátorok használata";
            Console.WriteLine(title);
            Console.WriteLine();

            int x = 10;
            int y = 3;
            int z = x + y;
            Console.WriteLine("10 + 3 = " + z);
            z = x - y;
            Console.WriteLine("10 - 3 = " + z);
            z = x * y;
            Console.WriteLine("10 * 3 = " + z);
            z = x / y;
            Console.WriteLine("10 / 3 = " + z); //maradék nélküli osztás.
            z = x % y;
            Console.WriteLine("10 % 3 = " + z); //maradékos osztás.
            Console.ReadKey();*/

            /*string title = "Relációs operátorok használata";
            Console.WriteLine(title);
            Console.WriteLine();

            int x = 10;
            int y = 23;
            Console.WriteLine(x + " > "+ y + " = " + (x > y));      //X nagyobb mint y -> hamis
            Console.WriteLine(x + " == " + y + " = " + (x == y));   //X egyenlő y-nal -> hamis
            Console.WriteLine(x + " != " + y + " = " + (x != y));   //X nem egyenlő y-nal -> igaz
            Console.WriteLine(x + " <= " + y + " = " + (x <= y));   //X kisebb egyenlő y-nál -> igaz
            Console.ReadKey();*/

            /*string title = "Logikai és feltételes operátorok használata";
            Console.WriteLine(title);
            Console.WriteLine();

            int u = 10;
            int v = 10;

            bool x = true;
            bool y = false;

            if (x == true && y == false)
            {
                Console.WriteLine(x + " and " + y + " = igaz");      //logikai and
            }
            if (x == true & y == false)
            {
                Console.WriteLine(x + " and " + y + " = igaz");      //csonkolt logikai and
            }
            if (x == true || y == false)
            {
                Console.WriteLine(x + " or " + y + " = igaz");      //logikai or
            }
            if (x == true | y == false)
            {
                Console.WriteLine(x + " or " + y + " = igaz");      //csonkolt logikai or
            }
            if (!x == false)
            {
                Console.WriteLine(x + " not false = igaz");      //logikai not
            }
            Console.WriteLine((u==v)?"Egyenlő":"Nem egyenlő");      //feltételes operátor
            Console.ReadKey();*/

            string title = "Egyéb operátorok használata";
            Console.WriteLine(title);
            Console.WriteLine();

            int x = 10;
            int y = 10+(-x);

            Console.WriteLine("10 + (-10) = " + y);      //pozitív, negatív érték jelző operátor

            if(typeof(int)==x.GetType())
            {
                Console.WriteLine("Az x típusa integer");
            }
            Console.WriteLine("Az integer típus mérete " + sizeof(int) + " byte.");     //értéktípus méretét jelző operátor
            Console.ReadKey();
        }
    }
}
