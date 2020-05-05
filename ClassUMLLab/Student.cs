using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUMLLab
{
    class Student : Person
    {
        public string Program { get; protected set; }
        public int Year { get; protected set; }
        public double Fee { get; protected set; }

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public Student() : base("Chuck Norris", "0000 Nowhere Ln")
        {
            Program = "Hard Knocks 101";
            Year = 1969;
            Fee = 13.37;
        }

        public override string ToString()
        {
            return base.ToString() + $" Program: {Program}. Year: {Year}. Fee: {Fee:C2}";
        }
    }
}
