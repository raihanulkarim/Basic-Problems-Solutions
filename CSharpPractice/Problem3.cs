using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class Problem3
    {
        public Problem3()
        {
            Console.WriteLine("Enter x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter radius");
            int r = Convert.ToInt32(Console.ReadLine());
            int coOrdinates = (x * x) + (y * y);
            int radius_square = r * r;
            if(coOrdinates == radius_square)
            {
                Console.WriteLine("On the Circle!");
            }else if (coOrdinates < radius_square)
            {
                Console.WriteLine("Inside the Circle!");
            }
            else
            {
                Console.WriteLine("Outside the circle!"); 
            }
        }
    }
}
