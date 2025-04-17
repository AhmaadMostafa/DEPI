using Day04.Models;
using Day04.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Day04.Controllers
{
    public class DepartmentController : Controller
    {
        TaskDBContext context = new TaskDBContext();
        public IActionResult ShowAll()
        {
            List<Department> Department = context.Department.ToList();
            return View("ShowAll" , Department);
        }

        public IActionResult ShowDetail(int id)
        {
            var department = context.Department.Include(d => d.Students)
                                               .Include(d => d.Teachers)
                                               .Include(d => d.Course).FirstOrDefault(i => i.Id == id);
            var viewModel = new DepartmentDetailsViewModel
            {
                Id = department.Id,
                Name = department.Name,
                ManagerName = department.ManagerName,
                Teachers = department.Teachers.Select(t => t.Name).ToList(),
                Courses = department.Course.Select(c => c.Name).ToList(),
                Students = department.Students.Select(s => s.Name).ToList()
            };
            return View("ShowDetail" , viewModel);
        }
        public IActionResult Add()
        {
            return View("Add");
        }
        public IActionResult SaveAdd(Department department)
        {
            if(department.Name != null && department.ManagerName != null)
            {
                context.Add(department);
                context.SaveChanges();
                return RedirectToAction("ShowAll");
            }
            return View("Add" , department);
        }
        public IActionResult ShowDetails(int id)
        {
            var department = context.Department
                .Where(d => d.Id == id)
                .Select(d => new DepartmentViewModel
                {
                    DepartmentName = d.Name,
                    Students = d.Students
                        .Where(s => s.Age > 25)
                        .Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Name })
                        .ToList(),
                    DepartmentState = d.Students.Count >= 50 ? "Main" : "Branch"
                })
                .FirstOrDefault();

            if (department == null)
            {
                return NotFound();
            }

            return View("ShowDetails" , department);
        }
    }
}
