using System.Collections.Generic;
using System;
using System.Text;
using System.Linq;

namespace LinqLAB
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }

    //public override string ToString()
    //{     
    //    string output = $"Name: {Name}" + "\n" + $"Age: {Age}";
    //    return output;
    //}
}
