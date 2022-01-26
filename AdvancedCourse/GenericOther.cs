using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCourse
{
    /// <summary>
    /// 泛型:四种用途：泛型方法，泛型类，泛型接口，泛型委托。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericClass<T>
    {
        public T Property { get; set; }
    }
    public interface IGernericInterface<T>
    {
        public abstract string GetClass(T tParameter);
    }
    public delegate void DoNothing<T>();
    public class ChildClass : GenericClass<int>, IGernericInterface<string>
    {
        public string GetClass(string tParameter)
        {
            return null;
        }
    }
    public class ChildClassGeneric<T, S, L> : GenericClass<T>, IGernericInterface<S>
    {
        public string GetClass(S tParameter)
        {
            return tParameter.ToString()+tParameter.GetType().Name;
        }
    }
}
