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

        public string FullName => $"{studentSurname} {studentName.Substring(0, 1)}. {studentPatronymic.Substring(0, 1)}.";

        public string StudentSurname
        {
            get => studentSurname;
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
            get => studentName;
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
            get => studentPatronymic;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Отчество студента не может быть путсым.");
                }
                studentPatronymic = value;
            }

        }
    }
}
