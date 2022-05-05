using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.StringAssignmnet
{
    //11.Accept email_id from user and check valid or not(should contain @,.)
    class ValidEmail
    {
        static void Main(string[] args)
        {
            string f = "snehal";
            f.IndexOf('s');
            string email = "snehal@gmail.com";
            Console.WriteLine(f.StartsWith("snehal"));
            Console.WriteLine(email.EndsWith("@gmail.com"));
        }
    }
}
