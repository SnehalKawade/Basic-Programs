using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.StringAssignmnet
{
    //fine the average of digit which are present into the string.
    class AverageDigitString
    {
        static void Main(string[] args)
        {
            string str = "sn5eh5al5";
            int avg = 0;
            int sum = 0;
            int count = 0;
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]>='0' && str[i]<='9')
                {
                    int x = (int)(char.GetNumericValue(str[i]));
                    sum = x + sum;
                    count++;
                }
            }

            Console.WriteLine(sum+" "+count);
            avg = sum / count;
            Console.WriteLine(avg);
        }
    }
}
