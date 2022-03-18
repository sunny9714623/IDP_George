using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEB.Domain.Entity.Entity
{
    [Table("Student",Schema = "dbo")]
    public class Student
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
