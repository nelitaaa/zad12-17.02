using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace zad12_17._02
{

    class Program
    {
        static void BubbleSort(List<Student> students)
        {
            int n = students.Count;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (students[j].Age > students[j + 1].Age)
                    {
                        var temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }
            }
        }

        static void Main()
        {
            List<Student> students = new List<Student>
        {
            new Student("Ivan", 16),
            new Student("Maria", 15),
            new Student("Georgi", 17),
            new Student("Elena", 14)
        };

            Console.WriteLine("Преди сортиране:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            BubbleSort(students);

            Console.WriteLine("\nСлед сортиране:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
