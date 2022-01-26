using System;

namespace AdvancedCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************");
            object test = "123";
            int iValue = 4;
            GenericMethod.Show(test); 
            GenericMethod.Show(iValue);
            GenericClass<int> iGenericClass = new GenericClass<int>();
            iGenericClass.Property = 1;
            ChildClassGeneric<int, string, DateTime> childClassGeneric = new ChildClassGeneric<int, string, DateTime>();
            childClassGeneric.Property = 2;
            Console.WriteLine(childClassGeneric.GetClass("Test"));
            DoNothing<int> doNothing = new DoNothing<int>(() => { });
            Console.WriteLine(doNothing);
            Console.WriteLine("*************************");
            Chinese chinese = new Chinese() { Id = 1, Name = "George" };
            Hubei hubei = new Hubei() { Id = 2, Name = "Wuhan" };
            Contraint.DoNothing(chinese);

        }
    }
}
