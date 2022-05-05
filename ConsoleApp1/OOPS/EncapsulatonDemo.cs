using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.OOPS
{
    public class Bike1
    {
        public int mileage = 65;
        public string color = "Black";
        private string formula = "a*b";

        //Its public - so accessible outside class
        public int GetMileage()
        {
            return mileage;
        }

        //Its public - so accessible outside class
        public string GetColor()
        {
            return color;
        }
        //Its private - so not accessible outside class
        private string GetEngineMakeFormula()
        {
            return formula;
        }
    }
    class EncapsulatonDemo
    {
        static void Main(string[] args)
        {
            Bike1 objBike = new Bike1();
            //accessible outside "Bike"
            Console.WriteLine("Bike mileage is : " + objBike.GetMileage());
            //accessible outside "Bike"
            Console.WriteLine("Bike color is : " + objBike.GetColor());
            //we can't call this method as it is inaccessible outside "Bike"
            //objBike.GetEngineMakeFormula(); //commented because we can't access it
            Console.Read();
        }
    }
}
