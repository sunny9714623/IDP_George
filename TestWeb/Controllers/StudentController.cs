using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB.Application;
using WEB.Domain.Entity;
using WEB.Domain.Entity.Entity;
using WEB.Domain.Interface;

namespace TestWeb.Controllers
{
    [Route("[Controller]")]
    public class StudentController : Controller
    {
        private readonly IStudentApplication _studentApplication;
        private readonly IStudentDomainService _studentDomainService;
        public StudentController(IStudentApplication studentApplication, IStudentDomainService studentDomainService)
        {
            _studentApplication = studentApplication;
            _studentDomainService = studentDomainService;
        }
        [HttpGet]
        public IActionResult Get([FromQuery]int id)
        {
            var data = _studentApplication.GetStudentById(id);
            return Ok(data);
        }

        [HttpGet("Students")]
        public IActionResult GetStudents()
        {
            var data = _studentDomainService.GetStudents();
            return Ok(data);
        }

        [HttpPost]
        public IActionResult PostStudent([FromBody]Student student)
        {
            var data = _studentDomainService.AddStudent(student);
            return Ok(data);
        }

        [HttpPut]
        public IActionResult PutStudent([FromBody]Student student)
        {
            _studentDomainService.UpdateStudent(student);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteStudent(int id)
        {
            _studentDomainService.DeleteStudent(id);
            return Ok();
        }
    }
}
