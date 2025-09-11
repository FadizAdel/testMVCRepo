using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_christenZarif.Models;
using MVC_christenZarif.ViewModel;

namespace MVC_christenZarif.Controllers
{
    public class CourseController : Controller
    {
        ITIContext _context = new ITIContext();
        public IActionResult Index()
        {
            var crs =  _context.Courses.ToList();
            return View("index" , crs);
        }

        public IActionResult Add()
        {
            var crsVM = new AddCourseViewModel
            {
                Department = _context.Departments
                          .Select(d => new SelectListItem
                          {
                              Value = d.Id.ToString(),
                              Text = d.Name
                          }).ToList()
            }; return View("Add" , crsVM);
        }
        [HttpPost]
        public IActionResult Add(AddCourseViewModel crsVM)
        {
            if (!ModelState.IsValid)
            {
                crsVM.Department = _context.Departments
                    .Select(d => new SelectListItem
                    {
                        Value = d.Id.ToString(),
                        Text = d.Name
                    }).ToList();
                return View(crsVM);
            }

            var course = new Course
            {
                Name = crsVM.Name,
                MinDegree = crsVM.MinDegree,
                Degree = crsVM.Degree,
                Hours = crsVM.Hours,
                DeptId = crsVM.DeptId
            };

            _context.Courses.Add(course);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
