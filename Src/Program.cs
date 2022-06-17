using DayBook.Src.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DayBook
{
    internal class Program
    {
        private static readonly IList<Student> _students = new List<Student>();

        private static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Choose {\n(1) - AddStudent,\n(2) - PrintStudents,\n(3) - Print Students with progress > 4,\n(4) - find student\n}");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        AddStudent();
                        break;
                    case ConsoleKey.D2:
                        PrintStudents();
                        break;
                    case ConsoleKey.D3:
                        PrintUnderNumber();
                        break;
                    case ConsoleKey.D4:
                        FindStudent();
                        break;
                }
            }
        }

        private static void AddStudent()
        {
            Console.Write("Введіть фамілію: ");
            var surname = Console.ReadLine();
            Console.Write("Введіть ім'я: ");
            var name = Console.ReadLine();
            Console.Write("Введіть по батькові: ");
            var patronymic = Console.ReadLine();
            Console.Write("Введіть оцінку: ");
            var grade = Convert.ToInt32(Console.ReadLine());
            _students.Add(
                new Student(surname,
                name,
                patronymic,
                grade,
                null));
        }

        private static void PrintStudents()
        {
            for (int i = 0; i < _students.Count; i++)
            {
                Console.WriteLine($"СТУДЕНТ [{i}]: {_students[i]}");
            }
        }

        private static void PrintUnderNumber()
        {
            Console.WriteLine("СТУДЕНТЫ С ОЦЕНКОЙ БОЛЬШЕ 4");
            foreach (Student student in _students)
            {
                if (student.Progress > 4)
                    Console.WriteLine(student.ToString());
            }
        }

        private static void FindStudent()
        {
            Console.Write("Найти студента: ");
            string studentName = Console.ReadLine()
                .ToLower();
            foreach (Student student in _students)
            {
                if (student.Name
                    .ToLower()
                    .Contains(studentName))
                {
                    Console.WriteLine(student);
                }
            }
        }
    }
}
