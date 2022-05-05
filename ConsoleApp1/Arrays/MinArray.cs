using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Arrays
{
    class MinArray
    {
        static void Main(string[] args)
        {
            //int [] a = { 4, 7, 5, 2, 8, 1 };
            Console.WriteLine("Enter size");
			int size = Convert.ToInt32(Console.ReadLine());
			int[] a = new int[size];
			int min = int.MaxValue;
			Console.WriteLine("Enter a element");
			for (int i = 0; i < size; i++)
			{ 
                a[i] = Convert.ToInt32(Console.ReadLine());
				
				if (a[i] < min)
				{
					min = a[i];
				}
			}
            Console.WriteLine("Min= " + min);

		}
	}
}
