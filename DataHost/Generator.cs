using System.Collections;
using System.Collections.Generic;
using System.Windows.Documents;
using System.Windows.Media.Animation;

namespace DataHost
{
    public static class Generator
    {
        public static IEnumerable<Person> GetPeople()
        {
            var list = new List<Person>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(new Person{Age = i, Name = ((char)i).ToString()});
            }

            return list;
        }

        public static IEnumerable<Animal> GetAnimals()
        {
            var list = new List<Animal>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(new Animal { Breed = "notImportant", Name = ((char)i).ToString() });
            }
            return list;
        }
    }
}