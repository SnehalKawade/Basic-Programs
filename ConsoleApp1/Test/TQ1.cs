using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Test
{
    //Write a program to check given number is spy number or not.
    class TQ1
    {
        static void Main(string[] args)
        {
			int n, product = 1, sum = 0;
			int ld;

            Console.WriteLine("Enter a number");
			n = Convert.ToInt32(Console.ReadLine());

			while (n > 0)
			{
				ld = n % 10;
				sum = sum + ld;
				product = product * ld;
				n = n / 10;
			}

			
			if (sum == product)
                Console.WriteLine("Given number is spy number");
		else
                Console.WriteLine("Given number is not spy number");
		}
    }
}
