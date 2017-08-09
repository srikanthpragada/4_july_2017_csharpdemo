using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class StDataConect : DataContext 
    {
        public StDataConect() : 
            base(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=msdb;Integrated Security=True")
        {

        }

        public Table<Course> Courses
        {
            get
            {
                return GetTable<Course>();
            }
        }
    }
}
