using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
	class MockPgmP
	{
		static void Main(string[] args)
		{
			for (int i = 1; i < 100; i++)
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
