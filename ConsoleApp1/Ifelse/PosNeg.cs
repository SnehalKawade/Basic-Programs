using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.IfElse
{
    class PosNeg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num>0)
            {
                Console.WriteLine("Positive");
            }
            else if(num<0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }
    }
}
