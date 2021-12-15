using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class Problem4
    {
        public Problem4()
        {
            Console.WriteLine("Enter value:");
            char b = Convert.ToChar(Console.ReadLine());
            int a = Convert.ToInt32(b);
            if (a >= 48 && a <= 57)
            {
                Console.WriteLine("Digit");
            }
            else if (a >= 65 && a <= 90)
            {
                Console.WriteLine("Uppercase");
            }
            else if (a >= 97 && a <= 122)
            {
                Console.WriteLine("Lowercase");
            }
            else
            {
                Console.WriteLine("Special Symbol");
            }
        }
    }
}
