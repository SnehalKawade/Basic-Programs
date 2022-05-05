using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.IfElse
{
    class MaximumNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            int b= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 3rd number");
            int c = Convert.ToInt32(Console.ReadLine());

            if(a>b && a>c)
            {
                Console.WriteLine(a+ " is Greatest Number");
            }
            else if(b>c && b>a)
            {
                Console.WriteLine(b+ " is Greatest Number");
            }
            else
            {
                Console.WriteLine(c+ " is Greatest Number");
            }
        }
    }
}
