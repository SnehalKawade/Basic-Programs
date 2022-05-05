using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.StringAssignmnet
{
    //10.WAP to find longest word in the given sentence.
    class LongestWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentences");
            string text = Console.ReadLine();
            string[] str = text.Split(' ');
            string lword = str[0];
            for (int i = 0; i < str.Length; i++)
            {
                if (lword.Length <= str[i].Length)
                {
                    lword = str[i];
                }
            }

            Console.WriteLine("Longest word is:" + lword);
        }
    }
}
