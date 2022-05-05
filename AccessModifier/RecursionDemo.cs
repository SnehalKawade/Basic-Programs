using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    class RecursionDemo
    {
        public static int factorial(int n)
        {
            if (n == 1)
                return 1;
            else
            {
                int ans = factorial(n - 1);
                return n * ans;
            }

        }
            static void Main(string[] args)
            {
                int res = factorial(5);
                Console.WriteLine("Factorial:" +res);
            }

            

        
    }
}
