using Ruanmou.DB.Interface;
using Ruanmou.DB.MySql;
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
                Console.WriteLine("***************Reflection*************");
                Assembly assembly = Assembly.LoadFrom("Ruanmou.DB.SqlServer.dll");// 默认加载exe路径下的dll或者exe，不需要后缀
                //Assembly assembly1 = Assembly.LoadFile(@"D:\codecollect\C#编程\IDP_George\MyReflection\bin\Debug\netcoreapp3.1\Ruanmou.DB.MySql.dll");
                //Assembly assembly2 = Assembly.LoadFrom("Ruanmou.DB.MySql.dll");
                // 只要dll在不会异常，使用的时候，没有依赖项，可能异常
                foreach(var item in assembly.GetModules())
                {
                    Console.WriteLine(item.Name);
                }
                foreach (var type in assembly.GetTypes())
                {
                    Console.WriteLine(type.Name);
                    foreach (var item in type.GetMethods())
                    {
                        Console.WriteLine(item);
                    }
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
