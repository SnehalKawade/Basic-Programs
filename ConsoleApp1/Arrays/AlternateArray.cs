using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Arrays
{
    class AlternateArray
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 5, 7, 9 };
            int n1 = a.Length;
            int[] b = { 11, 22, 33, 44 };
            int n2 = b.Length;
            int[] c = new int[n1 + n2];
            int j = 0, i = 0, k = 0;
            
            while (i < n1 && j < n2)
            {
                c[k++] = a[i++];
                c[k++] = b[j++];
              
            }
            while (i < n1)
                c[k++] = a[i++];
            while (j < n2)
                c[k++] = b[j++]; 

            Console.WriteLine("Array After merging");
            for (i = 0; i < n1 + n2; i++)
            {
                //Console.WriteLine(c[i] + " ");
                Console.WriteLine($"c[{i}]={c[i]}");
            }
        }
    }
}
