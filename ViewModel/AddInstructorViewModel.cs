using MVC_christenZarif.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC_christenZarif.ViewModel
{
    public class AddInstructorViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public decimal Salary { get; set; }

        public string Address { get; set; }

        public int DeptId { get; set; }
        public List<Department>? Department { get; set; }

        public int CrsId { get; set; }
        public List<Course>? Course { get; set; }

    }
}
