using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.OOPS
{
    class Stock
    {
        float openprice;
        float closeprice;
        string stockname;

        public void SetOpenPrice(float op)
        {
            openprice = op;
        }

        public void SetClosePrice(float cp)
        {
            closeprice = cp;
        }
        public void SetStockName(string sn)
        {
            stockname = sn;
        }


        public float GetOpenPrice()
        {
            return openprice;
        }

        public float GetClosePrice()
        {
            return closeprice;
        }


        public string GetStockName()
        {
            return stockname;
        }

    }
    class TestStock
    {
        static void Main(string[] args)
        {
            Stock s1 = new Stock();
            Stock s2 = new Stock();
            Console.WriteLine("Enter opening price, cloasing price, stock name");
            float op = Convert.ToSingle(Console.ReadLine());
            s1.SetOpenPrice(op);
            float cp= Convert.ToSingle(Console.ReadLine());
            s1.SetClosePrice(cp);
            string nm = Console.ReadLine();
            s1.SetStockName(nm);

            float op1 = Convert.ToSingle(Console.ReadLine());
            s2.SetOpenPrice(op1);
            float cp1 = Convert.ToSingle(Console.ReadLine());
            s2.SetClosePrice(cp1);
            string nm1 = Console.ReadLine();
            s2.SetStockName(nm1);

            Console.WriteLine("......Stock detalis....");
            Console.WriteLine(s1.GetOpenPrice());
            Console.WriteLine(s1.GetClosePrice());
            Console.WriteLine(s1.GetStockName());

            Console.WriteLine(s2.GetOpenPrice());
            Console.WriteLine(s2.GetClosePrice());
            Console.WriteLine(s2.GetStockName());

        }
    }
}
