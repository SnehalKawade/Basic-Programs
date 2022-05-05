using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier.Inheritance
{
    class PermanentTeacher:Teacher
    {
     //   string tname;
     //   int experiance;
     //   string subject;
        int salary;
        public PermanentTeacher():base()
        {
            Console.WriteLine("In default of permanent");
        }

        public PermanentTeacher(string tnm,int exp,string sub,int sal):base(tnm,exp,sub)
        {
            salary = sal;
        }

        public int Salary
        {
            set { salary = value; }
            get { return salary; }
        }
    }
}
