using Microsoft.AspNetCore.Mvc;
using MVC_christenZarif.Models;
using MVC_christenZarif.ViewModel;

namespace MVC_christenZarif.Controllers
{
    public class InstructorController : Controller
    {
        ITIContext _context = new ITIContext();
        public IActionResult Index()
        {
            List<Instructor> instructors = _context.Instructors.ToList();
            return View("ShowAll" , instructors);
        }

        public IActionResult Details(int id)
        {
            Instructor instructor = _context.Instructors.Find(id);
            return View("ShowDetails", instructor);
        }

        public IActionResult Add ()
        {
            var insVM = new AddInstructorViewModel()
            {
                Department = _context.Departments.ToList(),
                Course = _context.Courses.ToList()
            };
            return View("Add" , insVM);
        }

        [HttpPost]
        public IActionResult SaveAdd(AddInstructorViewModel insVm)
        {
            if(ModelState.IsValid)
            {
                var instructor = new Instructor()
                {
                    Name = insVm.Name,
                    Image = insVm.Image,
                    Salary = insVm.Salary,
                    Address = insVm.Address,
                    DeptId = insVm.DeptId,
                    CrsId = insVm.CrsId
                };
                _context.Instructors.Add(instructor);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                insVm.Department = _context.Departments.ToList();
                insVm.Course = _context.Courses.ToList();
                return View("Add", insVm);
            }

        }
    }
}
