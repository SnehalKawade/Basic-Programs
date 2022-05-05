using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Containment
{
    //4.Design a class to overload a function volume() as follows:
    //(i) double volume(double r) – with radius ‘r’ as an argument, returns the volume of sphere using the formula
    //v = 4 / 3 × 22 / 7 × r3
    //(ii)double volume(double h, double r) – with height ‘h’ and radius ‘r’ as the arguments, returns the volume of a
    //cylinder using the formula: v = 22 / 7 × r2 × h
    //(iii) double volume(double l, double b, double h) – with length ‘l’, breadth ‘b’ and height ‘h’ as the arguments,
    //returns the volume of a cuboid using the formula: v = l × b × h

    class MOVolumn
    {
        double volume(double r)
        {
            double vol = (4 / 3.0) * (22 / 7.0) * r * r * r;
            return vol;
        }

        double volume(double h, double r)
        {
            double vol = (22 / 7.0) * r * r * h;
            return vol;
        }
        double volume(double l, double b, double h)
        {
            double vol = l * b * h;
            return vol;
        }
        static void Main(string[] args)
        {
            MOVolumn v1 = new MOVolumn();
            Console.WriteLine("Sphere Volume = " +v1.volume(6));
            Console.WriteLine("Cylinder Volume = " + v1.volume(5, 3.5));
            Console.WriteLine("Cuboid Volume = " + v1.volume(7.5, 3.5, 2));

        }
    }
}
