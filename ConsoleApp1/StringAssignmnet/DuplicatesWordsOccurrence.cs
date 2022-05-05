using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.StringAssignmnet
{
    //Write a  program to find the duplicate words and their number of occurrences in a string.
    class DuplicatesWordsOccurrence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            string[] s1 = str.Split(' ');
            for(int i=0;i<s1.Length;i++)
            {
                int c = 0;
                for(int j=0;j<s1.Length;j++)
                {
                    if (s1[i] == s1[j] && j < i)
                        break;
                    else if (s1[i] == s1[j])
                        c++;
                }
               if(c>0)
                    Console.WriteLine($"Occurrences of :{s1[i]}={c} ");
            }
        }

    }
}
