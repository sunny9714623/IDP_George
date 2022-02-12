using System;
using System.Collections.Generic;
using System.Text;

namespace Ruanmou.DB.SqlServer
{
    /// <summary>
    /// 单例模式 : 类型在运行过程中只会被实例化一次：1.构造函数私有化，2获取实例通过静态方法，返回静态字段，静态字段通过静态构造函数初始化
    /// sealed : 不能被继承
    /// </summary>
    public sealed class Singleton
    {
        private static Singleton _Singleton = null;
        private Singleton()
        {
            Console.WriteLine("Singleton Construct");
        }
        /// <summary>
        /// 静态构造函数只会执行一次
        /// </summary>
        static Singleton()
        {
            _Singleton = new Singleton();
        }
        public static Singleton GetInstance()
        {
            return _Singleton;
        }
    }
}
