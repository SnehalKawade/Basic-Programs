using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Containment
{
    class SalaryBased:Teacher1
    {
        int salary;
        
        public void Salary()
        {
            Console.WriteLine("salary is "+salary);
        }
        public SalaryBased()
        {
            Console.WriteLine("In salary default constructor");
        }

        public SalaryBased(int salary)
        {
            this.salary = salary;
        }

    }

    class TeacherTest
    {
        static void Main(string[] args)
        {
            SalaryBased s1 = new SalaryBased(15000);
            s1.Salary();
            HourlyBased h1 = new HourlyBased();
            h1.Salary(500,10);
        }
    }
}
