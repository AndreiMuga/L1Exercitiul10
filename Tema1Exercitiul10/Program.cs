using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace Lab1Ex5
{
    public class Program
    /* Ex 10
Scrieti un program care sa va afisa suma cifrelor ununi numar intreg citit de la
tastatura.
 Numarul are exact 2 cifre
     */
    {
        public static void Main(string[] args)
        {
            int a;
            int primaCifra;
            int aDouaCifra;
            Console.WriteLine("Introduceti un numar intreg din exact 2 cifre: ");
            a = Convert.ToInt32(Console.ReadLine());
            primaCifra = a / 10;
            aDouaCifra = a % 10;
            if (a > -100 && a < 0)
            {
                Console.WriteLine("Suma cifrelor introduse este: " + (primaCifra + aDouaCifra));
            }
            else if (a > 0 && a < 100)
            {
                Console.WriteLine("Suma cifrelor introduse este: " + (primaCifra + aDouaCifra));
            }
            else if (a == 0)
            {
                Console.WriteLine("0 plus 0 = 0, am zis din doua");
            }
            if (a > 99 || a < -99)
            { 
                Console.WriteLine("Chiar am zis din doua");
            }
        }
    }
}