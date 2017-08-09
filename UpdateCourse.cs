using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class UpdateCourse
    {
        public static void Main()
        {

            StDataConect dc = new StDataConect();
            dc.Log = Console.Out; // write sql commands to console 

            var course = (from c in dc.Courses
                          where c.Id == 2005
                          select c).SingleOrDefault();

            if (course == null)
                Console.WriteLine("Sorry! Course not found!");
            else
            {
                course.Fee = 2000;
                course.Duration = 15;
                dc.SubmitChanges();

                var courses = from c in dc.Courses
                              select c;

                foreach (var c in courses)
                    Console.WriteLine("{0} - {1} - {2}", c.Id, c.Title, c.Fee);

            }
        }
    }
}
