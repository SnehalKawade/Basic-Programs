using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ArrayAssignment
{
    //1.WAP to add elements to single dimensional int array and print elements from 1D array

    class Array1D
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Enter array element : {0}", x + 1);
                arr[x] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("The Array Elements are: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
