using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayBook
{
    class Student
    {
        private string studentSurname;
        private string studentName;
        private string studentPatronymic;

        public Student(string Surname, string Name, string Patronymic)
        {
            StudentSurname = Surname;
            StudentName = Name;
            StudentPatronymic = Patronymic;
        }

        public string FullName
        {
            get
            {
                return $"{studentSurname} {studentName.Substring(0, 1)}. {studentPatronymic.Substring(0, 1)}.";
            }
        }

        public string StudentSurname
        {
            get
            {
                return studentSurname;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Фамилия студента не может быть пустым.");
                }
                studentSurname = value;
            }
        }

        public string StudentName
        {
            get
            {
                return studentName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Имя студента не может быть путсым.");
                }
                studentName = value;
            }
        }

        public string StudentPatronymic
        {
            get
            {
                return studentPatronymic;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Отчество студента не может быть путсым.");
                }
                studentPatronymic = value;
            }

        }

        public string Record()
        {
            for (int i = 0; i < 5; i++)
            {
                string[] surname = new string[5];
                {
                    Console.Write("Введите фамилию: ");
                    surname[i] = Console.ReadLine();
                }
                string[] name = new string[5];
                {
                    Console.Write("Введите имя: ");
                    name[i] = Console.ReadLine();
                }
                string[] patronymic = new string[5];
                {
                    Console.Write("Введите отчество: ");
                    patronymic[i] = Console.ReadLine();
                }
                Student student = new Student(surname[i], name[i], patronymic[i]);

                Console.WriteLine($"Студент: {student.FullName}\n");
            }
            return "1";
        }
    }

    
}
