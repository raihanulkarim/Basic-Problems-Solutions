using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class Problem1
    {
        public Problem1()
        {
            Console.WriteLine("Enter a Character");
            char userVal = Convert.ToChar(Console.ReadLine());
            int aschiVal = Convert.ToInt32(userVal);
            if(aschiVal <= 90 && aschiVal >= 65)
            {
                Console.WriteLine(Convert.ToChar(aschiVal + 32));
            }else if (aschiVal >= 97 && aschiVal <= 122)
            {
                Console.WriteLine(Convert.ToChar(aschiVal - 32));
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}
