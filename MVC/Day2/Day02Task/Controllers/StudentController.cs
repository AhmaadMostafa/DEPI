using Day02Task.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day02Task.Controllers
{
	public class StudentController : Controller
	{
		TaskDBContext Context = new TaskDBContext();
		public IActionResult ShowAll()
		{
			var student = Context.Student.Include(i => i.Department).ToList();
			return View("ShowAll", student);
		}

		public IActionResult ShowDetails(int id)
		{
			var student = Context.Student.Include(i => i.Department).Include(i => i.CourseResult)
				.ThenInclude(i => i.Course).FirstOrDefault(i => i.Id == id);
			return View("ShowDetails" , student);
		}
	}
}
