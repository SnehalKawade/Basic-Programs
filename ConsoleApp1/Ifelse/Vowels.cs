using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.IfElse
{
    class Vowels
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character");
            char ch = Convert.ToChar(Console.Read());

            if (ch == 'a')
            {
                Console.WriteLine(ch+" is Vowels");
            }

            else if (ch == 'e')
            {
                Console.WriteLine(ch + " is Vowels");
            }

            else if (ch == 'i')
            {
                Console.WriteLine(ch + " is Vowels");
            }

            else if (ch == 'o')
            {
                Console.WriteLine(ch + " is Vowels");
            }

            else if (ch == 'u')
            {
                Console.WriteLine(ch + " is Vowels");
            }
            else
            {
                Console.WriteLine(ch+" is Consonant");
            }
        }
    }
}
