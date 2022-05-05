using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Test
{
    //Write a program to find twin prime number. 
    class TQ11
    {
        static void Main(string[] args)
        {
            int n1, n2,c1=0,c2=0,d;
            

            Console.WriteLine("Enter First number:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
            n2 = Convert.ToInt32(Console.ReadLine());
           
            for(int i=2;i<=n1/2;i++)
            {
                if (i % n1 == 0)
                    c1++;
                
            }
            for (int i = 2; i <= n2/2; i++)
            {
                if (i % n2 == 0)
                    c2++;
            }
           /* d = Math.Abs(n1 - n2);
            if(d==2 && c1==2 && c2==2)
                Console.WriteLine("Twin Prime");
            else
                Console.WriteLine("Not a Twin Prime"); */

            if(c1==0 && c2==0)
            {
                if(n1-n2==2 || n2-n1==2)
                    Console.WriteLine("Twin Prime number are: "+n1+" "+n2);
                else
                    Console.WriteLine("Prime number but Not Twin");
            }
            else
                Console.WriteLine("Not prime number");
        }
    }
}

