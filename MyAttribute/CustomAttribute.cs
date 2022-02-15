using System;
using System.Collections.Generic;
using System.Text;

namespace MyAttribute
{
    /// <summary>
    /// 特性是一个继承自Attribute的子类,
    /// 特性生成再metedata，所以用反射
    /// </summary>
    [AttributeUsage(AttributeTargets.All,AllowMultiple = false , Inherited = true)] // 可以多重修饰，没有多大意义, 特性能否继承
    public class CustomAttribute : Attribute
    {
        public CustomAttribute()
        {
            Console.WriteLine("this is CustomAttribute");
        }
        public CustomAttribute(string remark)
        {
            Console.WriteLine("this is CustomAttribute with remark");
        }
        public string Remark { get; set; }
        public string Description;
        public void Show()
        {
            Console.WriteLine($"THis is {this.GetType().Name} SHow!");
        }
    }
    public class CustomChildAttribute : Attribute
    {

    }
    public class AuthorityAttribute : Attribute
    {
        public string Remark { get; set; }
        public bool IsLogin()
        {
            return new Random().Next(100, 200) > new Random().Next(99, 199);
        }
    }
}
