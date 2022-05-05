using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Containment
{
    class Pen
    {
        int caplength;
        string brand;
        public Refill r = new Refill();

        public Pen()
        {

        }

        public Pen(int caplength,string brand,Refill r)
        {
            this.caplength = caplength;
            this.brand = brand;
            this.r = r;
        }
        public void SetCaplength(int caplength)
        {
            this.caplength = caplength;
        }
        public void SetBrand(string brand)
        {
            this.brand = brand;
        }
        public void SetR(Refill r)
        {
            this.r = r;
        }
        public int GetCaplength()
        {
            return this.caplength;
        }
        public string GetBrand()
        {
            return this.brand;
        }

        public Refill GetR()
        {
            return this.r;
        }
    }

    class Refill
    {
        string color;
        int length;
        public Nib n= new Nib();

        public Refill()
        {

        }
        public Refill(string color,int length, Nib n)
        {
             this.color = color;
             this.length = length;
             this.n = n;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public void SetLength(int length)
        {
            this.length = length;
        }
        public void SetN(Nib n)
        {
            this.n = n;
        }
        public string GetColor()
        {
            return this.color;
        }
        public int GetLength()
        {
            return this.length;
        }

        public Nib GetN()
        {
            return this.n;
        }
    }

    class Nib
    {
        string materialtype;
        int width;

        public Nib()
        {

        }
        public Nib(string materialtype,int width)
        {
            this.materialtype = materialtype;
            this.width = width;
        }

        public void SetMaterialtype(string materialtype)
        {
            this.materialtype = materialtype;
        }

        public void SetWidth(int width)
        {
            this.width = width;
        }

        public string GetMaterialtype()
        {
            return this.materialtype;
        }

        public int GetWidth()
        {
            return this.width;
        }
    }
    class PenDemo
    {
        static void Main(string[] args)
        {
            Pen p1 = new Pen();
            p1.SetCaplength(10);
            p1.SetBrand("Cello");
            p1.r.SetColor("Blue");
            p1.r.SetLength(15);
            p1.r.n.SetMaterialtype("hard");
            p1.r.n.SetWidth(5);

            Console.WriteLine("...Pen Details....");
            Console.WriteLine(p1.GetCaplength());
            Console.WriteLine(p1.GetBrand());
            Console.WriteLine(p1.r.GetColor());
            Console.WriteLine(p1.r.GetLength());
            Console.WriteLine(p1.r.n.GetMaterialtype());
            Console.WriteLine(p1.r.n.GetWidth());
        }
    }
}
