using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Szám kitalálós játék a számítógéppel");
            Console.WriteLine();

            Random something = new Random();

            int cNumber = 0;
            int pNumber = 0;
            int i = 1;
            int min = 1;
            int max = 100;

        START:
            Console.WriteLine("Mindenkinek öt tippje van. Válassz játékmódot!");
            Console.WriteLine("1 - Te gondolsz egy számra.");
            Console.WriteLine("2 - A számítógép gondol egy számra.");
            Console.WriteLine();

            switch (Console.ReadKey(true).KeyChar)
            {
                case '1': goto PLAYER;
                case '2': goto COMPUTER;
            }

        PLAYER:
            cNumber = 50;

            Console.WriteLine("Gondolj egy egész számra 1 és 100 között.");
            Console.WriteLine();

            i = 1;

            while (i < 5)
            {
                Console.WriteLine("A számítógép szerint a szám {0}.", cNumber);
                Console.WriteLine("Segíts egy kicsit, szerinted (k - kisebb, n - nagyobb, e - egyenlő)?");

                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'k':
                        if (i == 3)
                            cNumber = something.Next(min, cNumber);
                        else
                        {
                            max = cNumber;
                            cNumber -= (max - min) / 2;
                        }
                        break;
                    case 'n':
                        if (i == 3)
                            cNumber = something.Next(cNumber + 1, max);
                        else
                        {
                            min = cNumber;
                            cNumber += (max - min) / 2;
                        }
                        break;
                    case 'e':
                        Console.WriteLine("A számítógép nyert!");
                        goto END;
                }
            ++i;
            }
            Console.WriteLine("Gratulálok, nyertél! A számítógép nem tudta kitalálni a számot.");
            goto END;

        COMPUTER:
            cNumber = something.Next(min, max);

            Console.WriteLine("A számítógép gondolt egy számra 1 és 100 között.");

            while (i < 5)
            {
                Console.WriteLine("\nAz " + i + ". tipped:");
                pNumber = int.Parse(Console.ReadLine());

                if (cNumber > pNumber)
                {
                    Console.WriteLine("A szám ennél nagyobb!");
                }
                else if (cNumber < pNumber)
                {
                    Console.WriteLine("A szám ennél kissebb!");
                }
                else
                {
                    Console.WriteLine("Gratulálok, nyertél!");
                    goto END;
                }
                ++i;
            }

            Console.WriteLine("\nSajnálom, vesztettél! A szám {0} volt.", cNumber);
            goto END;

        END:
            Console.WriteLine("\nAkarsz még Játszani (i/n)?");

            switch (Console.ReadKey(true).KeyChar)
            {
                case 'i': goto START;
                case 'n': break;
                default: goto END;
            }
        }
    }
}
