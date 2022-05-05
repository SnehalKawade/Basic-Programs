using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.OOPS
{
    class ChainingExample
    {
        int sid;
        string sname;
        int percent;
        int passoutyr;
        string email;

        public ChainingExample()
        {
            sid = 101;
            sname = "Shravy";
        }

        public ChainingExample(int id,string nm,int p)
        {
            sid = id;
            sname = nm;
            percent = p;
        }

        public ChainingExample(int id,string nm,int p,int py):this(id,nm,p)
        {
            passoutyr = py;
        }

        public ChainingExample(int id, string nm, int p, int py,string em):this(id,nm,p,py)
        {
            email = em;
        }
        static void Main(string[] args)
        {
            ChainingExample ce = new ChainingExample(1, "Snehal", 90, 2018, "Sonu@gmail.com");
            Console.WriteLine(ce.sid);
            Console.WriteLine(ce.sname);
            Console.WriteLine(ce.percent);
            Console.WriteLine(ce.passoutyr);
            Console.WriteLine(ce.email);
        }

    }
    
}
