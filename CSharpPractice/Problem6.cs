using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class Problem6
    {
        public Problem6()
        {
            Console.WriteLine("Enter Year:");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0)
            {
                Console.WriteLine("Leap Year!");
            }
            else
            {
                if (year % 100 == 0)
                {
                    Console.WriteLine("Not a Leapyear!");
                }else if (year % 4 == 0)
                {
                    Console.WriteLine("Leap Year!");
                }
                else
                {
                    Console.WriteLine("Not a leapyear");
                }
            }
        }
    }
}
