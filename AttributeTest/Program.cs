using System;
using System.Reflection;

namespace AttributeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MemberInfo memberInfo1 = typeof(MyAttributeTest);
            Console.WriteLine(memberInfo1.Name);
            TypeInfo typeInfo = typeof(MyAttributeTest).GetTypeInfo();
            Console.WriteLine(typeInfo.FullName);
            var test = (typeInfo.GetCustomAttribute(typeof(MyAttribute), true)) as MyAttribute;
            Console.WriteLine(test.Test);
            MemberInfo[] memberInfos = typeof(MyAttributeTest).GetMembers();
            MethodInfo[] methodInfos = typeof(MyAttributeTest).GetMethods();
            FieldInfo[] fieldInfos = typeof(MyAttributeTest).GetFields();
            PropertyInfo[] propertyInfos = typeof(MyAttributeTest).GetProperties();
            foreach (var item in propertyInfos)
            {
                if ((item.GetCustomAttribute(typeof(MyAttribute), true)) is MyAttribute)
                {
                    var test1= (item.GetCustomAttribute(typeof(MyAttribute), true)) as MyAttribute;
                    Console.WriteLine(item.Name);
                    Console.WriteLine(test1.Test);
                }
            }
            Console.ReadKey();
        }
    }
    [My("George", Id = 1)]
    public class MyAttributeTest
    {
        public int CardId;
        private Guid Guiid;
        [My("property_attribute")]
        public int IdNumber { get; set; }

    }
    // 定义可以Usage的地方
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class MyAttribute : Attribute
    {
        private string name="123";
        public int Id { get; set; }
        public string Test { get; set; }
        public MyAttribute(string test)
        {
            this.Test = test;
            this.name = test;
        }
    }
}
