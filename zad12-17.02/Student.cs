using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace zad12_17._02
{
    internal class Student
    {
        //new int[] ages = new int[4];
        public string Name { get; set; }
        public int Age { get; set; }
      
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} - {Age} years old";
        }
    }
}
