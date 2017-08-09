using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharpdemo
{
    [Table("courses")]
    class EFCourse
    {
        [Key]
        public int Id { get; set; }

        [Column ("name")]
        public string Title { get; set; }

        [Column]
        public int Duration { get; set; }

        [Column]
        public int Fee { get; set; }
    }
}
