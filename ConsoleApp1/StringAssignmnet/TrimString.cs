using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.StringAssignmnet
{
    //4.Write a program to trim leading white space characters in a string.
    class TrimString
    {
        static void Main(string[] args)
        {
            string str1;
            Console.WriteLine("Enter a string");
            str1 = Console.ReadLine();
            Console.WriteLine(str1.Trim());
        }
    }
}
