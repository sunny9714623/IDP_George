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
        Task<Student> UpdateStudentAsync(Student student);
        List<Student> AddStudent(Student student);
        Task DeleteStudent(int id);
        List<Student> GetStudents();
    }
}
