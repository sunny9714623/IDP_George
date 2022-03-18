using System;
using System.Collections.Generic;
using System.Text;
using WEB.Domain.Entity;

namespace WEB.Domain.Interface
{
    public interface IStudentDomainService
    {
        Student GetStudentById(int id);
        bool UpdateStudent(Student student);
        List<Student> AddStudent(Student student);
        bool DeleteStudent(int id);
    }
}
