using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ArrayAssignment
{
    class Array2D
    {
        //14.WAP to accept data in 2D array of 3X4 and accept data.
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int[,] a2 = new int[3, 4];
            Console.WriteLine(a2.Length);
            for (int r = 0; r < a2.GetLength(0); r++)
            {
                Console.WriteLine("Enter elements on row " + r);
                for (int c = 0; c < a2.GetLength(1); c++)
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
        }
    }
}
