using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.OOPS
{
    class Movie
    {
        string moviename;
        string directorname;
        string producername;
        string actorname;
        int rating;

        public Movie()
        {
            Console.WriteLine("In movie Default constructor");
        }

       
        public void SetMovieName(string mn)
        {
            moviename = mn;
        }

        public void SetDirectorname(string dn)
        {
            directorname = dn;
        }

        public void SetProducername(string pn)
        {
            producername = pn;
        }

        public void SetActorname(string an)
        {
            actorname = an;
        }

        public void SetRating(int r)
        {
            rating = r;
        }

        public string GetMoviename()
        {
            return moviename;
        }

        public string GetDirectorname()
        {
            return directorname;
        }

        public string GetProducername()
        {
            return producername;
        }

        public string GetActorname()
        {
            return actorname;
        }

        public int GetRating()
        {
            return rating;

        }

        public string MovieRating()
        {
            if (rating >= 3.5)
                return "Super Hit";
            else if (rating >= 2.5)
                return "Hit";
            else
                return "Flop";
        }


    }
    class MovieDemo
    {
        static void Main(string[] args)
        {
            Movie m1 = new Movie();
            Console.WriteLine("Enter Moviename, Director name, Producer name, Actor name,Rating");
            string m = Console.ReadLine();
            m1.SetMovieName(m);
            string d = Console.ReadLine();
            m1.SetDirectorname(d);
            string p = Console.ReadLine();
            m1.SetProducername(p);
            string a = Console.ReadLine();
            m1.SetActorname(a);
            int ra = Convert.ToInt32(Console.ReadLine());
            m1.SetRating(ra);

            Console.WriteLine("Movie Details.......");
            Console.WriteLine(m1.GetMoviename());
            Console.WriteLine(m1.GetDirectorname());
            Console.WriteLine(m1.GetProducername());
            Console.WriteLine(m1.GetActorname());
            Console.WriteLine(m1.GetRating());
            Console.WriteLine(m1.MovieRating());
            
        }
    }
}
