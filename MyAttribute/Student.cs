using System;
using System.Collections.Generic;
using System.Text;

namespace MyAttribute
{
    /// <summary>
    /// 特性可以影响编译器运行
    /// 特性可以影响程序运行
    /// 特性其实是生成metadata的（描述DLL）
    /// </summary>
    // [Obsolete("Out of Date",true)] //标记过期,true指定报错（error）
    //[Serializable] // 可以序列化和反序列化
    //[Custom("Student")]
    [Custom("This is Student",Description = "Description",Remark ="1234")]
    //[Custom(Description = "Description - 1", Remark = "1234sa")] // 调用构造函数，声明属性,字段
    public class Student
    {
        public Student()
        {
            Console.WriteLine("This is Student");
        }
        [Custom]
        public int Id { get; set; }
        public string Name { get; set; }
        [Custom]
        public string Remark;
        [Custom]
        public void Study()
        {
            Console.WriteLine($" Here is {this.Name}");
        }
        [Custom]
        [Authority(Remark = "Answer - 1")]
        [return : Custom] //对返回值声明特性
        public string Answer([Custom] string name)
        {
            Console.WriteLine($"This is Answer {name}");
            return $"This is {name}";
        }
    }
}
