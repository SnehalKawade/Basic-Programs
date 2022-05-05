using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.StringAssignmnet
{
    //7.Write a program to check whether given string is palindrome or not.
    class StringPalindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            bool flag = true;
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]!=str[str.Length-i-1])
                {
                    flag = false;
                    break;
                }
            }
            if(flag)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
        }
    }
}
