using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Studentpack.Models
{
    public class SchoolClass
    {

        [Key]
        public int ClassId { get; set; }

        [Required]
        [StringLength(100)]
        public string ClassName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public int TeacherId { get; set; }

        [ForeignKey("TeacherId")]
        public virtual Teacher Teacher { get; set; }

        public virtual ICollection<Student> Students { get; set; }

    }
}
