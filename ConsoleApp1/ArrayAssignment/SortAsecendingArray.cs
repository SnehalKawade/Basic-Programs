using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ArrayAssignment
{
    //WAP sort array elements in ascending order.
    class SortAsecendingArray
    {
        static void Main(string[] args)
        {
            // declaring and initializing the array
            int[] arr = new int[] { 1, 9, 6, 7, 5, 9, 10, 21, 2, 29 };

            // Sort array in ascending order.
            Array.Sort(arr);

            // print all element of array
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
        }
    }
}
