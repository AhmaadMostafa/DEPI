using Day04.Models;
using Day04.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day04.Controllers
{
	public class StudentController : Controller
	{
        TaskDBContext Context = new TaskDBContext();
		public IActionResult GetAll()
		{
			var student = Context.Student.Include(i => i.Department).ToList();
			return View("GetAll", student);
		}

		public IActionResult GetById(int id)
		{
			var student = Context.Student.Include(i => i.Department).Include(i => i.CourseResult)
				.ThenInclude(i => i.Course).FirstOrDefault(i => i.Id == id);
			return View("GetById", student);
		}
        public IActionResult Add()
        {
            var viewModel = new StudentDepartmentViewModel
            {
                Departments = Context.Department.ToList(),
                Student = new Student() 
            };
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult SaveAdd(Student student)
        {
            if (ModelState.IsValid)
            {
                Context.Student.Add(student);
                Context.SaveChanges();
                return RedirectToAction("GetAll");
            }

            var viewModel = new StudentDepartmentViewModel
            {
                Departments = Context.Department.ToList(),
                Student = student
            };

            return View("Add", viewModel);
        }
        public IActionResult Delete(int id)
        {
            var student = Context.Student.FirstOrDefault(i => i.Id == id);
            if (student != null)
            {
                Context.Student.Remove(student);
                Context.SaveChanges();
            }

            return RedirectToAction("GetAll");
        }

    }
}
