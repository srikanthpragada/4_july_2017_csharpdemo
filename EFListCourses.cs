using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class EFListCourses
    {
        public static void Main()
        {
            STDbContext dc = new STDbContext();
            Database.SetInitializer(new NullDatabaseInitializer<STDbContext>());

            dc.Database.Log = Console.WriteLine;

            var courses = from c in dc.Courses
                          where c.Fee > 2000
                          orderby c.Title 
                          select c;

            foreach (var c in courses)
            {
                Console.WriteLine("{0} - {1}", c.Title, c.Fee);
            }


        }
    }
}
