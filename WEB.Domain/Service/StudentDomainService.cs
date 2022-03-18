using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEB.Domain.Data;
using WEB.Domain.Entity;
using WEB.Domain.Entity.Entity;
using WEB.Domain.Interface;
using WEB.Infrusture;

namespace WEB.Domain.Service
{
    public class StudentDomainService : IStudentDomainService
    {
        private readonly WebDBContext _webDBContext;
        public StudentDomainService(WebDBContext webDBContext)
        {
            _webDBContext = webDBContext;
        }

        public List<Student> AddStudent(Student student)
        {
            _webDBContext.Students.Add(student);
            _webDBContext.SaveChanges();
            return _webDBContext.Students.ToList();
        }

        public void DeleteStudent(int id)
        {
            Student studet = _webDBContext.Students.FirstOrDefault(m => m.ID == id);
            if (studet == null)
            {
                throw new ArgumentException("Id 不存在");
            }
            _webDBContext.Students.Remove(studet);
            _webDBContext.SaveChanges();
        }

        public Student GetStudentById(int id)
        {
            return _webDBContext.Students.Where(t => t.ID == id).FirstOrDefault();
        }

        public List<Student> GetStudents()
        {
            return  _webDBContext.Students.ToList();
        }

        public void UpdateStudent(Student student)
        {
            _webDBContext.Students.Update(student);
            _webDBContext.SaveChanges();
        }
    }
}
