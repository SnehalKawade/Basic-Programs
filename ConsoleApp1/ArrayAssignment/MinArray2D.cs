using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ArrayAssignment
{
    //17.WAP to print minimum in columns.
    //Means e.g.arr[][]={ { 22, 31, 9}, { 12, 5,16}, { 34, 42, 2} }
   // output is: 12, 5, 
    class MinArray2D
    {
        static void Main(string[] args)
        {
            int[,] a2d = { { 22, 31, 9 }, { 12, 25, 16 },{ 34, 42, 2 } };
            int min=int.MaxValue;
            for (int r = 0; r < a2d.GetLength(0); r++)
            {
                for (int c = 0; c < a2d.GetLength(1); c++)
                {
                    if (a2d[r, c] < min)
                        min = a2d[r, c];
                }     
            }
            Console.WriteLine($"Min is {min}");
        }
    }
}
