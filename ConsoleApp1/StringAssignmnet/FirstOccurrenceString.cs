using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.StringAssignmnet
{
    //2.Write a program to find first occurrence of a character in a given string.
    class FirstOccurrenceString
    {
        static void Main(string[] args)
        {
            string str;
            char ch;
            int i = 0;
            int flag = 0;

            Console.WriteLine("Enter a string");
            str = Console.ReadLine();

            Console.WriteLine("Enter a charater");
            ch = Convert.ToChar(Console.ReadLine());

            for(i=0;i<=str.Length;i++)
            {
                if(str[i]==ch)
                {
                    flag++;
                    break;
                }
            }
            if(flag==0)
                Console.WriteLine("Sorry!! charater not found.....");
            else
                Console.WriteLine($"The first character occurrence of {ch} at position: {i}");

        }
    }
}
