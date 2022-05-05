using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Loop
{
    class HarshadNiven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number to be tested:");
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
