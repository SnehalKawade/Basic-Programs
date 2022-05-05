using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Arrays
{
    class SumOfArray
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            int[] b = { 11, 22, 33, 44 };
            int[] c = new int[a.Length + b.Length];
           
            Console.WriteLine("Array element of a :");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"a[{i}]={a[i]}");
            }
            Console.WriteLine("Array element of b :");
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine($"b[{i}]={b[i]}");
            }
            Console.WriteLine("Sum of Two Array: ");
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = a[i] + b[i];
                Console.WriteLine($"c[{i}]={c[i]}");
               
            }
        }
    }
}
