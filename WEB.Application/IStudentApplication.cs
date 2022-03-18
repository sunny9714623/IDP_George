using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WEB.Domain.Entity.Entity;

namespace WEB.Application
{
    public interface IStudentApplication
    {
        Student GetStudentById(int id);
    }
}
