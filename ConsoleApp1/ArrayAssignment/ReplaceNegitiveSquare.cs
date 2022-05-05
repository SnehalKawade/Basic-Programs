using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ArrayAssignment
{
    //	WAP to replace all negative value with its immediate left elements square.
    //	Means arr[] = [12, 3,-19, 29, 5, -61, 44, 7, -9] Output array will be[12, 3, 9, 29, 5, 25, 44, 7, 49].
    class ReplaceNegitiveSquare
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };
			foreach (int e in arr)
			{
				Console.Write(e+" ");
			}
            Console.WriteLine();
            Console.WriteLine("*******************************");
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < 0)
				{
					if (arr[arr.Length - 1] < 0)
					{
						arr[arr.Length - 1] = arr[0] * arr[0];
					}
					else
					{
						arr[i] = (arr[i + 1] * arr[i + 1]);
					}
				}
			}
            Console.WriteLine();
			foreach(int e in arr)
			{
                Console.Write(e+" ");
			}
           
		}
    }
}
