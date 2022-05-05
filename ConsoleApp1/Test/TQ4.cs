using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Test
{
    //To find whether the given number is a Harshad number or not.
    class TQ4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            long num = Convert.ToInt64(Console.ReadLine());


            long temp = num;
            long sumOfDigits = 0;
            while (temp > 0)
            {
                long rem = temp % 10;
                sumOfDigits += rem;
                temp = temp / 10;
            }


            if (num % sumOfDigits == 0)
            {
                Console.WriteLine(num + " is a Harshad/Niven Number");
            }
            else
            {
                Console.WriteLine(num + " is NOT a Harshad/Niven Number");
            }
        }
    }
}
