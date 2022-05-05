using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.OOPS
{
    class Order
    {
        int oid;
        string orderdate;
        Customer cust=new Customer();
        Item it=new Item();

        public Order()
        {

        }

        public Order(int oid,string orderdate,Customer cust,Item it)
        {
            this.Oid = oid;
            this.Orderdate = orderdate;
            this.Cust = cust;
            this.It = it;
        }
        public int Oid
        {
            set { oid = value; }
            get { return oid; }
        }

        public string Orderdate
        {
            set { orderdate = value; }
            get { return orderdate; }
        }
        public Customer Cust
        {
            set { cust = value; }
            get { return cust; }
        }

        public Item It
        {
            set { it = value; }
            get { return it; }
        }
       
    }
    class Customer
    {
        string custname;
        long mobile;
        Address add=new Address();
        public Customer()
        {

        }
        public Customer(string custname,long mobile,Address add)
        {
            this.Custname = custname;
            this.Mobile = mobile;
            this.Add = add;
        }

        public string Custname
        { 
            set { custname = value; }
            get { return custname; }
        }
        public long Mobile
        {
            set { mobile = value; }
            get { return mobile; }
        }
        public Address Add
        {
            set { add = value; }
            get { return add; }
        }   

    }

    class Address
    {
        string city;
        int zipcode;
        public Address()
        {

        }

        public Address(string city,int zipcode)
        {
            this.City = city;
            this.Zipcode = zipcode;
        }
        public string City
        {
            set { city = value; }
            get { return city; }
        }
        public int Zipcode
        {
            set { zipcode = value; }
            get { return zipcode; }
        }
    }

    class Item
    {
        int itemid;
        string itemname;
        string deliverydate;

        public Item()
        {

        }

        public Item(int itemid,string itemname,string deliverdate)
        {
            this.Itemid = itemid;
            this.Itemname = itemname;
            this.Deliverdate = deliverdate;
        }
        public int Itemid
        {
            set { itemid = value; }
            get { return itemid; }
        }
        public string Itemname
        {
            set { itemname = value; }
            get { return itemname; }
        }

        public string Deliverdate
        {
            set { deliverydate = value; }
            get { return deliverydate; }
        }
    }

    class OrderTest
    {
        static void Main(string[] args)
        {
            Order o1 = new Order();
            o1.Oid = 111;
            o1.Orderdate = "06/03/2022";
            o1.Cust.Custname = "Snehal";
            o1.Cust.Mobile = 9175756644;
            o1.Cust.Add.City = "Solapur";
            o1.Cust.Add.Zipcode = 413001;
            o1.It.Itemid = 22224;
            o1.It.Deliverdate = "15/03/2022";

            Console.WriteLine("....Order Detalis...");
            Console.WriteLine(o1.Oid);
            Console.WriteLine(o1.Orderdate);
            Console.WriteLine(o1.Cust.Custname);
            Console.WriteLine(o1.Cust.Mobile);
            Console.WriteLine(o1.Cust.Add.City);
            Console.WriteLine(o1.Cust.Add.Zipcode);
            Console.WriteLine(o1.It.Itemid);
            Console.WriteLine(o1.It.Deliverdate);
        }
    }
}
