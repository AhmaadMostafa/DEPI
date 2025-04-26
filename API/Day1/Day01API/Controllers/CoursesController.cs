using Day01API.Context;
using Day01API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace Day01API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly StoreContext _context;

        public CoursesController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var courses = await _context.Courses.ToListAsync();

            if (courses == null || !courses.Any())
                return NotFound();

            return Ok(courses);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            var course = await _context.Courses.FindAsync(id);

            if (course == null)
                return NotFound();

            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();

            var updatedCourses = await _context.Courses.ToListAsync();
            return Ok(updatedCourses);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Course course)
        {
            if (id != course.ID)
                return BadRequest();

            var existingCourse = await _context.Courses.FindAsync(id);

            if (existingCourse == null)
                return NotFound();

            existingCourse.Crs_name = course.Crs_name;
            existingCourse.Crs_desc = course.Crs_desc;
            existingCourse.Duration = course.Duration;

            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpPost]
        public async Task<IActionResult> Post(Course course)
        {
            if (course == null)
                return BadRequest();

            _context.Courses.Add(course);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetById", new { Id = course.ID }, course);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var course = await _context.Courses.FindAsync(id);

            if (course == null)
                return NotFound();

            return Ok(course);
        }

        [HttpGet("name/{name}")]
        public async Task<IActionResult> CouseByName(string name)
        {
            var course = await _context.Courses.FirstOrDefaultAsync(c => c.Crs_name == name);

            if (course == null)
                return NotFound();

            return Ok(course);
        }

    }
}
