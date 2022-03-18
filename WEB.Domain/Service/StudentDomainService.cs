using Microsoft.Extensions.Logging;
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
        private readonly ILogger<StudentDomainService> _logger;
        public StudentDomainService(WebDBContext webDBContext, ILogger<StudentDomainService> logger)
        {
            _webDBContext = webDBContext;
            _logger = logger;
        }

        public List<Student> AddStudent(Student student)
        {
            _webDBContext.Students.Add(student);
            _webDBContext.SaveChanges();
            return _webDBContext.Students.ToList();
        }

        public async Task DeleteStudent(int id)
        {
            Student studet = _webDBContext.Students.FirstOrDefault(m => m.ID == id);
            if (studet == null)
            {
                throw new ArgumentException("Id 不存在");
            }
            _webDBContext.Students.Remove(studet);
            await _webDBContext.SaveChangesAsync();
        }

        public Student GetStudentById(int id)
        {
            return _webDBContext.Students.Where(t => t.ID == id).FirstOrDefault();
        }

        public List<Student> GetStudents()
        {
            return  _webDBContext.Students.ToList();
        }

        public async Task<Student> UpdateStudentAsync(Student student)
        {
            try
            {
                _webDBContext.Students.Update(student);
                await _webDBContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return student;
        }
    }
}
