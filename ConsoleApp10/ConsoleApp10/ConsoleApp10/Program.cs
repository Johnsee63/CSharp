using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    /*class Dog
    {
        private string sName;
        private int iAge;

        public Dog(string sDogName, int iDogAge)
        {
            this.sName = sDogName;
            this.iAge = iDogAge;
        }
    }*/

    partial class PClass
    {

    }

    class Program
    {
        /*static void Main(string[] args)
        {
            string sTitle = "Osztályok";
            string sSubTitle = "'Kutya' osztály és példányosítás.";
            Console.WriteLine(sTitle);
            Console.WriteLine(sSubTitle);
            Console.WriteLine();

            Dog dDog = new Dog("Arthur", 6);
            Console.WriteLine(dDog);

            Console.WriteLine();
            Console.WriteLine("A program futása tetszőleges billentyű leütésére leáll.");
            Console.ReadKey();
        }*/

        static public void Main()
        {
            string sTitle = "Osztályok";
            string sSubTitle = "Parciális osztályok.";
            Console.WriteLine(sTitle);
            Console.WriteLine(sSubTitle);
            Console.WriteLine();

            PClass p = new PClass();
            p.Do();

            Console.WriteLine();
            Console.WriteLine("A program futása tetszőleges billentyű leütésére leáll.");
            Console.ReadKey();
        }
    }
}
