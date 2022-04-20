using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;

namespace AttributeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Expression<Func<int,int,int>> exp = (m,n)=>m * n + 2;
            TaskFactory taskFactory = new TaskFactory();
            taskFactory.StartNew(t => 
            { Console.WriteLine("test"); }, "test1").
            ContinueWith(t => Console.WriteLine($"ContinueWith{ t.AsyncState}"));
            Console.WriteLine(exp.Compile().Invoke(4, 5));
            List<object> test111 = new List<object>{ "1", "2", "3" };
            test111 = test111.Where(t => t == "1").ToList();
            foreach (var item in test111)
            {
                Console.WriteLine($"item{item}");
            }
            Console.WriteLine(Test1.abc.ToString());
            string test123 = "abc\nde";
            foreach (var item in test123.Split(System.Environment.NewLine).ToList())
            {
                Console.WriteLine(item);
            }
            object a1 = "123";
            Console.WriteLine(a1.ToString());
            string s1 = "sdnbajdas";
            s1 = s1.Replace("sad", "abc");
            Console.WriteLine(s1);
            MemberInfo memberInfo1 = typeof(MyAttributeTest);
            Console.WriteLine(memberInfo1.Name);
            TypeInfo typeInfo = typeof(MyAttributeTest).GetTypeInfo();
            Console.WriteLine(typeInfo.FullName);
            var myatbut = new MyAttributeTest(2,100);
            Console.WriteLine(myatbut.Test1.ToString());
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
        public Test1 Test1;
        private Guid Guiid => Guid.NewGuid();
        [My("property_attribute")]
        public int IdNumber { get; set; }
        public MyAttributeTest(int cardId,int IdNumber)
        {
            this.CardId = cardId;
            this.IdNumber = IdNumber;
        }
    }

    public enum Test1 : short
    {
        abc=1,
        bcd=2,
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
