using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ArrayAssignment
{
    class NegativeArray
    {
        //8.WAP to print all negative elements in an array and also count the total number of negative elements in an array.
        static void Main(string[] args)
        {

            int[] arr = new int[100];
            int i, num;

            //Enter size of array
            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Reading elements of array
            Console.WriteLine("Enter elements in array: ");
            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("All negative elements in array are: ");
            for (i = 0; i < num; i++)
            {
                //Printing negative elements
                if (arr[i] < 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
