using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.StringAssignmnet
{
    //3.Reverse a string preserving space positions?
      /*  Input: "Help others"
        Output: srehtopleH
        or
        Input: "abc de"
        Output: edcba
        or
        Input: "intern at geeks"
        Output: skeegtanretni*/

    class ReserveString
    {
        static void Main(string[] args)
        {
            string str ="Help others";
            string s1=" ";
            for(int i=0;i<str.Length;i++)
            {
                s1 =str[i]+s1;
            }

            Console.WriteLine("Reserve string:"+s1);
        }
    }
}
