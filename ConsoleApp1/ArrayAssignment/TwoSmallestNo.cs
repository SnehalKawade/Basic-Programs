﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ArrayAssignment
{
    //3.WAP to find the second smallest element in an array.
    class TwoSmallestNo
    {
        static void Main(string[] args)
        {
            int n, i, j = 0, sml, sml2nd;
            int[] arr1 = new int[50];

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());
            /* Stored values into the array*/
            Console.Write("Input {0} elements in the array (value must be <9999):\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            /* find location of the smallest element in the array */
            sml = 0;
            for (i = 0; i < n; i++)
            {
                if (sml > arr1[i])
                {
                    sml = arr1[i];
                    j = i;
                }
            }

            /* ignore the smallest element and find the 2nd smallest element in the array */
            sml2nd = 99999;
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    i++;  /* ignoring the smallest element */
                    i--;
                }
                else
                {
                    if (sml2nd > arr1[i])
                    {
                        sml2nd = arr1[i];
                    }
                }
            }

            Console.Write("The Second smallest element in the array is :  {0} \n\n", sml2nd);
        }
    }
}