using System;

namespace MyAttribute
{
    /// <summary>
    /// 特性是一个类，可以用来标记元素：编译时生成到metadata里，平时不影响程序的运行
    /// 除非用反射去查找，可以得到一些额外的信息/操作，然后给提供了更丰富的操作空间
    /// 
    /// 特性可以在不破坏类型封装的前提下，额外的增加功能
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("*****************Attribute*************");
                {
                    Student student = new Student();
                    student.Id = 1;
                    student.Name = "Test";
                    student.Study();
                    student.Answer("George");
                    PeopleManager.Manage(student);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
