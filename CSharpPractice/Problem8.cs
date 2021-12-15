using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class Problem8
    {
        public Problem8()
        {
            Console.WriteLine("Enter value:");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            for(int i = 0; i < n; i++)
            {
                Console.Write(a + " ");

                a = a + a;
            }
        }
    }
}
