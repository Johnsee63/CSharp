using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        /*enum Animal {Macska, Kutya, Tigris, Farkas };   //Felsorolt típus deklaráció.

        static void Main(string[] args)
        {
            string title = "Felsorolt típus kezelés 1";
            Console.WriteLine(title);
            Console.WriteLine();

            Animal b = Animal.Tigris;

            if (b == Animal.Tigris);   //Ha b egy tigris...
            {
                Console.WriteLine("b egy Tigris...");
            }

            Console.ReadKey();

        }*/

        enum Animal { Macska = 1, Kutya = 3, Tigris, Farkas };   //Felsorolt típus deklaráció.

        static void Main(string[] args)
        {
            string title = "Felsorolt típus kezelés 2";
            Console.WriteLine(title);
            Console.WriteLine();

            string s1 = "1";
            string s2 = "Kutya";

            Animal a1, a2;

            Enum.TryParse(s1, true, out a1);
            Enum.TryParse(s2, true, out a2);

            Console.WriteLine();            
            Console.ReadKey();
        }
    }
}
