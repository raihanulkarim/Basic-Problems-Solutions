using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class Problem5
    {
        public Problem5()
        {
            Console.WriteLine("Enter value:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("I -> convert from inches to centimeters. \nG->convert from gallons to liters.\nM->convert from mile to kilometer.\nP->convert from pound to kilogram.");
            char m = Convert.ToChar(Console.ReadLine());
            string x = (m.ToString()).ToUpper();
            switch (x)
            {
                case "I":
                    Console.WriteLine("Centimer:{0}", a * 2.54);
                    break;
                case "G":
                    Console.WriteLine("Liter:{0}", a * 3.785411784);
                    break;
                case "M":
                    Console.WriteLine("Kilometer:{0}", a * 1.60934);
                    break;
                case "P":
                    Console.WriteLine("Kilogram:{0}", a * 453.592);
                    break;
            }
        }
    }
}
