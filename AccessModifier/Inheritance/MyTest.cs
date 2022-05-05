using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier.Inheritance
{
    class HourlyBasedTeacher:Teacher
    {
        int hrs, rate;

        public HourlyBasedTeacher()
        {
            Console.WriteLine("In hourly default constructor");
        }

        public int Hrs
        {
            set { hrs = value; }
            get { return hrs; }
        }

        public int Rate
        {
            set { rate = value; }
            get { return rate;}
        }
    }
    class MyTest
    {
        static void Main(string[] args)
        {
            Teacher t1 = new Teacher();
            t1.Tname = "Deepa";
            t1.Experinace = 15;
            t1.Subject = "C#";

            PermanentTeacher p1 = new PermanentTeacher();
            p1.Tname = "Medha";
            p1.Salary = 70000;
            p1.Experinace = 15;
            p1.Subject = "Java";


            HourlyBasedTeacher h1 = new HourlyBasedTeacher();
            h1.Tname = "Kirti";
            h1.Experinace = 10;
            h1.Subject = "Python";
            h1.Hrs = 40;
            h1.Rate = 2000;

            Console.WriteLine(".....Teacher Details.....");
            Console.WriteLine(t1.Tname);
            Console.WriteLine(t1.Experinace);
            Console.WriteLine(t1.Subject);

            Console.WriteLine(".......Permanent Teacher Detalis.......");
            Console.WriteLine(p1.Tname);
            Console.WriteLine(p1.Salary);
            Console.WriteLine(p1.Experinace);
            Console.WriteLine(p1.Subject);

            Console.WriteLine("........Hourlybased Teacher Details.......");
            Console.WriteLine(h1.Tname);
            Console.WriteLine(h1.Experinace);
            Console.WriteLine(h1.Subject);
            Console.WriteLine(h1.Hrs);
            Console.WriteLine(h1.Rate);

        }
    }
}
