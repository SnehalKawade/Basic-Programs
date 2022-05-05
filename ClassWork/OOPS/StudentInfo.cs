using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.OOPS
{
    class StudentD
    {
        int sid;
        string sname;
        int percent;
        Batch bat = new Batch();
        Address addr = new Address();

        public StudentD()
        {

        }

        public StudentD(int sid,string sname,int percent,Batch bat,Address addr)
        {
            this.Sid = sid;
            this.Sname = sname;
            this.Percent = percent;
            this.Bat = bat;
            this.Addr = addr;


        }

        public int Sid
        {
            set { sid = value; }  get { return sid; }
        }

        public string Sname
        {
            set { sname = value; }
            get { return sname; }
        }

        public int Percent
        {
            set { percent = value; }
            get { return percent; }
        }

        public Batch Bat
        {
            set { bat = value; }
            get { return bat; }
        }

        public Address Addr
        {
            set { addr = value; }
            get { return addr; }
        }
    }

    class Batch
    {
        string batchname;
        string subject;

        public Batch()
        {

        }
        public Batch(string batchanme,string subject)
        {
            this.Batchname = batchname;
            this.Subject = subject;
        }

        public string Batchname
        {
            set { batchname = value; }
            get { return batchname; }
        }

        public string Subject
        {
            set { subject = value; }
            get { return subject; }
        }

    }

    class Address
    {
        string street;
        string city;

        public Address()
        {

        }

        public Address(string street,string city)
        {
            this.Street = street;
            this.City = city;
        }
        
        public string Street
        {
            set { street = value; }
            get { return street; }
        }

        public string City
        {
            set { city = value; }
            get { return city; }
        }

    }
    class StudentInfo
    {
        static void Main(string[] args)
        {
            StudentD s1 = new StudentD();
            s1.Sid = 101;
            s1.Sname = "Snehal";
            s1.Percent = 90;
            s1.Bat.Batchname = "Apple";
            s1.Bat.Subject = "C#";
            s1.Addr.Street = "Damani Nagar";
            s1.Addr.City = "Solapur";

            Console.WriteLine(".....Student Information.....");
            Console.WriteLine("Student id: " + s1.Sid);
            Console.WriteLine("Student name: "+ s1.Sname);
            Console.WriteLine("Student percent: " + s1.Percent);
            Console.WriteLine("Batchname: " + s1.Bat.Batchname);
            Console.WriteLine("Subject: " + s1.Bat.Subject);
            Console.WriteLine("Street: " + s1.Addr.Street);
            Console.WriteLine("City: " + s1.Addr.City);


            Address a1 = new Address("Navi peth", "Solapur");
            Batch b1 = new Batch("Microsoft", "java");
            StudentD s2 = new StudentD(102, "Sagar", 89, b1, a1);
            StudentD s3 = new StudentD(103, "Sayali", 95, new Batch("Oracle", "Python"), new Address("Mg road", "Pune"));

        }
    }
}
