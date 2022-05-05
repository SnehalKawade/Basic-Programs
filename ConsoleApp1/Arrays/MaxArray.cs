using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Arrays
{
    class MaxArray
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Enter size");
			int size = Convert.ToInt32(Console.ReadLine());
			int[] a = new int[size];
			int max = int.MinValue;
			Console.WriteLine("Enter a element");
			for (int i = 0; i < size; i++)
			{
				a[i] = Convert.ToInt32(Console.ReadLine());

				if (a[i] > max)
				{
					max = a[i];
				}
			}
			Console.WriteLine("Max= " + max);
		}
    }
}
