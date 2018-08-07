using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int stNumber=0, ndNumber=0, result=0;
            char operandus='+';

            Console.WriteLine("Egyszerű számológép");
            Console.WriteLine();

            if (args.Length == 0)
            {
                Console.WriteLine(" Kérem az első számot: ");
                stNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Kérem a második számot: ");
                ndNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Mi legyen a művelet (+, -, *, /): ");
                operandus = Convert.ToChar(Console.Read());

                switch (operandus)
                {
                    case '+':
                        result = stNumber + ndNumber;
                        break;

                    case '-':
                        result = stNumber - ndNumber;
                        break;

                    case '*':
                        result = stNumber * ndNumber;
                        break;

                    case '/':
                        result = stNumber / ndNumber;
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("A művelet eredménye: {0}", result);
            }
            else
            {
                if (args.Length != 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Hiba!");
                    Console.WriteLine("Nem megfelelő számú a megadott paraméter.");
                }
                else
                {
                    stNumber = int.Parse(args[0]);
                    ndNumber = int.Parse(args[1]);
                    operandus = Convert.ToChar(args[2]);

                    switch (operandus)
                    {
                        case '+':
                            result = stNumber + ndNumber;
                            break;

                        case '-':
                            result = stNumber - ndNumber;
                            break;

                        case '*':
                            result = stNumber * ndNumber;
                            break;

                        case '/':
                            result = stNumber / ndNumber;
                            break;
                    }
                    Console.WriteLine();
                    Console.WriteLine("A művelet eredménye: {0}", result);
                }
            }
            Console.ReadKey();
        }
    }
}
