using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class ListCourses
    {
        public static void Main()
        {

            StDataConect dc = new StDataConect();
            dc.Log = Console.Out; // write sql commands to console 

            var courses = from c in dc.Courses
                          where c.Fee > 2000
                          orderby c.Title
                          select new { Name = c.Title, Fee = c.Fee * 1.18 };

            foreach (var c in courses)
                Console.WriteLine("{0} - {1}", c.Name, c.Fee);


        }
    }
}
