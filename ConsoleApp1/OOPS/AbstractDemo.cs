using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.OOPS
{
    class Bike
    {
        public int mileage1 = 65;
        public string color1 = "Black";
        private string formula1 = "a*b";

        //Its public - so accessible outside class
        public int GetMileage1()
        {
            return mileage1;
        }

        //Its public - so accessible outside class
        public string GetColor1()
        {
            return color1;
        }
        //Its private - so not accessible outside class
        private string GetEngineMakeFormula1()
        {
            return formula1;
        }
        //Its public - so accessible outside class
        public string DisplayMakeFormula1()
        {
            //"GetEngineMakeFormula()" is private but accessible and limited to this class only
            return GetEngineMakeFormula1();
        }
    }
    
    class AbstractDemo
    {
        static void Main(string[] args)
        {
            Bike objBike = new Bike();
            //accessible outside "Bike"
            Console.WriteLine("Bike mileage is : " + objBike.GetMileage1());
            //accessible outside "Bike"
            Console.WriteLine("Bike color is : " + objBike.GetColor1());
            //we can't call this method as it is inaccessible outside "Bike"
            //commented because we can't access it
            //objBike.GetEngineMakeFormula();
            //accessible outside
            Console.WriteLine("Bike color is : " + objBike.DisplayMakeFormula1());
            Console.Read();
        }
    }
}
