using Ruanmou.DB.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using System.Text;

namespace MyReflection
{
    public class SimpleFactory
    {
        private static string TypeDll = ConfigurationManager.AppSettings["IDBHelper"];
        private static string DllName = TypeDll.Split(',')[1];
        private static string TypeName = TypeDll.Split(',')[0];
        public static IDBHelper CreateHelper()
        {
            Assembly assembly = Assembly.LoadFrom(DllName);
            Type typeDBHelper = assembly.GetType(TypeName);
            object oDBHelper = Activator.CreateInstance(typeDBHelper);
            IDBHelper iDBHelper = oDBHelper as IDBHelper;
            return iDBHelper;
        }
    }
}
