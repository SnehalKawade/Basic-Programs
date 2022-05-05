using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.StringAssignmnet
{
    //5.Write a program to count total number of words in a string.
    class CountWordString
    {
        static void Main(string[] args)
        {
            int c = 0, word = 1;
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            while(c<=str.Length-1)
            {
                if(str[c]==' ' || str[c]=='\n' ||str[c]=='\t')
                {
                    word++;
                }
                c++;
            }
            Console.WriteLine("Number of words in the string: {0}",word);
        }
    }
}
