using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WEB.Domain.Entity.Entity;

namespace WEB.Domain.Interface
{
    public interface IStudentDomainService
    {
        Student GetStudentById(int id);
        void UpdateStudent(Student student);
        List<Student> AddStudent(Student student);
        void DeleteStudent(int id);
        List<Student> GetStudents();
    }
}
