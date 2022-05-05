using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.OOPS
{
    class Country
    {
        string cname;
        int states;
        long population;
        int nooflang;
        string capital;
        public string Cname
        {
            get { return cname; }

            set { cname = value; }
        }

        public int States
        {
            get { return states; }

            set { states = value; }
        }

        public int NoofLang
        {
            get { return nooflang; }

            set { nooflang = value; }
        }

        public string Capital
        {
            get { return capital; }

            set { capital = value; }
        }

    }
    class CountryDemo
    {
        static void Main(string[] args)
        {
            Country c1 = new Country();
            c1.Cname = "India";
            c1.States = 28;
            c1.NoofLang = 7;
            c1.Capital = "Delhi";

            Console.WriteLine(c1.Cname);
            Console.WriteLine(c1.States);
            Console.WriteLine(c1.NoofLang);
            Console.WriteLine(c1.Capital);
        }
    }
}
