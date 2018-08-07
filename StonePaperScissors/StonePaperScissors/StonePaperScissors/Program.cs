using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StonePaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random something = new Random();

            string cChoice = "";
            string pChoice = "";
            int cScore = 0;
            int pScore = 0;

            bool sequel = true;

            Console.WriteLine("Kő - Papír - Olló játék a számítógéppel");
            Console.WriteLine();

            do
            {
                Console.WriteLine("Mit választasz (k/p/o)? ");  // A játékos választ.
                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'k':
                        pChoice = "kő";
                        break;

                    case 'p':
                        pChoice = "papír";
                        break;

                    case 'o':
                        pChoice = "olló";
                        break;
                }

                switch (something.Next(0, 2))   // A számítógép választ.
                {
                    case 0:
                        cChoice = "kő";
                        break;

                    case 1:
                        cChoice = "papír";
                        break;

                    case 2:
                        cChoice = "olló";
                        break;
                }

                Console.WriteLine("Játékos választása: " + pChoice + " A számítógép választása: " + cChoice);

                if (
                    (pChoice=="kő" && cChoice=="papír")
                    ||
                    (pChoice=="papír" && cChoice=="olló")
                    ||
                    (pChoice=="olló" && cChoice=="kő")
                    )   // A kapott válaszok kiértékelése.
                {
                    Console.WriteLine("Sajnálom, veszítettél! Az állás \nSzámítógép: {0} \nJátékos: {1}", ++cScore, pScore);
                }
                else if (pChoice==cChoice)
                {
                    Console.WriteLine("Megízzasztottál, döntetlen! Az állás \nSzámítógép: {0} \nJátékos: {1}", cScore, pScore);
                }
                else
                {
                    Console.WriteLine("Gratulálok, nyertél! Az állás \nSzámítógép: {0} \nJátékos: {1}", cScore, ++pScore);
                }

                Console.WriteLine();
                Console.WriteLine("Folytasuk (i/n)? ");
                if (Console.ReadKey(true).KeyChar == 'n')
                    sequel = false;
            } while (sequel);
        }
    }
}
