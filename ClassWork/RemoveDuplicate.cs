﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class RemoveDuplicate
    {
        static void Main(string[] args)
        {

            int[] a1 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] a2 = { 2, 3, 90, 89, 90, 9, 2 };
            int[] a3 = new int[a1.Length + a2.Length];

            int k = 0;
            for (int i = 0; i < a1.Length; i++)
            {
                int data = a1[i];
                if (Array.IndexOf(a3, data) == -1)
                    a3[k++] = data;
            }

            for (int i = 0; i < a2.Length; i++)
            {
                int data = a2[i];
                if (Array.IndexOf(a3, data) == -1)
                    a3[k++] = data;
            }

            Array.ForEach(a3, Console.WriteLine);
        }
    }
}
