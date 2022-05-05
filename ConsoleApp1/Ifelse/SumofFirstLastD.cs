using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Ifelse
{
    class SumofFirstLastD
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0, fd, ld;
           
            if (num > 99 && num < 1000)
            {
                ld = num % 10;
                while (num >= 10)
                {
                    num = num / 10;
                }
                fd = num;
                sum = fd + ld;
                Console.WriteLine("The Sum of 1st & 3rd digit: " + sum);

            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
