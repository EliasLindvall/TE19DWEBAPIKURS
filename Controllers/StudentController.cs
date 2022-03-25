using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TE19DWEBAPIKURS.Models;
using TE19DWEBAPIKURS.Services.studentServices;

namespace TE19DWEBAPIKURS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _StudentService;

        public StudentController(IStudentService StudentService) {
            _StudentService = StudentService;
        }
        
        [HttpGet]
        public ActionResult<List<Student>> GetStudents() => Ok(_StudentService.GetStudentList());

        [HttpPost]
        public ActionResult<List<Student>> AddStudent(Student newStudent) {
            return Ok(_StudentService.AddStudent(newStudent));
        }

        [HttpDelete]
        public ActionResult<List<Student>> RemoveStudent(int id) {
            return Ok(_StudentService.RemoveStudent(id));
        }

    }
}