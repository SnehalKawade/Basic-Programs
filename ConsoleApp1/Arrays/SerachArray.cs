using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Arrays
{
    class SerachArray
    {
        static void Main(string[] args)
        {
			int []a = { 1,90,2,91,3,92,4,93,94,95};
			Console.WriteLine("Enter number for seraching");
			int num = Convert.ToInt32(Console.ReadLine());
			bool isPresent = false;
			
			for (int i = 0; i < a.Length; i++)
			{
				if (num == a[i])
				{
					isPresent = true;
					
				}
			}

			if (isPresent)
			{
                Console.WriteLine("Number is present in Array");
			}
			else
			{
                Console.WriteLine("Number is not present in Array");
			}

		}
	}
}
