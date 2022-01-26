using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCourse
{
    public class GenericMethod
    {
        /// <summary>
        /// 泛型
        /// 延迟声明，把参数类型的声明推迟到调用
        /// 在性能上和原生方法一样
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tParameter"></param>
        public static void Show<T>(T tParameter)
        {
            Console.WriteLine("This is {0},parameter={1},type={2}", typeof(GenericMethod), tParameter.ToString(), tParameter.GetType().Name);
        }
        private static void ShowObject(object oParameter)
        {
            Console.WriteLine("This is {0},parameter={1},type={2}", typeof(GenericMethod), oParameter, oParameter.GetType().Name); 
        }
    }
}
