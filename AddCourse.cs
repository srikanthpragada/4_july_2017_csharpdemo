using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class AddCourse
    {
        public static void Main()
        {

            StDataConect dc = new StDataConect();
            dc.Log = Console.Out; // write sql commands to console 

            // Insert a new course 
            var course = new Course { Title = "Angular", Duration = 12, Fee = 1500 };
            dc.Courses.InsertOnSubmit(course);
            dc.SubmitChanges();


            var courses = from c in dc.Courses
                          select c;

            foreach (var c in courses)
                Console.WriteLine("{0} - {1} - {2}", c.Id, c.Title, c.Fee);


        }
    }
}
