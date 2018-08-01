using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "Dinamikus típus használata";
            Console.WriteLine(title);
            Console.WriteLine();

            dynamic x = 10;
            Console.WriteLine("X -> " + x);   // x értéke most 10.
            Console.WriteLine();

            x = "Stifolder";
            Console.WriteLine("X -> "+x);   // x értéke most szalámi.
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
