using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.IfElse
{
    class Divisible
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            if(num%5==0 && num%11==0)
            {
                Console.WriteLine("Given number "+num+" is divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine("Given number " + num + " is not divisible by 5 and 11");
            }
        }
    }
}
