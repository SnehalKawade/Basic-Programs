using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Test
{
    class TQ2
    {
        //Write a program to print all factors of given numbers.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Factors of " + number + " are:  ");

           
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
