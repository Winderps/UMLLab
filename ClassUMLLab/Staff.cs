using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUMLLab
{
    class Staff : Person
    {
        public string School { get; protected set; }
        public double Pay { get; protected set; }

        public Staff (string name, string address, string school, double pay) : base (name, address)
        {
            School = school;
            Pay = pay;
        }

        public Staff() : base("Chuck Norris", "0000 Nowhere Ln")
        {
            School = "School of Hard Knocks";
            Pay = 1337;
        }

        public override string ToString()
        {
            return base.ToString() + $" School: {School}. Pay: {Pay:C2}";
        }
    }
}
