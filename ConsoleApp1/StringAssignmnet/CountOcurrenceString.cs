﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.StringAssignmnet
{
   // 3.Write a program to count occurrences of a character in given string.
    class CountOcurrenceString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();

            while(str.Length>0)
            {
                Console.Write(str[0]+"=");
                int cal = 0;
                for(int j=0;j<str.Length;j++)
                {
                    if(str[0]==str[j])
                    {
                        cal++;
                    }
                }
                Console.WriteLine(cal);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
            Console.ReadLine();
        }
    }
}
