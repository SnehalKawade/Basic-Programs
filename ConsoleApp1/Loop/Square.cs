using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Loop
{
    class Square
    {
        static void Main(string[] args)
        {
            int square = 0;

            for (int i = 1; i <= 20; i++)
            {
                square = i * i;
                Console.WriteLine("Square of " + i + " is: " + square);
            }
        }
    }
}
