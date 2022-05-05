using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.StringAssignmnet
{
    //count number of vowels from the string.
    class CountVowelsString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == ' ')
                {
                    count++;
                }
            }

            Console.WriteLine("Number of vowels:" + count);

        }
    }
}
