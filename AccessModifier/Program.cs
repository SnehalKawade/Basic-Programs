using System;

namespace AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int m, a, c = 0, n = 379 ;
            m = n;
            while(n>0)
            {
                n = n /10;
                c++;
            }
            while(m>0)
            {
                a = m % 10;
                Console.WriteLine(c+":"+a);
                m = m / 10;
                c--;
            }
            if(m%2==0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("odd number");
            }
        }
    }
}
