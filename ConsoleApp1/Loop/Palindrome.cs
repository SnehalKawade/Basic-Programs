using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Loop
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a range in numbers(num1-num2):");
            int range1 = Convert.ToInt32(Console.ReadLine());
            int range2 = Convert.ToInt32(Console.ReadLine());
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine(range1 + " to " + range2 + " palindrome numbers are");
            for (int i = range1; i <= range2; i++)
            {
                num1 = i;
                num2 = 0;
                while (num1 != 0)
                {
                    int rem = num1 % 10;
                    num1 /= 10;
                    num2 = num2 * 10 + rem;
                }

                if (i == num2)
                    Console.WriteLine(i + " ");
            }

        }
    }
}
