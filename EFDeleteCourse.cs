using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class EFDeleteCourse
    {
        public static void Main()
        {
            using (STDbContext ctx = new STDbContext())
            {
                Database.SetInitializer(new NullDatabaseInitializer<STDbContext>());
                ctx.Database.Log = Console.WriteLine;

                var course = ctx.Courses.Find(3005);
                ctx.Courses.Remove(course);
                ctx.SaveChanges();

                var courses = from c in ctx.Courses.ToList()
                              select c;

                Console.WriteLine("List of Courses");

                foreach (var c in courses)
                    Console.WriteLine("{0} - {1} - {2} - {3}", c.Id, c.Title, c.Duration, c.Fee);

            }

        }
    }
}
