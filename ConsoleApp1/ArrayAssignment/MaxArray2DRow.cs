using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ArrayAssignment
{
    //16.WAP to print maximum in row wise in 2D array.
    //Means e.g.arr[][] = { { 22, 31, 9}, { 12, 25, 16} } output is: 31 and 25.
    class MaxArray2DRow
    {
        static void Main(string[] args)
        {

            int[,] a2d = { { 22, 31, 9 }, { 12, 25, 16 } };
            int max;
            for (int r = 0; r < a2d.GetLength(0); r++)
            {
                max = int.MinValue;
                for (int c = 0; c < a2d.GetLength(1); c++)
                {
                    if (a2d[r, c] > max)
                        max = a2d[r, c];
                }
                Console.WriteLine($"Max on row {r} is {max}");
            }

            //taking input from user 
            /*int[] a = new int[10];
            int[,] a2 = new int[3, 4];
            int max=int.MinValue;
            Console.WriteLine(a2.Length);
            for (int c = 0; c < a2.GetLength(1); c++)
            {
                
                Console.WriteLine("Enter elements on row " + c);
                for (int r = 0; r < a2.GetLength(0); r++)
                {
                    a2[r, c] = int.Parse(Console.ReadLine());
                }
            }
            for (int r = 0; r < a2.GetLength(0); r++)
            {
                for (int c = 0; c < a2.GetLength(1); c++)
                {
                    Console.Write(a2[r, c] + " ");
                }
                Console.WriteLine();
            }
            for (int r = 0; r < a2.GetLength(0); r++)
            {
                for (int c = 0; c < a2.GetLength(1); c++)
                {

                    if (a2[r, c] > max)
                    {
                        max = a2[r, c];
                    }
                }

            }
            Console.WriteLine($"Max on row {r} is {max}");  */


        }
    }
}
