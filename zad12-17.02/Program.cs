using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace zad12_17._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
             new Student("John", 20),
             new Student("Jane", 19),
             new Student("Alice", 24),
             new Student("Bob", 23)
            };

             

            foreach(var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            BubbleSort(students);

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }


        }

        static void BubbleSort(Student[] students)
        {
            int n = students.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (students[j].Age > students[j + 1].Age)
                        (students[j], students[j + 1]) = (students[j + 1], students[j]);

        }
    }
}
