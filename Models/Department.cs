using System.ComponentModel.DataAnnotations;

namespace MVC_christenZarif.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(100)]
        public string Manager { get; set; }

        // Navigation
        public List<Instructor> Instructors { get; set; } = new();
        public List<Trainee> Trainees { get; set; } = new();
        public List<Course> Courses { get; set; } = new();
    }
}
