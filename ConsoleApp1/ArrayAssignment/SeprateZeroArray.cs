using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ArrayAssignment
{
    //5.Write a program to separate zeros from non-zeros in an integer array?
    //InputArray:[12,0,7,0,8,0,3]
    //Output: [12,7,8,3,0,0,0]

    class SeprateZeroArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 0, 7, 0, 8, 0, 3 };
            int j = 0;

            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]>0)
                {
                    if(i!=j)
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                    j++;
                }
            }
            foreach(int x in arr)
            {
                Console.Write(x+" ");
            }
        }
    }
}
