using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class Problem9
    {
        public Problem9()
        {
            for (int i = 1; i <= 16; i = i*2)
            {
                Console.Write((char)(i+64));
            }
        }
    }
}
