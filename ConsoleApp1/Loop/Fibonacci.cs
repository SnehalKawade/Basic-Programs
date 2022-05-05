using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Loop
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int i = 1,n1=0,n2=1;
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            while(i<=num)
            {
                Console.WriteLine(n1+" ");
                int nxt = n1 + n2;
                n1 = n2;
                n2 = nxt;
                i++;

            }
            
            
        }
    }
}
