using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class DiagonalArray
    {
        static void Main(string[] args)
        {
            int[,]a2=
            {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12}
            };
            for (int r = 0; r < a2.GetLength(0); r++)
            {
                for (int c = 0; c < a2.GetLength(1); c++)
                {
                    if (r == c || r + c == a2.GetLength(0) - 1)
                    {
                        Console.Write(a2[r, c]);
                    }
                    else
                        Console.Write(" "); 
                   
                }
                Console.WriteLine();
            }
        }
    }
}
