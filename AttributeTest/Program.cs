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
            var myatbut = new MyAttributeTest(2,100);
            var test = typeInfo.GetCustomAttributes(typeof(MyAttribute), true);
            foreach (var item in test)
            {
                var a = item as MyAttribute;
                Console.WriteLine(a.Test);
            }
            MemberInfo[] memberInfos = typeof(MyAttributeTest).GetMembers();
            MethodInfo[] methodInfos = typeof(MyAttributeTest).GetMethods();
            FieldInfo[] fieldInfos = typeof(MyAttributeTest).GetFields();
            PropertyInfo[] propertyInfos = myatbut.GetType().GetProperties();
            foreach (var item in propertyInfos)
            {
                Console.WriteLine("******* property.Name *******");
                Console.WriteLine(item.Name);
                Console.WriteLine("******* property.Name *******");
                if ((item.GetCustomAttribute(typeof(MyAttribute), true)) is MyAttribute)
                {
                    var test1 = (item.GetCustomAttribute(typeof(MyAttribute), true)) as MyAttribute;
                    Console.WriteLine(item.Name);
                    Console.WriteLine(test1.Test);
                }
                Console.WriteLine("****************");
                Console.WriteLine(item.GetValue(myatbut,null));
                Console.WriteLine("****************");
            }
            foreach (var item in fieldInfos)
            {
                Console.WriteLine("****************");
                Console.WriteLine(item.GetValue(myatbut));
                Console.WriteLine("****************");
            }
            Console.WriteLine("***********");
            TypeInfo typeInfo1 = typeof(MyAttributeTest1).GetTypeInfo();
            Console.WriteLine(typeInfo1.FullName);
            //var testt = (typeInfo1.GetCustomAttribute(typeof(MyAttribute), true)) as MyAttribute;
            //Console.WriteLine(testt.Test);
            Console.WriteLine("**********Property");
            PropertyInfo[] propertyInfos1 = typeof(MyAttributeTest1).GetProperties();
            foreach (var item in propertyInfos1)
            {
                if ((item.GetCustomAttribute(typeof(MyAttribute), true)) is MyAttribute)
                {
                    var test1 = (item.GetCustomAttribute(typeof(MyAttribute), true)) as MyAttribute;
                    Console.WriteLine(item.Name);
                    Console.WriteLine(test1.Test);
                }
            }
            Console.ReadKey();
        }
    }
    [My("George", Id = 1)]
    [My("George2",Id = 2)]
    public class MyAttributeTest
    {
        public int CardId;
        private Guid Guiid => Guid.NewGuid();
        [My("property_attribute")]
        public int IdNumber { get; set; }
        public MyAttributeTest(int cardId,int IdNumber)
        {
            this.CardId = cardId;
            this.IdNumber = IdNumber;
        }
    }

    public class MyAttributeTest1 : MyAttributeTest
    {
        public MyAttributeTest1(int id,int idnum) : base(id, idnum)
        {

        }
    }
    // 定义可以Usage的地方
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property,Inherited = true,AllowMultiple = true)]
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
