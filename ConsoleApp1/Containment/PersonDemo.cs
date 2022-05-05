using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Containment
{
    //3.Write a C# program to create 2 person objects.Take input or hardcode  for all two person from console.
    //Person class is as follows
    //Person(int id, String name, Vehicle v)
    //Vehicle(int vid, String vname)

    class Person
    {
        int id;
        string name;
        Vehicle var=new Vehicle();

        public Person()
        {
            Console.WriteLine("In person default constructor");
        }

        public Person(int id,string name,Vehicle var)
        {
            this.id = id;
            this.name = name;
            this.Var = var;
        }

        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public Vehicle Var
        {
            set { var = value; }
            get { return var; }
        }
    }


    class Vehicle
    {
        int vid;
        string vname;

        public Vehicle()
        {
            Console.WriteLine("In vehicle default constructor");
        }

        public Vehicle(int vid,string vname)
        {
            this.vid = vid;
            this.vname = vname;        
        }
        public int Vid
        {
            set { vid = value; }
            get { return vid; }
        }

        public string Vname
        {
            set { vname = value; }
            get { return vname; }
        }
    }


    class PersonDemo
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine("Enter person id,name,vehicle id,name: ");
            int i= Convert.ToInt32(Console.ReadLine());
            p1.Id = i;

            string nm = Console.ReadLine();
            p1.Name = nm;

            int v = Convert.ToInt32(Console.ReadLine());
            p1.Var.Vid = v;

            string vn = Console.ReadLine();
            p1.Var.Vname = vn;

            Person p2 = new Person();
            p2.Id = 102;
            p2.Name = "Snehal";
            p2.Var.Vid = 1996;
            p2.Var.Vname = "Scooty";

            Console.WriteLine(".....Person Vehicle details....");
            Console.WriteLine(p1.Id);
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Var.Vid);
            Console.WriteLine(p1.Var.Vname);

            Console.WriteLine(p2.Id);
            Console.WriteLine(p2.Name);
            Console.WriteLine(p2.Var.Vid);
            Console.WriteLine(p2.Var.Vname);

        }
    }
}
