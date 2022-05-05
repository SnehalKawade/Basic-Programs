using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.OOPS
{
    class MethodOver
    {
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }

        
        public double Add(double a,double b, double c)
        {
            double sum = a + b + c;
            return sum;
        }
    }
    class MethodOverloadingDemo
    {
        public static void Main(string[] args)
        {
            MethodOver ob = new MethodOver();

            int sum2 = ob.Add(1, 2, 3);
            Console.WriteLine("sum of the three "+ "integer value : " + sum2);
            double sum3 = ob.Add(1.0, 2.0, 3.0);
            Console.WriteLine("sum of the three " + "double value : " + sum3);
        }
    }
}

