using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.OOPS
{
    //Create one class Employee (id,name,salary) with private access modifier and
    //create properties to expose the variables.
    class Employee
    {
        int eid;
        string ename;
        int salary;
        public void SetEmployeeId(int id)
        {
            eid = id;
        }
        public void SetEmployeeName(string name)
        {
            ename = name;
        }
        public void SetEmployeeSalary(int sal)
        {
            salary = sal;
        }
        public int GetEmployeeId()
        {
            return eid;
        }
        public string GetEmployeeName()
        {
            return ename;
        }
        public int GetEmployeeSalary()
        {
            return salary;
        }
    }
    class EmployeeTest
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Console.WriteLine("Enter employee id,name,salary: ");
            int id = Convert.ToInt32(Console.ReadLine());
            e1.SetEmployeeId(id);

            string sn = Console.ReadLine();
            e1.SetEmployeeName(sn);

            int s = Convert.ToInt32(Console.ReadLine());
            e1.SetEmployeeSalary(s);

            Employee e2 = new Employee();
            int id1 = Convert.ToInt32(Console.ReadLine());
            e2.SetEmployeeId(id1);

            string sn1 = Console.ReadLine();
            e2.SetEmployeeName(sn1);

            int s1 = Convert.ToInt32(Console.ReadLine());
            e2.SetEmployeeSalary(s1);

            Console.WriteLine("..........Employee details..........");
            Console.WriteLine(e1.GetEmployeeId());
            Console.WriteLine(e1.GetEmployeeName());
            Console.WriteLine(e1.GetEmployeeSalary());

            Console.WriteLine(e2.GetEmployeeId());
            Console.WriteLine(e2.GetEmployeeName());
            Console.WriteLine(e2.GetEmployeeSalary());
        }
    }
}
