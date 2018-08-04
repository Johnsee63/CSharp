using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTable
{
    class Program
    {
        /*static void Main(string[] args)
        {
            string title = "Szorzótábla (paraméter szorozva kettővel)";
            Console.WriteLine(title);
            Console.WriteLine();

            if (args.Length == 0)
            {
                Console.WriteLine("A helyes futáshoz meg kell adni egy szorzandót!");
                Console.ReadKey();
                return;
            }
            else
            {
                int number = int.Parse(args[0]);
                Console.WriteLine(args[0] + " * 2 = " + number * 2);
            }
        }*/

        /*static void Main(string[] args)
        {
            string title = "Szorzótábla (paraméter szorozva kettővel)";
            string subTitle = "Ha nincs paraméter akkor program generál.";
            Console.WriteLine(title);
            Console.WriteLine(subTitle);
            Console.WriteLine();

            int number;

            if (args.Length == 0)
            {
                Random rNumber = new Random();
                number = rNumber.Next(100);
            }
            else
            {
               number = int.Parse(args[0]);
            }

        Console.WriteLine(number + " * 2 = " + number * 2);
        Console.ReadKey();
        }*/

        static void Main(string[] args)
        {
            string title = "  Szorzótábla (paraméterként megadott szám szorzótáblája)";
            string subTitle1 = "Ha a paraméter nem 1 és 10 között van, hibaüzenetet kapsz.";
            string subTitle2 = "        Ha nincs paraméter akkor program generál.";
            string errMessage = "Ez nem 1 és 10 közé esik!";
            Console.WriteLine(title);
            Console.WriteLine(subTitle1);
            Console.WriteLine(subTitle2);
            Console.WriteLine();

            int number = 0;

            if (args.Length == 0)
            {
                Random rNumber = new Random();
                do
                {
                    number = rNumber.Next(10);
                } while (number < 0);

                for (int i = 1; i <= 10; ++i)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, number, i * number);
                }
                Console.WriteLine();
            }
            else
            {
                number = int.Parse(args[0]);
                if (1 <= number && 10 >= number)
                {
                    for (int i=1; i <=10; ++i)
                    {
                        Console.WriteLine("{0} x {1} = {2}", i, number, i * number);
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("A megadott paraméter a " + number +". " + errMessage);
                }
            }
            Console.WriteLine("Nyomj egy gombot a kilépéshez.");
            Console.ReadKey();
        }
    }
}
