using System;
using System.Collections.Generic;
using System.Text;

namespace Ruanmou.DB.SqlServer
{
    /// <summary>
    /// 反射测试类
    /// </summary>
    public class ReflectionTest
    {
        #region Identity
        public ReflectionTest()
        {
            Console.WriteLine("这里是{0} no parameter 构造函数", this.GetType());
        }
        public ReflectionTest(string name)
        {
            Console.WriteLine("这里是{0} has parameters 构造函数", this.GetType());
        }
        public ReflectionTest(int id)
        {
            Console.WriteLine("这里是{0} has parameters 构造函数", this.GetType());
        }
        #endregion
        #region Method
        /// <summary>
        /// 无参方法
        /// </summary>
        public void Show1()
        {
            Console.WriteLine("这里是{0}的Show1", this.GetType());
        }
        /// <summary>
        /// 有参数方法
        /// </summary>
        /// <param name="id"></param>
        public void Show2(int id)
        {
            Console.WriteLine("这里是{0}的Show2", this.GetType());
        }
        /// <summary>
        /// 重载方法
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public void Show3()
        {
            Console.WriteLine("这里是{0}的Show3", this.GetType());
        }
    public void Show3(int id,string name)
        {
            Console.WriteLine("这里是{0} overwrite3_1 Show3", this.GetType());
        }
        public void Show3(string name,int id)
        {
            Console.WriteLine("这里是{0} overwrite3_2 Show3", this.GetType());
        }
        public void Show3(int id)
        {
            Console.WriteLine("这里是{0} overwrite3_3 Show3", this.GetType());
        }
        public void Show3(string name)
        {
            Console.WriteLine("这里是{0} overwrite3_4 Show3", this.GetType());
        }
        private void Show4(string name)
        {
            Console.WriteLine("这里是{0} of Show4", this.GetType());
        }
        public static void Show5(string name)
        {
            Console.WriteLine("这里是{0} of Show5", typeof(ReflectionTest));
        }
        #endregion
    }
}
