using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class EFDeleteCourseWithSP
    {
        public static void Main()
        {
            using (STDbContext ctx = new STDbContext())
            {
                Database.SetInitializer(new NullDatabaseInitializer<STDbContext>());
                ctx.Database.Log = Console.WriteLine;

                try
                {
                    ctx.Database.ExecuteSqlCommand("exec DeleteCourse {0}", 3007);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error  --> " + ex.Message);
                }
            }

        }
    }
}
