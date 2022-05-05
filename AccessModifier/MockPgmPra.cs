using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    class MockPgmPra
    {
		static void Main(string[] args)
		{
			
			int i;
			bool isPrime = true;
            Console.WriteLine("Enter a number");
			int n = Convert.ToInt32(Console.ReadLine());
			for (i = 2; i <= n / 2; i++)
			{
				if (n % i == 0)
				{
					isPrime = false;
					break;
				}

			}
			if (isPrime)
			{
				Console.WriteLine("prime no");
			}
            else
            {
                Console.WriteLine("Not prime");
            }
			
		}
	}
}
