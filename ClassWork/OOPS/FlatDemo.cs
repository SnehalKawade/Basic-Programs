using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.OOPS
{
    class Flat
    {
        int flatno;
        string bname;
        Member mem=new Member();

        public Flat()
        {

        }

        public Flat(int flatno,string bname,Member mem)
        {
            this.Flatno = flatno;
            this.Bname = bname;
            this.Mem = mem;
        }
        public int Flatno
        {
            get { return flatno ; }
            set { flatno = value; }
        }

         public string  Bname
        {
            get { return bname ; }
            set { bname = value; }
        }
        public Member Mem
        {
            get { return mem; }
            set { mem = value; }
        }

    }

    class Member
    {
        string mname;
        char gender;
        int age;
        string profession;

        public Member()
        {

        }
        
        public Member(string mname,char gender,int age,string profession)
        {
            this.Mname = mname;
            this.Gender = gender;
            this.Age = age;
            this.Profession = profession;
        }
        public string Mname
        {
            get { return mname; }
            set { mname = value; }
        }
        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }

    }

    class FlatDemo
    {
        static void Main(string[] args)
        {
            Flat f1 = new Flat();
            f1.Flatno = 301;
            f1.Bname = "GuruPrabha";
            f1.Mem.Mname = "Snehal";
            f1.Mem.Gender = 'F';
            f1.Mem.Age = 25;
            f1.Mem.Profession = "Developer";
            Console.WriteLine(".......Flat Information.....");
            Console.WriteLine("Flat no: "+ f1.Flatno);
            Console.WriteLine("Buliding name: "+ f1.Bname);
            Console.WriteLine("Member name: "+ f1.Mem.Mname);
            Console.WriteLine("Member gender: "+ f1.Mem.Gender);
            Console.WriteLine("Member age: "+ f1.Mem.Age);
            Console.WriteLine("Profession: " + f1.Mem.Profession);


        }
    }
}
