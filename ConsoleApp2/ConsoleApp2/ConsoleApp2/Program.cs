using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MyClass
    {
        public int x;   //publikus változó deklarálás az osztályon belül.
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass s = new MyClass();
            s.x = 10;

            MyClass p = s;
            p.x = 14;

            Console.WriteLine(s.x);
            Console.ReadKey();
        }
    }
}
