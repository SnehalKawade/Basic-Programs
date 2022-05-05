using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Containment
{
    //5.Design class Order (intordered,StringOrderdate,Customercust,Item item)
    //Customer(intcustid, Stringcustname, Address address)
    //Address(String addr1, city, int pincode)
    //Item(intitemid, Stringitemname, int price)
    //Write constructors, getters/setters in respective classes.
   class Order
    {
         int oid;
         string orderdate;
         public Customer cust = new Customer();
         public Item it = new Item();

        public Order() //Default constructor
        {

        }

        public Order(int oid,string orderdate,Customer cust,Item it)  //parameterized constructor
        {
            this.oid = oid;
            this.orderdate = orderdate;
            this.cust = cust;
            this.it = it;
        }
        public void SetOid(int oid)
        {
            this.oid = oid;
        }
        public void SetOrderdate(string orderdate)
        {
            this.orderdate = orderdate;
        }
        public void SetCust(Customer cust)
        {
            this.cust = cust;
        }
        public void SetIt(Item it)
        {
            this.it = it;
        }
        public int GetOid()
        {
            return this.oid;
        }      
        public string GetOrderdate()
        {
            return this.orderdate;
        }
        public Customer GetCust()
        {
            return this.cust;
        }     
        public Item GetIt()
        {
            return this.it;
        }
    }
   class Customer
    {
        int custid;
        string custname;
        public Address add = new Address();

        public Customer() //Default constructor
        {

        }

        public Customer(int custid,string custname,Address add) //parameterized constructor
        {
            this.custid = custid;
            this.custname = custname;
            this.add = add;
        }
        public void SetCustid(int custid)
        {
            this.custid = custid;
        }
        public void SetCustname(string custname)
        {
            this.custname = custname;
        }
        public void SetAdd(Address add)
        {
            this.add = add;
        }
        public int GetCustid()
        {
            return this.custid;
        }
        public string GetCustname()
        {
            return this.custname;
        }
        public Address GetAdd()
        {
            return this.add;
        }
    }

   class Address
    {
        string addr1;
        string city;
        int pincode;
        
        public Address() //Default constructor
        {

        }

        public Address(string addr1,string city,int pincode) //parameterized constructor
        {
            this.addr1 = addr1;
            this.city = city;
            this.pincode = pincode;
        }
        public void SetAddr1(string addr1)
        {
            this.addr1 = addr1;
        }
        public void SetCity(string city)
        {
            this.city = city;
        }
        public void SetPincode(int pincode)
        {
            this.pincode = pincode;
        }

        public string GetAddr1()
        {
            return this.addr1;
        }
        public string GetCity()
        {
            return this.city;
        }
        public int GetPincode()
        {
            return pincode;
        }
    }

    class Item
    {
        int itemid;
        string itemname;
        int price;

        public Item() //Default constructor
        {

        }

        public Item(int itemid,string itemname,int price) //parameterized constructor
        {
            this.itemid = itemid;
            this.itemname = itemname;
            this.price = price;
        }
        public void SetItemid(int itemid)
        {
            this.itemid = itemid;
        }
        public void SetItemanme(string itemname)
        {
            this.itemname = itemname;
        }
        public void SetPrice(int price)
        {
            this.price = price;
        }
        public int GetItemid()
        {
            return this.itemid;
        }
        public string GetItemname()
        {
            return this.itemname;
        }
        public int GetPrice()
        {
            return this.price;
        }
    }   
        

    class OrderDemo
    {
        static void Main(string[] args)
        {
            Order o1 = new Order();
            o1.SetOid(111);
            o1.SetOrderdate("11 April 2022");
            o1.cust.SetCustid(3456);
            o1.cust.SetCustname("Snehal");
            o1.cust.add.SetAddr1("Danami Nagar");
            o1.cust.add.SetCity("Solapur");
            o1.cust.add.SetPincode(413001);
            o1.it.SetItemid(112233);
            o1.it.SetItemanme("Mobile phone");
            o1.it.SetPrice(15000);


            Console.WriteLine(".....Order Details....");
            Console.WriteLine(o1.GetOid());
            Console.WriteLine(o1.GetOrderdate());
            Console.WriteLine(o1.cust.GetCustid());
            Console.WriteLine(o1.cust.GetCustname());
            Console.WriteLine(o1.cust.add.GetAddr1());
            Console.WriteLine(o1.cust.add.GetCity());
            Console.WriteLine(o1.cust.add.GetPincode());
            Console.WriteLine(o1.it.GetItemid());
            Console.WriteLine(o1.it.GetItemname());
            Console.WriteLine(o1.it.GetPrice());

        }
    }
}
