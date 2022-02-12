using Ruanmou.DB.Interface;
using Ruanmou.DB.MySql;
using Ruanmou.DB.SqlServer;
using System;
using System.Reflection;

namespace MyReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region 常规
                Console.WriteLine("**************Common**************");
                IDBHelper dBHelper = new MySqlHelper();
                dBHelper.Query();
                #endregion
                #region 反射
                //Console.WriteLine("***************Reflection*************");
                //Assembly assembly = Assembly.Load("Ruanmou.DB.MySql");// 默认加载exe路径下的dll或者exe，不需要后缀
                //Assembly assembly1 = Assembly.LoadFile(@"D:\codecollect\C#编程\IDP_George\MyReflection\bin\Debug\netcoreapp3.1\Ruanmou.DB.MySql.dll");
                //Assembly assembly2 = Assembly.LoadFrom("Ruanmou.DB.MySql.dll");
                // 只要dll在不会异常，使用的时候，没有依赖项，可能异常
                //foreach(var item in assembly.GetModules())
                //{
                //    Console.WriteLine(item.Name);
                //}
                //foreach (var type in assembly.GetTypes())
                //{
                //    Console.WriteLine(type.Name);
                //    foreach (var item in type.GetMethods())
                //    {
                //        Console.WriteLine(item);
                //    }
                //}
                
                // 反射的价值：对类型的依赖转换为对字符串的依赖
                //Type typeDBHelper = assembly.GetType("Ruanmou.DB.MySql.MySqlHelper");// 获取类型信息
                //object oDbhelper = Activator.CreateInstance(typeDBHelper); //创建对象
                //// oDbhelper.Query();
                //IDBHelper iDBhelper = oDbhelper as IDBHelper; // 类型转换
                //iDBhelper.Query(); // 方法调用
                //#endregion
                //#region Reflection + Factory + Config  IOC的雏形
                //Console.WriteLine("***************Reflection + Factory + Config*************");
                //IDBHelper dBHelperFactory = SimpleFactory.CreateHelper();
                //dBHelperFactory.Query();
                #endregion

                #region Reflection + Factory + Config  IOC的雏形
                //Console.WriteLine("***************Reflection*************");
                //Assembly assembly = Assembly.Load("Ruanmou.DB.SqlServer");
                //Type testType = assembly.GetType("Ruanmou.DB.SqlServer.ReflectionTest");
                //object oTest1 = Activator.CreateInstance(testType);// 默认调用无参数的构造函数
                //object oTest2 = Activator.CreateInstance(testType,new object[] { });
                //object oTest3 = Activator.CreateInstance(testType, new object[] { 895});
                //object oTest4 = Activator.CreateInstance(testType, new object[] { "桃树"});
                //// 这里要使用泛型的占位符
                //Type genericType = assembly.GetType("Ruanmou.DB.SqlServer.GenericClass`3");
                //// 指定泛型类型
                //Type genericNewType = genericType.MakeGenericType(typeof(int),typeof(string),typeof(Program));
                //object oGeneric = Activator.CreateInstance(genericNewType);
                ////Singleton singleton = new Singleton(); // 不能访问，构造函数私有的, 破坏单例
                //Type singletonType = assembly.GetType("Ruanmou.DB.SqlServer.Singleton");
                //object oSingleton1 = Activator.CreateInstance(singletonType, true);
                //object oSingleton2 = Activator.CreateInstance(singletonType, true);
                //object oSingleton3 = Activator.CreateInstance(singletonType, true);
                #endregion
                #region Reflection Method  MVC
                Console.WriteLine("***************Reflection*************");
                Assembly assembly = Assembly.Load("Ruanmou.DB.SqlServer");
                Type testType = assembly.GetType("Ruanmou.DB.SqlServer.ReflectionTest");
                object oTest1 = Activator.CreateInstance(testType);// 默认调用无参数的构造函数
                {
                    MethodInfo method = testType.GetMethod("Show1");
                    method.Invoke(oTest1, null);
                }
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
