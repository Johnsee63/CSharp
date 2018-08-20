using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string sTitle = "Stringek kezelése";
            string sSubTitle = "";

            Console.WriteLine(sTitle);

            /*sSubTitle = "Egyszerű string kezelés.";
            Console.WriteLine(sSubTitle);
            Console.WriteLine();

            string sText = "ezegystring";

            Console.WriteLine(sText); //egyben kiírva
            Console.WriteLine(sText[0]); //tömbként az első karaktert kiírva.

            foreach (char ch in sText) //tömbként minden elem kiírva.
            {
                Console.Write("{0} ", ch);
            }

            Console.WriteLine();
            Console.WriteLine(sText[4]); //a string ötödik karakterének megjelenítése.*/

            /*sSubTitle = "String kezelő metódusok - összehasonlítás.";
            Console.WriteLine(sSubTitle);
            Console.WriteLine();

            string sText = "egyik";
            string sOtherText = "másik";

            int iResult = string.Compare(sText, sOtherText);

            if (iResult == 0)
            {
                Console.WriteLine("A két string egyenlő.");
            }
            else if (iResult < 0)
            {
                Console.WriteLine("Az 'egyik' a kisebb!");
            }
            else
            {
                Console.WriteLine("A 'másik' a kisebb!");
            }*/

            /*sSubTitle = "String kezelő metódusok - keresések.";
            Console.WriteLine(sSubTitle);
            Console.WriteLine();

            string sText = "verylonglongstring";
            char[] aText = new char[] {'y', 'z', 'o' };

            Console.WriteLine(sText.IndexOf('r')); //eredmény -> 2
            Console.WriteLine(sText.IndexOfAny(aText)); //eredmény -> 3
            Console.WriteLine(sText.LastIndexOf('n')); //eredmény -> 16
            Console.WriteLine(sText.LastIndexOfAny(aText)); //eredmény -> 9
            Console.WriteLine(sText.Contains("long")); //eredmény -> true*/

            /*sSubTitle = "String kezelő metódusok - módosítások.";
            Console.WriteLine(sSubTitle);
            Console.WriteLine();

            string sText = "smallstring";
            char[] aText = new char[] { 's', 'g' };

            Console.WriteLine(sText.Replace('s', 'l')); //eredmény -> lmallltring
            Console.WriteLine(sText.Trim(aText)); //eredmény -> mallstrin
            Console.WriteLine(sText.Insert(0, "one")); //eredmény -> onesmallstring
            Console.WriteLine(sText.Remove(0, 2)); //eredmény -> allstring
            Console.WriteLine(sText.Substring(0, 3)); //eredmény -> sma
            Console.WriteLine(sText.ToUpper()); //eredmény -> SMALLSTRING
            Console.WriteLine(sText.ToLower()); //eredmény -> smallstring*/

            /*sSubTitle = "String kezelő metódusok - StringBuilder.";
            Console.WriteLine(sSubTitle);
            Console.WriteLine();

            StringBuilder sText = new StringBuilder(50);

            for (char ch = 'a'; ch <= 'z'; ++ch)
            {
                sText.Append(ch);
            }

            Console.WriteLine(sText); //eredmény -> az abc a-tól z-ig*/

            /*sSubTitle = "String kezelő metódusok - Reguláris kifejezések.";
            Console.WriteLine(sSubTitle);
            Console.WriteLine();

            Regex pPattern = new Regex("^[1-9][0-9]*");
            string sText = "012345";
            string sOtherText = "112345";
            string sOneText = "2";
            
            Console.WriteLine("{0} : {1}", sText, (pPattern.IsMatch(sText) ?
                "Természetes szám" : "Nem természetes szám"));
            Console.WriteLine("{0} : {1}", sOtherText, (pPattern.IsMatch(sOtherText) ?
                "Természetes szám" : "Nem természetes szám"));
            Console.WriteLine("{0} : {1}", sOneText, (pPattern.IsMatch(sOneText) ?
                "Természetes szám" : "Nem természetes szám"));*/

            sSubTitle = "String kezelő metódusok - Telefonszám ellenőrzés reguláris kifejezéssel.";
            Console.WriteLine(sSubTitle);
            Console.WriteLine();

            string sPattern = @"^(\+)[1-9][0-9]{1,2}\s[1-9][0-9]{1,2}\s(\d{3}(-)){2}\d{3}$";
            Regex pPattern = new Regex(sPattern);
            string sPhoneNumber = "+36 30 661-345-612";
            string sMistake = "+3630 661-567-233";
            string sOtherMistake = "+56 30 667-876-987-456";

            Console.WriteLine(pPattern.IsMatch(sPhoneNumber)); // eredmény -> true
            Console.WriteLine(pPattern.IsMatch(sMistake)); // eredmény -> false
            Console.WriteLine(pPattern.IsMatch(sOtherMistake)); // eredmény -> false

            Console.WriteLine();
            Console.WriteLine("A program futása tetszőleges billentyű leütésére leáll.");
            Console.ReadKey();
        }
    }
}
