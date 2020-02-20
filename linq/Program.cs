using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Course> clst = new List<Course>()
            {
                new Course { Cid = 1, Cname = "c#", Fees = 7000, StartDate = Convert.ToDateTime("10-02-2020") },
                new Course
                {
                    Cid = 2,
                    Cname = "javascript",
                    Fees = 8000,
                    StartDate = Convert.ToDateTime("9-02-2020")
                },
                new Course
                {
                    Cid = 3,
                    Cname = "java",
                    Fees = 9000,
                    StartDate = Convert.ToDateTime("7-02-2020")
                },
                new Course
                {
                    Cid = 4,
                    Cname = "c",
                    Fees = 7000,
                    StartDate = Convert.ToDateTime("3-02-2020")
                },
            };
            var query = from gq in clst
                        where gq.Cid == 3
                        select gq;
            foreach (var q in query)
            {

                Console.WriteLine("{0}\n{1}\n{2}\n{3}", q.Cid, q.Cname, q.StartDate, q.Fees);
            }
            var qget = from a in clst
                       orderby a.Fees
                       select a;
            foreach (var q in qget)
            {
                Console.WriteLine("{0}\n{1}\n{2}\n{3}", q.Cid, q.Cname, q.StartDate, q.Fees);
            }
        }
    }
}

