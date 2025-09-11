using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC_christenZarif.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Image { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        // Foreign Keys
        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public Department Department { get; set; }

        [ForeignKey("Course")]
        public int CrsId { get; set; }
        public Course Course { get; set; }
    }
}
