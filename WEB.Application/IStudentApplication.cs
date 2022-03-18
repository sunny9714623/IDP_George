using System;
using System.Collections.Generic;
using System.Text;
using WEB.Domain.Entity;

namespace WEB.Application
{
    public interface IStudentApplication
    {
        Student GetStudentById(int id);
    }
}
