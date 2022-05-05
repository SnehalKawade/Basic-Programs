using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ArrayAssignment
{
    //1.Merging elements of two different arrays alternatively in third array.
     // Input : arr1[] = {1, 2, 3, 4, 5, 6, 7, 8}
     // arr2[] = { 11, 22, 33, 44}
     //  Output: { 1, 11, 2, 22, 3, 33, 4, 44, 5, 6, 7, 8}

class MergeAlternate
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1,2,3,4,5,6,7,8};
            int n1 = arr1.Length;
            int[] arr2 = { 11, 22, 33, 44 };
            int n2 = arr2.Length;
            int[] c = new int[n1 + n2];
            int j = 0, i = 0, k = 0;

            while (i < n1 && j < n2)
            {
                c[k++] = arr1[i++];
                c[k++] = arr2[j++];

            }
            while (i < n1)
                c[k++] = arr1[i++];
            while (j < n2)
                c[k++] = arr2[j++];

            Console.WriteLine("Array After merging");
            for (i = 0; i < n1 + n2; i++)
            {
                Console.Write(c[i] + "  ");
                //Console.WriteLine($"c[{i}]={c[i]}");
            }
        }
    }
}
