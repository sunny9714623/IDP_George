using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyAttribute
{
    /// <summary>
    /// 特性编译后是metadata ，只有发射才能使用
    /// 包了一层， 专门来使用特性
    /// </summary>
    public class PeopleManager
    {
        public static void Manage(Student student)
        {
            #region MyRegion
            {
                Type type = typeof(Student);
                if (type.IsDefined(typeof(CustomAttribute), true)) // 检测有没有这个特性
                {
                    CustomAttribute item = type.GetCustomAttribute(typeof(CustomAttribute), true) as CustomAttribute;
                    //foreach (var item in type.GetCustomAttributes(typeof(CustomAttribute), true)) // 会调用特性的初始化函数
                    {
                        item.Show();
                    }
                }
                foreach (var item in type.GetProperties()) //属性
                {
                    if (item.IsDefined(typeof(CustomAttribute), true))
                    {
                        CustomAttribute item1 = type.GetCustomAttribute(typeof(CustomAttribute), true) as CustomAttribute;
                    }
                }
                foreach (var item in type.GetFields()) //字段
                {
                    if (item.IsDefined(typeof(CustomAttribute), true))
                    {
                        CustomAttribute item1 = type.GetCustomAttribute(typeof(CustomAttribute), true) as CustomAttribute;
                    }
                }
                foreach (var item in type.GetConstructors()) //构造函数
                {
                    if (item.IsDefined(typeof(CustomAttribute), true))
                    {
                        CustomAttribute item1 = type.GetCustomAttribute(typeof(CustomAttribute), true) as CustomAttribute;
                    }
                }
                MethodInfo method = type.GetMethod("Answer");
                if (method.IsDefined(typeof(CustomAttribute), true)) // 方法
                {
                    CustomAttribute item = type.GetCustomAttribute(typeof(CustomAttribute), true) as CustomAttribute;
                }
                foreach (var item in method.GetParameters())  // 参数
                {
                    if (item.IsDefined(typeof(CustomAttribute), true))
                    {
                        CustomAttribute item1 = type.GetCustomAttribute(typeof(CustomAttribute), true) as CustomAttribute;
                    }
                }
                if (method.ReturnParameter.IsDefined(typeof(CustomAttribute), true)) //返回参数, 返回所有特性
                {
                    object oAttribute = method.ReturnParameter.GetCustomAttribute(typeof(CustomAttribute));
                }

                student.Study();
                student.Answer("George");
            }
            #endregion
            {
                // 有了特性，可以多一点行为，权限检查, 可以多一点信息
                Type type = typeof(Student);
                MethodInfo method = type.GetMethod("Answer");
                if (method.IsDefined(typeof(AuthorityAttribute),true))
                {
                    object item = method.GetCustomAttributes(typeof(AuthorityAttribute), true)[0];
                    AuthorityAttribute attribute = item as AuthorityAttribute;
                    Console.WriteLine(attribute.Remark);
                    //if (DateTime.Now > DateTime.Now.AddDays(1)) // 我们可以使用httpcontext,current.cookie/session
                    //{
                    //    throw new Exception("没有权限"); // redirect
                    //}
                    if (!attribute.IsLogin())
                    {
                        throw new Exception("没有权限"); // redirect
                    }
                }
                student.Answer("赵亮");
            }
            {
                Type type = typeof(Student);
                MethodInfo method = type.GetMethod("Answer");
                if (method.IsDefined(typeof(AuthorityAttribute), true))
                {
                    object item = method.GetCustomAttributes(typeof(AuthorityAttribute), true)[0];
                    AuthorityAttribute attribute = item as AuthorityAttribute;
                    if (!attribute.IsLogin())
                    {
                        throw new Exception("没有权限"); // redirect
                    }
                }
                student.Study();
            }
        }
    }
}
