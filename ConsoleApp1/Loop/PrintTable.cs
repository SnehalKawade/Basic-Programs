using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Loop
{
    class PrintTable
    {
        static void Main(string[] args)
        {
			int n, i;
			Console.WriteLine("Enter a digits");
			n= Convert.ToInt32(Console.ReadLine());

			for (i = 1; i <= 10; i++)
			{
				Console.WriteLine(n + " * " + i + " = " + n * i);
			}
		}
    }
}
