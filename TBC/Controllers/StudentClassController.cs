using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TBC.context;
using TBC.model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TBC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentClassController : ControllerBase
    {
        private StudentDbContext _context;

        public StudentClassController(StudentDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<StudentClass>> GetAllStudents()
        {
            IEnumerable<StudentClass> students = await _context.Students.ToListAsync();

            return students;
        }

        [Route("Post")]
        [HttpPost]
        public async Task<IActionResult> Modify(StudentClass student)
        {
            if (student == null) return BadRequest();

            var CurrentDate = DateTime.Now.Date;
            var TotalDays = CurrentDate - student.DateOfBirth.Date;
            var StudentAge = TotalDays.TotalDays * 0.00273785;
            bool a = _context.Students.Any(
                o => o.Id == student.Id
            );
            if (a == true && student.IdNumber.Length == 11 && StudentAge > 16)
            {
                _context.Update(student);

                await _context.SaveChangesAsync();

                return Ok();
            }

            return BadRequest();

        }

        //[HttpGet("{id}")]
        //public async Task<StudentClass> Get(StudentClass student)
        //{
        //    _context.Add(student);
        //    await _context.SaveChangesAsync();

        //    return student;
        //}
        [Route("Put")]
        [HttpPut]
        public async Task<IActionResult> Add(StudentClass student)
        {
            if (student == null) return BadRequest();

            var CurrentDate = DateTime.Now.Date;
            var TotalDays = CurrentDate - student.DateOfBirth.Date;
            var StudentAge = TotalDays.TotalDays * 0.00273785;
            //var IdNumberChecker = await _context.FindAsync<StudentClass>(student.IdNumber);
            bool a = _context.Students.Any(
                o => o.IdNumber == student.IdNumber
            );

            if (a == false && student.IdNumber.Length == 11 && StudentAge > 16)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();

                return Ok();
            }

            return BadRequest();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            bool a = _context.Students.Any(
                o => o.Id == id
            );

            if (a == true)
            {
                _context.Students.Remove(_context.Students.FirstOrDefault(e => e.Id == id));
                await _context.SaveChangesAsync();

                return Ok();
            }

            return BadRequest();
        }
    }
}
