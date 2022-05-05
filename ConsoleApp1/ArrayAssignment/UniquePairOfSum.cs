using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ArrayAssignment
{
    //13.To Find unique Pair Of Integers in Array whose Sum is Given Number 
   // Given array : [2, 4, 3, 5, 6, -2, 4, 7, 8, 9]
   // Given sum : 7 Integer numbers,
   // whose sum is equal to value : 7
    //(2, 5) (4, 3) (-2, 9) 

    class UniquePairOfSum
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 7, -1, 5 };
            int sum = 10;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if ((arr[i] + arr[j]) == sum)
                    {
                        Console.WriteLine("[" + arr[i] + " " + arr[j] + "]");
                    }
                }
            }
        }

    }
}
