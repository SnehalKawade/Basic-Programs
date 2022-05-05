using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 45, 67, 89, 90, 100, 345, 678 };
            Console.WriteLine("Enter search element ");
            int search = int.Parse(Console.ReadLine());
            int start = 0, end = arr.Length - 1;
            int flag = 0;
            while(start<=end)
            {
                int mid = (start + end);
                if (arr[mid] == search)
                {
                    Console.WriteLine("Element found at position " + mid);
                    flag = 1;
                    break;
                }
                else if (search > arr[mid])
                {
                    start = mid + 1;
                }
                else
                    end = mid - 1;
            }
        }
    }
}
