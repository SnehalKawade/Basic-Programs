using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.OOPS
{
    class Student
    {
        //instance variable
        int sid, per;
        string name, qua;
        int poy;
        long mobile;

        public void input()
        {
            Console.WriteLine("Enter id, Name,Qualification,Percentage,Pass of year,Mobile no");
            sid = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            qua = Console.ReadLine();
            per = Convert.ToInt32(Console.ReadLine());
            poy = Convert.ToInt32(Console.ReadLine());
            mobile = Convert.ToInt64(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine($"Sid:{sid} Name:{name} Qualification:{qua} Percentaghe:{per} Passofyear:{poy} Mobile:{mobile}");

        }

        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.input();
            s1.display();

            Student s2 = new Student();
            s2.input();
            s2.display();
            // s1.sid = 101;
            //s1.name = "Snehal";
            //s1.qua = "BE";
            //s1.per = 85;
            //s1.poy = 2018;
            //s1.mobile = 9175758844L;
           // Console.WriteLine($"Sid: {s1.sid} Name: {s1.name} Qualification: {s1.qua} Percentaghe: {s1.per} Passofyear: {s1.poy} Mobile: {s1.mobile}");
        }
    }
}
