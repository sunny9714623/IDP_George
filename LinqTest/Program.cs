using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet[] cats = GetCats();
            Pet[] dogs = GetDogs();

            var test = new { cats, dogs };
            IEnumerable<Pet> query =
                new[] { cats, dogs }.SelectMany(t => t);

            foreach (Pet name in query)
            {
                Console.WriteLine(name.Name);
            }
        }
        static Pet[] GetCats()
        {
            Pet[] cats = { new Pet { Name="Barley", Age=8 },
                   new Pet { Name="Boots", Age=4 },
                   new Pet { Name="Whiskers", Age=1 } };
            return cats;
        }

        static Pet[] GetDogs()
        {
            Pet[] dogs = { new Pet { Name="Bounder", Age=3 },
                   new Pet { Name="Snoopy", Age=14 },
                   new Pet { Name="Fido", Age=9 } };
            return dogs;
        }
    }

    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
