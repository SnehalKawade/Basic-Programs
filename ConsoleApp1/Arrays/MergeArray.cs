using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Arrays
{
    class MergeArray
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 5, 7, 9 };
            int[] b = { 11, 22, 33, 44 };
            int[] c = new int[a.Length + b.Length];
            int j = 0;
            Console.WriteLine("Array element of a :");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
                c[j] = a[i];
                j++;
            }
            Console.WriteLine("Array element of b :");
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
                c[j] = b[i];
                j++;
            }
            Console.WriteLine("Merge Array: ");
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }
        }
    }
}
