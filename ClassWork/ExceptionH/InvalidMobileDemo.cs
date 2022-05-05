using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.ExceptionH
{
    class InvalidMobileException:ApplicationException
    {
        public InvalidMobileException(string m):base(m)
        {

        }
        public override string ToString()
        {
            return "Errooooor";
        }
    }
    class InvalidMobileDemo
    {
        static void ValidateMobile(long mb)
        {
            String m = Convert.ToString(mb);
            int c = m.Length;
            if (c != 10)
                throw new InvalidMobileException("Mobile should be exact 10 digits");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter mobile number");
            long mobi = Convert.ToInt64(Console.ReadLine());
            try
            {
                ValidateMobile(mobi);
            }
            catch(InvalidMobileException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
