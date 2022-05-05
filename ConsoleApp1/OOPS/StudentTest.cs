using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.OOPS
{
    //Create a class named Student,with private fields for age, name and percent.
    //we cannot directly access these fields from outside the class scope, but we can have properties
    //for accessing these private fields.
    
    class Student
    {
        string sname;
        int per;
        int age;

        public void SetSname(string nm)
        {
            sname = nm;
        }

        public void SetPercetage(int p)
        {
            per = p;
        }

        public void SetAge(int a)
        {
            age = a;
        }

        public string GetName()
        {
            return sname;
        }
        public int GetPercetage()
        {
            return per;
        }

        public int GetAge()
        {
            return age;
        }     

    }
    class StudentTest
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.WriteLine("Enter Student name,percetage,age");
            string sn = Console.ReadLine();
            s1.SetSname(sn);

            int pr = Convert.ToInt32(Console.ReadLine());
            s1.SetPercetage(pr);

            int ag = Convert.ToInt32(Console.ReadLine());
            s1.SetAge(ag);

            Student s2 = new Student();
            string sn1 = Console.ReadLine();
            s2.SetSname(sn1);

            int pr1 = Convert.ToInt32(Console.ReadLine());
            s2.SetPercetage(pr1);

            int ag1 = Convert.ToInt32(Console.ReadLine());
            s2.SetAge(ag1);

            Console.WriteLine("........Student details..........");
            Console.WriteLine(s1.GetName());
            Console.WriteLine(s1.GetPercetage());
            Console.WriteLine(s1.GetAge());

            Console.WriteLine(s2.GetName());
            Console.WriteLine(s2.GetPercetage());
            Console.WriteLine(s2.GetAge());
        }
    }
}
