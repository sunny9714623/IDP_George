using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCourse
{
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Chinese : People, ISport
    {
        public void Swim()
        {
            Console.WriteLine("I Can Swim!!!!!!!!!!");
        }
    }
    public class Hubei : People
    {

    }
    public interface ISport
    {
        void Swim();
    }
}
