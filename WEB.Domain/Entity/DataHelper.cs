using System;
using System.Collections.Generic;
using System.Text;

namespace WEB.Domain.Entity
{
    public static class DataHelper
    {
        public static List<Student> Students = new List<Student> {
                new Student { ID=1,Name="one", Age=1},
                new Student { ID = 2, Name = "two", Age = 2 },
                new Student { ID = 3, Name = "three", Age = 3 } };
    }
}
