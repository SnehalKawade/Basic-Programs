using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.StringAssignmnet
{
    class OccurrenceWordString
    {
        static void Main(string[] args)
        {
            string str = "india is my country and india is the best";
            string word = "best";

            string[] s1 = str.Split();
            int c = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (word == (s1[i]))
                {
                    c++;
                }
            }

            Console.WriteLine(c);

        }
    }
}
