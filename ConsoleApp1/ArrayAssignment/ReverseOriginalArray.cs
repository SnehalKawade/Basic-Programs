using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ArrayAssignment
{
    class ReverseOriginalArray
    {
        //7.WAP to reverse the array itself, don’t print array in reverse – I want the current array reverse. Means
        //e.g. arr[] = [3, 90, 45, 29, 37, 78] so your same array must be [78, 37, 29, 45, 90, 3]
        //without using a temporary array.
        static void Main(string[] args)
        {
            int[] intArray = { 10, 20, 30, 40, 50, 60, 70, 78, 80, 90 };
            int n = intArray.Length;
            Console.WriteLine("Original Array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(intArray[i] + "  ");
            }
            Console.WriteLine();

            Console.WriteLine("Original Array printed in reverse order:");
            for (int i = n - 1; i >= 0; i--)
                Console.Write(intArray[i] + "  ");

        }
    }
}
