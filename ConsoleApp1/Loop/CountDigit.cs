using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Loop
{
    class CountDigit
    {
        static void Main(string[] args)
        {
			int count = 0;
			int num;
			Console.WriteLine("Enter a digits");
			num = Convert.ToInt32(Console.ReadLine());

			while (num != 0)
			{
				//int r=num%10;
				num = num / 10;
				count++;
			}
			Console.WriteLine("Number of digits: " + count);

		}
	}
}
