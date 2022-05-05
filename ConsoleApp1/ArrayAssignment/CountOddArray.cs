using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ArrayAssignment
{
    //count odd element from the array.
    class CountOddArray
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int oddcount = 0;
            Console.WriteLine("Enter a elemnts");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    oddcount++;
                }
            }
            Console.WriteLine("Count odd elements:" + oddcount);
        }
    }
}
