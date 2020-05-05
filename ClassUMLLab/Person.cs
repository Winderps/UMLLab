using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUMLLab
{
    public class Person
    {
        public string Name { get; protected set; }
        public string Address { get; protected set; }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            return $"Name: {Name}. Address: {Address}";
        }
    }
}
