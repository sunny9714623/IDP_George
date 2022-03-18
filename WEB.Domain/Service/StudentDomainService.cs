using System;
using System.Collections.Generic;
using System.Text;
using WEB.Domain.Entity;
using WEB.Domain.Interface;

namespace WEB.Domain.Service
{
    public class StudentDomainService : IStudentDomainService
    {

        public List<Student> AddStudent(Student student)
        {
            DataHelper.Students.Add(student);
            return DataHelper.Students;
        }

        public bool DeleteStudent(int id)
        {
            return DataHelper.Students.Remove(DataHelper.Students.Find(t => t.ID == id));
        }

        public Student GetStudentById(int id)
        {
            return DataHelper.Students.Find(t => t.ID == id);
        }

        public bool UpdateStudent(Student student)
        {
            return true;
        }
    }
}
