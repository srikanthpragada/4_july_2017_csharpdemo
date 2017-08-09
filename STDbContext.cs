using System.Data.Entity;

namespace csharpdemo
{
    class STDbContext : DbContext
    {
        public STDbContext() : base(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=msdb;Integrated Security=True")
        {

        }

        public virtual DbSet<EFCourse> Courses { get; set; }

    }
}
