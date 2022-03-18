using System;
using System.Collections.Generic;
using System.Text;
using WEB.Domain.Entity;
using WEB.Domain.Interface;

namespace WEB.Application
{
    public class StudentApplication : IStudentApplication
    {
        private readonly IStudentDomainService _studentDomainService;
        public StudentApplication(IStudentDomainService studentDomainService)
        {
            _studentDomainService = studentDomainService;
        }
        public Student GetStudentById(int id)
        {
            return _studentDomainService.GetStudentById(id);
        }
    }
}
