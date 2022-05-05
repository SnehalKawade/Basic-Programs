using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ArrayAssignment
{
		//4.How to rearrange array in alternating positive and negative number.
		//	Input: {1, 2, 3, -4, -1, 4}
		//	Output: { -4, 1, -1, 2, 3, 4}

	class RearrangePosNeg
	{
		static void rightrotate(int[] arr, int n,int outofplace, int cur)
		{
			int tmp = arr[cur];
			for (int i = cur; i > outofplace; i--)
				arr[i] = arr[i - 1];
			    arr[outofplace] = tmp;
		}
        static void rearrange(int[] arr, int n)
        {
            int outofplace = -1;

            for (int index = 0; index < n; index++)
            {
                if (outofplace >= 0)
                {
                    if (((arr[index] >= 0) && (arr[outofplace] < 0))
                        || ((arr[index] < 0) && (arr[outofplace] >= 0)))
                    {
                        rightrotate(arr, n, outofplace, index);

                        if (index - outofplace > 2)
                            outofplace = outofplace + 2;
                        else
                            outofplace = -1;
                    }
                }

                // if no entry has been flagged out-of-place
                if (outofplace == -1)
                {
                    // check if current entry is out-of-place
                    if (((arr[index] >= 0) && ((index & 0x01) == 0))
                        || ((arr[index] < 0) && (index & 0x01) == 1))
                        outofplace = index;
                }
            }
        }

        static void printArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine("");
        }

        static void Main(string[] args)
			{
					int[] arr = { 1, 2, 3, -4, -1, 4 };
					int n = arr.Length;

					Console.WriteLine("Given array is ");
					printArray(arr, n);

					rearrange(arr, n);

					Console.WriteLine("RearrangeD array is ");
					printArray(arr, n);
			}


    }
}
