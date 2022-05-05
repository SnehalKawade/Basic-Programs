using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Loop
{
    class SumOfEven
    {
        static void Main(string[] args)
        {
			int i, n = 10;
			int sum = 0;
			for (i = 1; i <= n; i++)
			{
				if (i % 2 == 0)
				{
					Console.WriteLine(i);
					sum = sum + i;
				}
			}
			Console.WriteLine("Sum of Even number= " + sum);

		}
	}
}
