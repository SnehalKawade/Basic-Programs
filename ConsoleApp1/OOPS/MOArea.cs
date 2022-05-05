using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.OOPS
{
    //write a program to find area od square, reactangle and circle using method overloading.
    class AreaDemo
    {
        public void Area(float x)
        {
            //Console.WriteLine("The area of the square is "+Math.Pow(x,2)+" sq units");
           Console.WriteLine("The area of the square is "+(x*x)+" sq unit");

        }

        public void Area(float x,float y)
        {
            Console.WriteLine("The area of the reactangle is "+(x*y)+" sq units");
        }

        public void Area(double x)
        {
            double z = 3.14 * x * x;
            Console.WriteLine("The area of the circle is "+z+" sq units");
        }
            

}
    class MOArea
    {
        static void Main(string[] args)
        {
            AreaDemo a1 = new AreaDemo();
            a1.Area(5);
            a1.Area(11, 12);
            a1.Area(2.5);
        }
    }
}
