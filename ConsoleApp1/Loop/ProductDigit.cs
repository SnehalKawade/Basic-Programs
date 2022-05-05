using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Loop
{
    class ProductDigit
    {
        static void Main(string[] args)
        {
			int num, temp;
			int product = 1;

			// Take input from user
			Console.WriteLine("Enter a digits");
			num = Convert.ToInt32(Console.ReadLine());


			temp = num;

			while (temp != 0)
			{

				product = product * (temp % 10);

				// Remove last digit from temp.
				temp = temp / 10;
			}

			Console.WriteLine("\nProduct of all digits in " + num + " : " + product);

		}
	}
}
