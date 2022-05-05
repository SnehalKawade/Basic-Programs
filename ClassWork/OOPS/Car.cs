using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.OOPS
{
    class Car
    {
        string brand;
        string color;
        long price;


        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.brand = "BMW";
            c1.color = "Black";
            c1.price = 500000L;


            Car c2 = new Car();
            c2.brand = "Oddddi";
            c2.color = "White";
            c2.price = 400000L;

            Console.WriteLine($"Brand={c1.brand},Color={c1.color}, Price={c1.price}");
            Console.WriteLine($"Brand={c2.brand},Color={c2.color}, Price={c2.price}");

        }



    }
}
