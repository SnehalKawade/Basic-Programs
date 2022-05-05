using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.StringAssignmnet
{
    //6.Write a program to find first occurrence of a word in a given string.
    class FirstOccurrenceWord
    {
        static void Main(string[] args)
        {
            string str;
            string word;
            

            Console.WriteLine("Enter a string");
            str = Console.ReadLine();

            Console.WriteLine("Enter a word");
            word= Console.ReadLine();

            int index = str.IndexOf(word);
            Console.WriteLine("The first word occurrence: "+index);
        }
    }
}
