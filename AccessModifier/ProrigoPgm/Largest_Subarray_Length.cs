using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier.ProrigoPgm
{
    //given array containing only 0s and 1s.find the length of the largest subarray containing an equal number of 0s and 1s.
    class largest_subarray_length
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            int j;
            int max = 0;
            int zero, ones = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                zero = 0;
                ones = 0;
                for (j = i; j < arr.Length; j++)
                {
                    if (arr[j] == 0)
                        zero++;
                    else
                        ones++;

                    if (zero == ones)
                    {
                        max = max > (j - i + 1) ? max : j - i + 1;
                    }
                }

            }
           // Console.WriteLine("*************");
            Console.WriteLine(max);
        }
    }

}
