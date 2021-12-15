using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class Problem2
    {
        public Problem2()
        {
            Console.WriteLine("Enter values for a and b:");
            Console.WriteLine("a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b:");
            int b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter values for c and d:");
            Console.WriteLine("c:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("d:");
            int d = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter values for e and f:");
            Console.WriteLine("e:");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("f:");
            int f = Convert.ToInt32(Console.ReadLine());

            int gradOne = (d - b) / (c - a);
            int gradTwo = (f - b) / (e - a);
            int gradThree = (f - d) / (e - c);
            Console.WriteLine("Slope1:{0} Slope2:{1} Slop3:{2}", gradOne, gradTwo, gradThree);

            if (gradOne == gradTwo && gradOne == gradThree)
            {
                Console.WriteLine("They are in the same straightline!");
            }
            else
            {
                Console.WriteLine("They are not in the same straightline!");
            }
        }
    }
}
