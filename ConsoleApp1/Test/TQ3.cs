using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Test
{
    //WAP to print number from 1 to 50 if number is even then print as it is and number is odd then print its square.
    class TQ3
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 50; i++)
                {
                if (i % 2 == 0)
                    {
                        Console.WriteLine("Even number: " + i);
                    }
                    else
                    {
                        Console.WriteLine("Odd number: " + i*i);   
                    }
                 }
            
        }
    }
}
