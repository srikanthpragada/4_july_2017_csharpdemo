using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    [Table("topics")]
    class EFTopic
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public int Hours { get; set; }
        [Column ("courseid")]
        public EFCourse Course { get; set; }
    }
}
