using Microsoft.AspNetCore.Cors.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace MVC_christenZarif.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(150)]
        public string Name { get; set; }

        [Required]
        public int MinDegree { get; set; }

        [Required]
        public int Degree { get; set; }

        [Required]
        public int Hours { get; set; }

        // Foreign Key
        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public Department? Department { get; set; }

        // Navigation
        public List<Instructor> Instructors { get; set; } = new();
        public List<crsResult> CrsResults { get; set; } = new();
    }
}
