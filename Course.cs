using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    [Table(Name ="courses")]
    class Course
    {
        [Column (IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column (Name ="name")]
        public string Title { get; set; }

        [Column]
        public int Duration { get; set; }

        [Column]
        public int Fee { get; set; }
    }
}
