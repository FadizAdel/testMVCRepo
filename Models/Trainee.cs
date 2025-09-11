using Microsoft.AspNetCore.Cors.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC_christenZarif.Models
{
    public class Trainee
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Image { get; set; }

        [Required, MaxLength(5)]
        public string Grade { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        // Foreign Key
        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public Department Department { get; set; }

        // Navigation
        public List<crsResult> CrsResults { get; set; } = new();
    }
}
