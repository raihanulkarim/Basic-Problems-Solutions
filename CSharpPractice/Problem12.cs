using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class Problem12
    {

        public void ConstructedString()
        {
            string[] arr = { "This", "is", "a", "sentence" };
            string result = "";

            for (int i = 0; ; i++)
            {
                bool finished = true;
                foreach (string word in arr)
                {
                    if (i < word.Length)
                    {
                        result += word[i];
                        finished = false;
                    }
                }
                if (finished) break;
            }

            Console.WriteLine(result);

        }
    }
}
