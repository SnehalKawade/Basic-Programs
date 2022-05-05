﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ArrayAssignment
{
    //5.WAP to merge 2 arrays to 3rd array. 3rd array should not have elements of the same value.
    class MergeArray3
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 3, 5, 7, 9, 11 };
            int n1 = arr1.Length;

            int[] arr2 = new int[] { 2, 4, 6, 8,9 };
            int n2 = arr2.Length;

            int[] arr3 = new int[n1 + n2];

            
                int i = 0, j = 0, k = 0;

                // Traverse both array
                while (i < n1 && j < n2)
                {
                    arr3[k++] = arr1[i++];
                    arr3[k++] = arr2[j++];
                }

                // Store remaining elements of first array
                while (i < n1)
                    arr3[k++] = arr1[i++];

                // Store remaining elements of second array
                while (j < n2)
                    arr3[k++] = arr2[j++];

                Console.WriteLine("Array after merging");
                for (i = 0; i < n1 + n2; i++)
                {
                Console.Write(arr3[i] + " ");
            }
            
        }
    }
}
