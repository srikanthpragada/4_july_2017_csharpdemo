using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class EFUpdateCourse
    {
        public static void Main()
        {
            using (STDbContext ctx = new STDbContext())
            {
                Database.SetInitializer(new NullDatabaseInitializer<STDbContext>());
                ctx.Database.Log = Console.WriteLine;

                var course = ctx.Courses.Find(3004);
                course.Duration = 5;
                ctx.SaveChanges();

                var courses = from c in ctx.Courses.ToList()
                              where c.Id == 3004
                              select c;

                Console.WriteLine("List of Courses");

                foreach (var c in courses)
                    Console.WriteLine("{0} - {1} - {2} - {3}", c.Id, c.Title, c.Duration, c.Fee);

            }

        }
    }
}
