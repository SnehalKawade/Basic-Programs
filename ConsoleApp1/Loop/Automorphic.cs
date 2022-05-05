using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Loop
{
    class Automorphic
    {
        static void Main(string[] args)
        {
			int a, s, c = 1, n;
			Console.WriteLine("Enter a digits");
			n = Convert.ToInt32(Console.ReadLine());

			a = n;

			s = n * n;

			while (n != 0)

			{

				c = c * 10;

				n = n / 10;

			}

			if (s % c == a)
			{

				Console.WriteLine("Automorphic Number");
			}
			else
			{

				Console.WriteLine("Not Automorphic Number");

			}

		}
	}
}
