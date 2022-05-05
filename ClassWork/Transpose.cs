using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Transpose
    {
        static void Main(string[] args)
        {
            int[,] a2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] b2 = new int[a2.GetLength(0), a2.GetLength(1)];
          
            for(int r=0;r<a2.GetLength(0);r++)
            {
                
                for (int c=0;c<a2.GetLength(0);c++)
                {
                    b2[r, c] = a2[c, r];
                    Console.Write(b2[r, c]+" ");
                }
                Console.WriteLine(); 
            }
            
        }
    }
}
