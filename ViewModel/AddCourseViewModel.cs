using MVC_christenZarif.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVC_christenZarif.ViewModel
{
    public class AddCourseViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int MinDegree { get; set; }

        public int Degree { get; set; }

        public int Hours { get; set; }

        public int DeptId { get; set; }
        public List<SelectListItem>? Department { get; set; }

    }
}
