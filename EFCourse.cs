using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharpdemo
{
    [Table("courses")]
    class EFCourse
    {
        //public EFCourse ()
        //{
        //    Topics = new List<EFTopic>();
        //}

        [Key]
        public int Id { get; set; }

        [Column ("name")]
        public string Title { get; set; }


        public int Duration { get; set; }


        public int Fee { get; set; }

        //public List<EFTopic> Topics { get; set; }
    }
}
