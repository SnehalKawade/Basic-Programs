using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Loop
{
    class PrimeNo
    {
        static void Main(string[] args)
        {
			for (int i = 400; i > 300; i--)
			{
				Boolean isPrime = true;
				for (int j = 2; j < i; j++)
				{
					if (i % j == 0)
					{
						isPrime = false;
						break;
					}
				}

				if (isPrime)
				{
					Console.WriteLine(i);
				}
			}

		}
	}
}
