using System;
using System.Collections.Generic;

namespace ClassUMLLab
{
    class Program
    {
        static List<Person> people = null;
        static void Main(string[] args)
        {
            people = new List<Person>();
            AddPerson(new Staff("Mike Reardon", "The Place With the Stuff", "School of Hard Rocks", 99.99));
            AddPerson(new Staff("Tommy Waalkes", "The Death Star", "Brilliant.org", 99.99));
            AddPerson(new Student("Student", "Tattoine", "Code and Such", 1993, 49.99));
            AddPerson(new Student("Yorkie", "Letterkenny, Ontario", "Hockey", 1993, 49.99));
            AddPerson(new Student("Schultzy", "Letterkenny, Ontario", "Hockey", 1993, 49.99));
            people.ForEach(x => Console.WriteLine(x.ToString()));
        }
        static void AddPerson(Person p)
        {
            people.Add(p);
        }
    }
}
