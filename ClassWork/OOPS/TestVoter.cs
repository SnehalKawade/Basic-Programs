using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.OOPS
{
    class Voter
    {
        long adharcard;
        string votername;
        string votercasted;

        public void SetAdharcard(long ac)
        {
            adharcard = ac;
        }

        public void SetVotername(string nm)
        {
            votername = nm;
        }

        public void SetVoterCast(string vc)
        {
            votercasted = vc;
        }
        public long GetAdharcard()
        {
            return adharcard;
        }

        public string GetVotername()
        {
            return votername;
        }

        public string GetVoterCast()
        {
            return votercasted;

        }

    }
    class TestVoter
    {
        static void Main(string[] args)
        {
            Voter v1 = new Voter();
            v1.SetAdharcard(123456789);
            v1.SetVotername("Snehal");
            v1.SetVoterCast("BJP");

            Voter v2 = new Voter();
            v2.SetAdharcard(3645888990);
            v2.SetVotername("Sayali");
            v2.SetVoterCast("Shivsena");

            Console.WriteLine(v1.GetAdharcard());
            Console.WriteLine(v1.GetVotername());
            Console.WriteLine(v1.GetVoterCast());

            Console.WriteLine(v2.GetAdharcard());
            Console.WriteLine(v2.GetVotername());
            Console.WriteLine(v2.GetVoterCast());
        }

    }
}
