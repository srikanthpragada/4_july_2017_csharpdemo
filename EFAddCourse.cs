using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class EFAddCourse
    {
        public static void Main()
        {
            using (STDbContext ctx = new STDbContext())
            {
                Database.SetInitializer(new NullDatabaseInitializer<STDbContext>());
                ctx.Database.Log = Console.WriteLine;

                // Insert a new course 
                var course = new EFCourse { Title = "Entity Framework",
                                            Duration = 10,
                                            Fee = 1500 };
                ctx.Courses.Add(course);
                ctx.SaveChanges();


                var courses = from c in ctx.Courses.ToList()
                              select c;

                Console.WriteLine("List of Courses");

                foreach (var c in courses)
                    Console.WriteLine("{0} - {1} - {2}", c.Id, c.Title, c.Fee);

            }

        }
    }
}
