using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.IfElse
{
    class SimpleCAL
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1.Addition 2.Subtraction 3.Multiplication 4.Division");
            int ch = Convert.ToInt32(Console.ReadLine());

            if(ch==1)
            {
                Console.WriteLine("Addition= "+ (n1 + n2));
            }

            else if(ch == 2)
            {
                Console.WriteLine("Subtraction= " + (n1 - n2));
            }

            else if (ch == 3)
            {
                Console.WriteLine("Multiplication= " + (n1 * n2));
            }

            else if (ch == 4)
            {
                Console.WriteLine("Division= " + (n1 / n2));
            }


        }
    }
}
