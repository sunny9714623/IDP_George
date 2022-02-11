using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedCourse
{
    public class Contraint
    {
        /// <summary>
        /// 基类约束：
        /// 1.带来权力，可以使用基类里面的属性和方法
        /// 2.带来义务：类型参数必须是积累或者其子类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tParameter"></param>
        public static void Show<T>(T tParameter) where T : People
        {
            IEnumerable<int> intList = new List<int>();
            Action<int> iAction = null;
            Bird bird1 = new Sparrow();
            Sparrow sparrow1 = new Sparrow();
            List<Bird> birds = new List<Sparrow>().Select(t=>(Bird)t).ToList();
            // 协变：接口泛型参数加了个out，就是为了解决刚才的不和谐
            IEnumerable<Bird> birds1 = new List<Sparrow>();
            Console.WriteLine("This is {0},parameter={1},type={2}", typeof(GenericMethod), tParameter.ToString(), tParameter.GetType().Name);
            Console.WriteLine(tParameter.Id);
            Console.WriteLine(tParameter.Name);
        }

        public static void DoNothing<T>(T tParameter)
            where T : ISport // 接口约束
        {
            tParameter.Swim();
        }

        public static T DoNothing2<T>(T tParameter)
            //where T : class // 引用类型约束
            // where T : struct //值类型约束
            where T : new() // 无参数构造函数约束
        {
            // return default;//语法糖，会根据T的类型，去产生一个默认值
            T t = new T();
            return default(T);
        }
        public class Bird
        {
            public int Id { get; set; }
        }
        public class Sparrow : Bird
        {
            public string Name { get; set; }
        }
    }
}
