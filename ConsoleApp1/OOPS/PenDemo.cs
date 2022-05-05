using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.OOPS
{
    class Pen
    {
        string brand;
        string color;
        int price;

        public Pen()
        {
            Console.WriteLine("It is pen constructor");
        }
        public void SetBrand(string b)
        {
            brand = b;
        }

        public void SetColor(string c)
        {
            color = c;
        }

        public void SetPrice(int p)
        {
            price = p;
        }

        public string GetBrand()
        {
            return brand;
        }

        public string GetColor()
        {
            return color;
        }

        public int GetPrice()
        {
            return price;
        }
    }
    class PenDemo
    {
        static void Main(string[] args)
        {
            Pen p1 = new Pen();
            
            Console.WriteLine("Enter pen brand,color,price");
            string b1 = Console.ReadLine();
            p1.SetBrand(b1);

            string c1 = Console.ReadLine();
            p1.SetColor(c1);

            int pr = Convert.ToInt32(Console.ReadLine());
            p1.SetPrice(pr);

            Console.WriteLine("......Pen Details......");
            Console.WriteLine(p1.GetBrand());
            Console.WriteLine(p1.GetColor());
            Console.WriteLine(p1.GetPrice());

            /* string b2 = Console.ReadLine();
             p2.SetBrand(b2);

             string c2 = Console.ReadLine();
             p2.SetColor(c2);

             int pr1 = Convert.ToInt32(Console.ReadLine());
             p2.SetPrice(pr1);

             Console.WriteLine(p2.GetBrand());
             Console.WriteLine(p2.GetColor());
             Console.WriteLine(p2.GetPrice());  */

            Pen p2 = new Pen();
            p2.SetBrand("Gelpen");
            p2.SetColor("Blue");
            p2.SetPrice(20);

            Console.WriteLine($"Brand: {p2.GetBrand()} Color: {p2.GetColor()} Price: {p2.GetPrice()}");

        }
    }
}
