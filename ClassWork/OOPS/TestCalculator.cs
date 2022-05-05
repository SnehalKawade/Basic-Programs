using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.OOPS
{
    class Calculator
    {
        public void add(int a,int b,int c)
        {
            int d = a + b+c;
            Console.WriteLine("Sum= "+d);
        }
        
        public int factorial(int n)
        {
            int i,fact = 1;
            for(i=1;i<=n;i++)
            {
                fact = fact * i;

            }
            return fact;
        }

        public bool isPrime(int n)
        {
            int flag = 0;
            for (int i = 2; i <n; i++)
            {
                if (n % i == 0)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                return true;
            else
            return false;
        }

        public String greet(String nm)
        {
            return "Good Afternoon " + nm;

        }


    }
    class TestCalculator
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            c1.add(10, 20,30);

            int f = c1.factorial(5);
            Console.WriteLine($"Factorial= {f}");

            bool b = c1.isPrime(4);
            Console.WriteLine($"Prime no= {b}");

            string s=c1.greet("Snehal");
            Console.WriteLine($"Greet: {s}");
        }
        
    }
}
