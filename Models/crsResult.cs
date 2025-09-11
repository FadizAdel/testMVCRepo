using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC_christenZarif.Models
{
    public class crsResult
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Degree { get; set; }

        // Foreign Keys
        [ForeignKey("Course")]
        public int CrsId { get; set; }
        public Course Course { get; set; }

        [ForeignKey("Trainee")]
        public int TraineeId { get; set; }
        public Trainee Trainee { get; set; }
    }
}
