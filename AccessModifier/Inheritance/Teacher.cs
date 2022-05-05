using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier.Inheritance
{
    class Teacher
    {
        string tname;
        int experiance;
        string subject;
        public Teacher()
        {
            Console.WriteLine("In Teacher Default constructor");
        }

        public Teacher(string tname,int experiance,string subject)
        {
            this.tname = tname;
            this.experiance = experiance;
            this.subject = subject;
        }

        public string Tname
        {
            set { tname = value; }
            get { return tname; }
        }

        public int Experinace
        {
            set { experiance = value; }
            get { return experiance; }
        }

        public string Subject
        {
            set { subject = value; }
            get { return subject; }
        }
    }
}
