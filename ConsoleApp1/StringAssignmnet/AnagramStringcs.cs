using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.StringAssignmnet
{
    //8.Write a program to check whether two strings are anagram or not?
    class AnagramStringcs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st string");
            string s1 = Console.ReadLine();

            Console.WriteLine("Enter 2nd string");
            string s2 = Console.ReadLine();

            char[] c1 = s1.ToLower().ToCharArray();
            char[] c2 = s2.ToLower().ToCharArray();

            Array.Sort(c1);
            Array.Sort(c2);

            string res1 = new string(c1);
            string res2 = new string(c2);

            if(res1.CompareTo(res2)==0)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not anagram");
            }

            /*if(res1==res2)
                Console.WriteLine("Strings are Anagram");
            else
                Console.WriteLine("String are not Anagram");*/
        }
    }
}
